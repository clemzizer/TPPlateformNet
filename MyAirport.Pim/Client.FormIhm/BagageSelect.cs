using Client.FormIhm.ServiceBagageReferencePim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAiport.Pim.Client
{
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
    }
}
