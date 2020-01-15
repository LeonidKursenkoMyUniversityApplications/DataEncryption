using Rsa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vigers.Controller;

namespace LR06DH
{
    public partial class FormDH : Form
    {
        private DiffieHellman _decryptDH;
        private DiffieHellman _encryptDH;
        private VigController _vigController;

        private int _kEncrypt;
        private int _kDecrypt;

        public FormDH()
        {
            InitializeComponent();
            string alphabet = "абвгґдеєжзиіїйклмнопрстуфхцчшщьюя" +
                              "ёэыъ" +
                              "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ" +
                              "ЁЭЫЪ" +
                              "abcdefghijklmnopqrstuvwxyz" +
                              "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                              "0123456789" +
                              "+-*/&^%$#@!()[]{}?><=,.\"\'№₴%;:\n\r ";

            _vigController = new VigController(alphabet.ToList());
        }

        private void GenerateBButton_Click(object sender, EventArgs e)
        {
            _encryptDH = new DiffieHellman();
            try
            {
                _encryptDH.P = Convert.ToInt32(pTextBox2.Text);
                _encryptDH.G = Convert.ToInt32(gTextBox2.Text);
                _encryptDH.APublic = Convert.ToInt32(textBoxA2.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Недопустимі значення відкритих числових ключів");
                return;
            }
            _encryptDH.GenerateBb();
            // View b,B in the encrypt side
            bLabel.Text = "b=" + _encryptDH.BSecret.ToString();
            textBoxB2.Text = _encryptDH.BPublic.ToString();
            SendB(_encryptDH.BPublic);
        }

        private void GeneratePgAButton_Click(object sender, EventArgs e)
        {
            _decryptDH = new DiffieHellman();
            _decryptDH.GeneratePGaA();
            // View p,g,a,A in the decrypt side
            pTextBox.Text = _decryptDH.P.ToString();
            gTextBox.Text = _decryptDH.G.ToString();
            textBoxA.Text = _decryptDH.APublic.ToString();
            aLabel.Text = "a=" + _decryptDH.ASecret.ToString();
            SendPGA(_decryptDH.P, _decryptDH.G, _decryptDH.APublic);

        }

        private void SendPGA(int p, int g, int a)
        {
            // View p,g,A in the encrypt side
            pTextBox2.Text = p.ToString();
            gTextBox2.Text = g.ToString();
            textBoxA2.Text = a.ToString();
        }

        private void SendB(int b)
        {
            // View B in the decrypt side
            textBoxB.Text = b.ToString();
        }

        private void GetKbutton_Click(object sender, EventArgs e)
        {
            try
            {
                _decryptDH.BPublic = Convert.ToInt32(textBoxB.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Недопустимі значення відкритих числових ключів");
                return;
            }
            _kDecrypt = _decryptDH.GetSecretKeyDecrypt();
            LabelK.Text = "K=" + _kDecrypt;
        }

        private void GetK2Button_Click(object sender, EventArgs e)
        {
            try
            {
                _encryptDH.APublic = Convert.ToInt32(textBoxA2.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Недопустимі значення відкритих числових ключів");
                return;
            }
            _kEncrypt = _encryptDH.GetSecretKeyEncrypt();
            LabelK2.Text = "K=" + _kEncrypt;
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                string encryptMessage = _vigController.Encrypt(sourceRichTextBox1.Text, _kEncrypt.ToString());
                encryptedRichTextBox.Text = encryptMessage;
                encryptedRichTextBox2.Text = encryptMessage;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                string decryptedMessage = _vigController.Decrypt(encryptedRichTextBox2.Text, _kDecrypt.ToString());
                decryptedRichTextBox.Text = decryptedMessage;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
