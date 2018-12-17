using Client.FormIhm.ServiceBagageReferencePim;
using System;
using System.Windows.Forms;

namespace MyAiport.Pim.Client
{
    /// <summary>
    /// This class manages bagage selection
    /// </summary>
    public partial class BagageSelect : Form
    {
        
        public BagageDefinition[] ListBagages
        {
            set
            {
                this.listBox1.Items.Clear();
                this.listBox1.Items.AddRange(value);
            }
                                                  
        }

        public BagageDefinition Bagage { get; private set; }

        public BagageSelect()
          {
            InitializeComponent();
        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bagage = (BagageDefinition)listBox1.SelectedItem;
        }




        private void ButtonOk_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
