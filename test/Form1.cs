using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txtEncrypted.Text = encryptString(txtToEncrypt.Text);
        }

        private void txtToEncrypt_TextChanged(object sender, EventArgs e)
        {
            if(chkboxAutoEncrypt.Checked)
                txtEncrypted.Text = encryptString(txtToEncrypt.Text);

        }


        public string encryptString(string message)
        {
            string encrypted = null;
            byte[] asciiValues = Encoding.ASCII.GetBytes(message);



            int[] v = new int[asciiValues.Length];
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = Convert.ToInt32(asciiValues[i]) + 7;
            }

            for (int i = 0; i < asciiValues.Length; i++)
            {
                encrypted += Convert.ToChar(v[i]);
            }

            return encrypted;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkboxAutoEncrypt.Checked = true;
        }

        private void rbtnEncrypt_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
