using Client.FormIhm.ServiceBagageReferencePim;
using MyAiport.Pim.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAirport.Pim.Client
{
    public partial class FormIhm : Form
    {
        public delegate void PimStateEventHandler(object sender, PimState state);
        public event PimStateEventHandler PimStateChanged;

        private BagageSelect SelectBag = null;

        private PimState state = PimState.Deconnecter;
        //private List<Entities.BagageDefinition> bags = new List<Entities.BagageDefinition>();
        private BagageDefinition[] bags = new BagageDefinition[] { };
        //public List<BagageDefinition> bagages = new List<BagageDefinition>();

        public PimState State
        {
            get { return state; }
            set { OnPimStateChanged(value); }
        }

        ServicePimClient proxy = null;
        
        public FormIhm()
        {
            InitializeComponent();
            PimStateChanged += FormIhm_PimStateChanged;
            OnPimStateChanged(PimState.Deconnecter, true);
            proxy = new ServicePimClient();
            //+= aj la fonction il la crée automatiquement en plus !!
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //State = PimState.CreationBagage;
            //bags = Factory.Model.GetBagage(this.comboBox1.Text);
            bags = proxy.GetBagageByCodeIata(this.comboBox1.Text);

            //bags.Count devient bags.Length
            if (bags.Length == 0)
            {
                this.State = PimState.CreationBagage;
            }
            else if (bags.Length == 1)
            {
                this.State = PimState.AffichageBagage;
            }
            else
            {
                this.State = PimState.SelectionBagage;
            }
        }

        private void FormIhm_PimStateChanged(object sender, PimState state)
        {
            switch (state)
            {
                case PimState.Deconnecter:
                    Deconnecter();
                    break;
                case PimState.SelectionBagage:
                    SelectionBagage();
                    //selectionBagageToolStripMenuItem_Click(null, null);
                    break;
                case PimState.CreationBagage:
                    creationBagageToolStripMenuItem_Click(null, null);
                    break;
                case PimState.AttenteBagage:
                    AttenteBagage();
                    break;
                case PimState.AffichageBagage:
                    AfficherBagage();
                    break;

            }
                
        }

        private void OnPimStateChanged(PimState newState, bool force=false)
        {
            if (newState != this.state || force)
            {
                this.state = newState;
                if (this.PimStateChanged != null) //Première initialisation
                {
                    PimStateChanged(this, this.state);
                }
            }
        }
       

        private void deconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            State = PimState.Deconnecter;
        
        }

        private void attenteBagageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            State = PimState.AttenteBagage;
        }
    

       
        private void Deconnecter(){
            //this.GB_RECHERCHE.Visible = false;
            //this.GB_RESULTAT.Visible = false;
            
        }
        private void AfficherBagage()
        {
            this.GB_RECHERCHE.Visible = true;
            this.GB_RECHERCHE.Enabled = true;
            this.GB_RESULTAT.Visible = true;
            this.GB_RESULTAT.Enabled = false;
            this.GB_VOL.Visible = true;
            this.GB_VOL.Enabled = false;
            this.GB_BAGAGE.Visible = true;
            this.GB_BAGAGE.Enabled = false;


            if (bags.Length == 1)
            {
                this.button1.Visible = true;

                this.textboxCompanie.Text = bags[0].CodeIata;
                this.textBoxJour.Text = bags[0].DateVol.ToLongDateString();
                this.textboxLigne.Text= bags[0].Ligne;
            }
        }

        private void AttenteBagage(){

            this.GB_RECHERCHE.Visible = true;
            this.GB_RECHERCHE.Enabled = true;
            this.GB_RESULTAT.Visible = true;
            this.GB_RESULTAT.Enabled = true;
            this.GB_VOL.Visible = true;
            this.GB_VOL.Enabled = false;
            this.GB_BAGAGE.Visible = true;
            this.GB_BAGAGE.Enabled = false;

            this.button1.Visible = true;


            this.comboBox1.Text = " ";
            this.textboxCompanie.Text = " ";
            this.textBoxJour.Text = " ";
            this.textboxLigne.Text = " ";   
       
          }
        private void SelectionBagage()
        {
            this.GB_RECHERCHE.Visible = true;
            this.GB_RECHERCHE.Enabled = true;
            this.GB_RESULTAT.Visible = true;
            this.GB_RESULTAT.Enabled = true;
            this.GB_VOL.Visible = true;
            this.GB_VOL.Enabled = false;
            this.GB_BAGAGE.Visible = true;
            this.GB_BAGAGE.Enabled = false;

            this.comboBox1.Text = " ";
            this.textboxCompanie.Text = " ";
            this.textBoxJour.Text = " ";
            this.textboxLigne.Text = " ";

            if (this.SelectBag == null) this.SelectBag = new BagageSelect();
            SelectBag.ListBagages = bags;
            if (this.SelectBag.ShowDialog() == DialogResult.OK){
                bags = new BagageDefinition[] { SelectBag.Bagage };
                this.State = PimState.AffichageBagage;
            }
            this.SelectBag.Show();
        }
   
          
      
        private void selectionBagageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            State = PimState.SelectionBagage;
        }

        private void creationBagageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void affichageBagageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            State = PimState.AffichageBagage;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
    }
}
