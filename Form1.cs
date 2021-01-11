using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptDecrpytText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string mainText = txtMainText.Text;
            byte[] byteArray = ASCIIEncoding.ASCII.GetBytes(mainText);
            string encryptedPassword = Convert.ToBase64String(byteArray);
            txtEncrypted.Text = encryptedPassword;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string decryptText = txtEncrypted.Text;
            byte[] byteArrayEncrypted = Convert.FromBase64String(decryptText);
            string mainText2 = ASCIIEncoding.ASCII.GetString(byteArrayEncrypted);
            txtMainText.Text = mainText2;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMainText.Clear();
            txtEncrypted.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                this.Size = new Size(645, 425);
            }
            else
            {
                this.Size = new Size(645, 275);
            }
            
        }
        
        private void pcbEnglish_Click(object sender, EventArgs e)
        {
            // PictureBox for change language (for English)
            
            lblMain.Text = "Main Text";
            lblEncrypted.Text = "Ecrypted Text";
            checkBox1.Text = "Show Note";
            label3.Visible = false;
            label4.Visible = true;
            btnEncrypt.Text = "Encrypt";
            btnDecrypt.Text = "Decrypt";
            btnClear.Text = "Clear";
            this.Text = "Text Encryption";
        }

        private void pcbTurkish_Click(object sender, EventArgs e)
        {
            // PictureBox for change language (for Turkish)
            
            lblMain.Text = "Ana Metin";
            lblEncrypted.Text = "Şifreli Metin";
            checkBox1.Text = "Notu Göster";
            label3.Visible = true;
            label4.Visible = false;
            btnSifrele.Text = "Şifrele";
            button2.Text = "Şifre Çöz";
            button1.Text = "Temizle";
            this.Text = "Metin Şifreleme";
        }
    }
}
