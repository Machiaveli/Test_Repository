namespace test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOne = new System.Windows.Forms.Label();
            this.lblTwo = new System.Windows.Forms.Label();
            this.txtToEncrypt = new System.Windows.Forms.TextBox();
            this.txtEncrypted = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.chkboxAutoEncrypt = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Location = new System.Drawing.Point(46, 24);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(68, 13);
            this.lblOne.TabIndex = 0;
            this.lblOne.Text = "Unencrypted";
            // 
            // lblTwo
            // 
            this.lblTwo.AutoSize = true;
            this.lblTwo.Location = new System.Drawing.Point(46, 125);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(55, 13);
            this.lblTwo.TabIndex = 1;
            this.lblTwo.Text = "Encrypted";
            // 
            // txtToEncrypt
            // 
            this.txtToEncrypt.Location = new System.Drawing.Point(49, 40);
            this.txtToEncrypt.Multiline = true;
            this.txtToEncrypt.Name = "txtToEncrypt";
            this.txtToEncrypt.Size = new System.Drawing.Size(363, 66);
            this.txtToEncrypt.TabIndex = 2;
            this.txtToEncrypt.TextChanged += new System.EventHandler(this.txtToEncrypt_TextChanged);
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.Location = new System.Drawing.Point(49, 141);
            this.txtEncrypted.Multiline = true;
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.Size = new System.Drawing.Size(363, 71);
            this.txtEncrypted.TabIndex = 3;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(49, 227);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // chkboxAutoEncrypt
            // 
            this.chkboxAutoEncrypt.AutoSize = true;
            this.chkboxAutoEncrypt.Location = new System.Drawing.Point(325, 20);
            this.chkboxAutoEncrypt.Name = "chkboxAutoEncrypt";
            this.chkboxAutoEncrypt.Size = new System.Drawing.Size(87, 17);
            this.chkboxAutoEncrypt.TabIndex = 5;
            this.chkboxAutoEncrypt.Text = "Auto Encrypt";
            this.chkboxAutoEncrypt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 282);
            this.Controls.Add(this.chkboxAutoEncrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtEncrypted);
            this.Controls.Add(this.txtToEncrypt);
            this.Controls.Add(this.lblTwo);
            this.Controls.Add(this.lblOne);
            this.Name = "Form1";
            this.Text = "Encryption Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Label lblTwo;
        private System.Windows.Forms.TextBox txtToEncrypt;
        private System.Windows.Forms.TextBox txtEncrypted;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.CheckBox chkboxAutoEncrypt;
    }
}

