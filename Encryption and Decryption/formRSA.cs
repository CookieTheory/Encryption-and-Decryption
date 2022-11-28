using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption_and_Decryption
{
    public partial class formRSA : Form
    {
        private string fileLocation = "";
        private string fileText = "";
        public formRSA()
        {
            InitializeComponent();
        }

        private void buttonOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileRSA.Filter = "Text File|*.txt|Word Doc|*.doc";
            openFileRSA.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileRSA.Title = "Open file for AES encryption";
            openFileRSA.ShowDialog();

            textBoxFileLocation.Text = openFileRSA.FileName;
            fileLocation = openFileRSA.FileName;

            using (var sr = new StreamReader(fileLocation, Encoding.UTF8))
            {
                fileText = sr.ReadToEnd();
                richTextBoxFile.Text = fileText;
            }
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {

        }
    }
}
