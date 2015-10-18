using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Visible = true;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void txtToEncrypt_TextChanged(object sender, EventArgs e)
        {
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int total = 20;

            for (int i = 0; i <= total; i++)
            {
                System.Threading.Thread.Sleep(100);
                int percents = (i * 100) / total;
                backgroundWorker1.ReportProgress(percents, i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            this.Text = e.ProgressPercentage.ToString();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (chkboxAutoEncrypt.Checked)
                txtEncrypted.Text = encryptString(txtToEncrypt.Text);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi!","Test");
        }

    }
}
