using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption_and_Decryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAES_Click(object sender, EventArgs e)
        {
            this.Hide();
            formAES newForm = new formAES();
            newForm.ShowDialog();
            this.Show();
        }

        private void buttonRSA_Click(object sender, EventArgs e)
        {
            this.Hide();
            formRSA newForm = new formRSA();
            newForm.ShowDialog();
            this.Show();
        }
    }
}
