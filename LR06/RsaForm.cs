using Encrypt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR06
{
    public partial class RsaForm : Form
    {
        private Encrypt.Rsa _rsa;
        public RsaForm()
        {
            InitializeComponent();
            GenerateAll();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateAll();
        }

        private void GenerateAll()
        {
            _rsa = new Encrypt.Rsa();
            try
            {
                _rsa.GenerateAll();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Reset();
                return;
            }

            pLabel.Text = "p=" + _rsa.P;
            qLabel.Text = "q=" + _rsa.Q;
            fnLabel.Text = "Ф(n)=" + _rsa.Fn;
            eLabel.Text = "e=" + _rsa.E;
            kLabel.Text = "k=" + _rsa.K;
            // Secret key
            nLabel.Text = "n=" + _rsa.N;
            dLabel.Text = "d=" + _rsa.D;
            // Open key
            nTextBox.Text = _rsa.N.ToString();
            eTextBox.Text = _rsa.E.ToString();
            nTextBox2.Text = _rsa.N.ToString();
            eTextBox2.Text = _rsa.E.ToString();
        }

        private void Reset()
        {
            pLabel.Text = "p";
            qLabel.Text = "q";
            fnLabel.Text = "Ф(n)";
            eLabel.Text = "e";
            kLabel.Text = "k";
            // Secret key
            nLabel.Text = "n";
            dLabel.Text = "d";
            // Open key
            nTextBox.Text = "";
            eTextBox.Text = "";
            nTextBox2.Text = "";
            eTextBox2.Text = "";
            

        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            Encrypt.Rsa rsa = new Encrypt.Rsa();
            rsa.N = Convert.ToInt32(nTextBox.Text);
            rsa.E = Convert.ToInt32(eTextBox.Text);
            string message = sourceRichTextBox1.Text;
            string encrytedMessage = rsa.Encrypt(message);
            encryptedRichTextBox.Text = encrytedMessage;
            encryptedRichTextBox2.Text = encrytedMessage;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            string encrytedMessage = encryptedRichTextBox2.Text;
            string message = _rsa.Decrypt(encrytedMessage);
            decryptedRichTextBox.Text = message;
        }
        
    }
}
