using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MyAirport.Pim.ServiceHost


{
    public partial class Form1 : Form 
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private System.ServiceModel.ServiceHost host = null;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void host_State(object sender, EventArgs e)
        {
            this.textBox1.Text = this.host.State.ToString();
        }


   

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (this.host != null)
                if (this.host.State == CommunicationState.Opened)
                {
                    this.host.Close();
                    this.button2.Text = "Ouvrir";
                }
                else
                {
                    this.host.Open();
                    this.listBox1.Items.Clear();
                    foreach (var item in host.Description.Behaviors)
                    {
                        if (item is System.ServiceModel.ServiceBehaviorAttribute)
                        {
                            this.listBox1.Items.Add(((System.ServiceModel.ServiceBehaviorAttribute)item).InstanceContextMode.ToString());
                        }
                    }
                    foreach (var item in host.Description.Endpoints)
                    {
                        this.listBox1.Items.Add(item.Name);
                    }
                    this.button2.Text = "Fermer";
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            host = new System.ServiceModel.ServiceHost(typeof(MyAirport.Pim.Service.ServicePim));

            host.Closed += host_State;
            host.Closing += host_State;
            host.Faulted += host_State;
            host.Opened += host_State;
            host.Opening += host_State;
        }
    }
}
