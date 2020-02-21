using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToBase64ileSifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            string anaMetin = txtAna.Text;
            byte[] veriDizisi = ASCIIEncoding.ASCII.GetBytes(anaMetin);
            string sifreliMetin = Convert.ToBase64String(veriDizisi);
            txtSifreli.Text = sifreliMetin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string metinCoz = txtSifreli.Text;
            byte[] veriDizisiCozulen = Convert.FromBase64String(metinCoz);
            string anaMetin2 = ASCIIEncoding.ASCII.GetString(veriDizisiCozulen);
            txtAna.Text = anaMetin2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAna.Clear();
            txtSifreli.Clear();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label1.Text = "Main Text";
            label2.Text = "Ecrypted Text";
            checkBox1.Text = "Show Note";
            label3.Visible = false;
            label4.Visible = true;
            btnSifrele.Text = "Encrypt";
            button2.Text = "Decrypt";
            button1.Text = "Clear";
            this.Text = "Text Encryption";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "Ana Metin";
            label2.Text = "Şifreli Metin";
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
