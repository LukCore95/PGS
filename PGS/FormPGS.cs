using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGS
{
    public partial class FormPGS : Form
    {
        private string[] data;

        public FormPGS()
        {
            InitializeComponent();
            data = new string[4];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data[0] = textBoxName.Text; 
            panelName.Hide();
        }

        private void saveName()
        {
            throw new NotImplementedException();
        }
    }
}
