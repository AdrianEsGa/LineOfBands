using System;
using System.Windows.Forms;

namespace LineOfBands.App.Forms
{
    public partial class FrmPartReference : Form
    {
        public string Reference;
        public FrmPartReference()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reference = "safsafdsffsfdsfds";
            Close();
        }
    }
}
