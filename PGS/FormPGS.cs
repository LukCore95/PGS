using System;
using System.Windows.Forms;

namespace PGS
{
    public partial class FormPGS : Form
    {
        Data d = new Data();

        public FormPGS()
        {
            InitializeComponent();
            panelName.Show();
            panelSurname.Hide();
            panelAddress.Hide();
            panelPhoneNumber.Hide();
            panelOptions.Hide();
            panelShowData.Hide();
        }

        private void buttonName_Click(object sender, EventArgs e)
        {
            d.setData(0, textBoxName.Text);
            panelName.Hide();
            panelSurname.Show();
        }

        private void buttonSurname_Click(object sender, EventArgs e)
        {
            d.setData(1, textBoxSurname.Text);
            panelSurname.Hide();
            panelAddress.Show();
        }

        private void buttonAddress_Click(object sender, EventArgs e)
        {
            d.setData(2, textBoxAddress.Text);
            panelAddress.Hide();
            panelPhoneNumber.Show();
        }

        private void buttonPhoneNumber_Click(object sender, EventArgs e)
        {
            d.setData(3, textBoxPhoneNumber.Text);
            panelPhoneNumber.Hide();
            panelOptions.Show();
        }

        private void buttonCorrectData_Click(object sender, EventArgs e)
        {
            panelOptions.Hide();
            if (radioButtonName.Checked)
            {
                panelName.Show();
                
            }
            if (radioButtonSurname.Checked)
            {
                panelSurname.Show();
            }
            if (radioButtonAddress.Checked)
            {
                panelAddress.Show();
            }
            if (radioButtonPhoneNumber.Checked)
            {
                panelPhoneNumber.Show();
            }
        }

        private void buttonShowData_Click(object sender, EventArgs e)
        {
            panelOptions.Hide();
            panelShowData.Show();
            textBoxShowName.Text = d.getData(0);
            textBoxShowSurname.Text = d.getData(1);
            textBoxShowAddress.Text = d.getData(2);
            textBoxShowPhoneNumber.Text = d.getData(3);
        }
    }
}
