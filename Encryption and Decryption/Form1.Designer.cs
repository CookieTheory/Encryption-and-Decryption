﻿namespace Encryption_and_Decryption
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
            this.buttonAES = new System.Windows.Forms.Button();
            this.buttonRSA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAES
            // 
            this.buttonAES.Location = new System.Drawing.Point(12, 12);
            this.buttonAES.Name = "buttonAES";
            this.buttonAES.Size = new System.Drawing.Size(202, 40);
            this.buttonAES.TabIndex = 0;
            this.buttonAES.Text = "AES Encryption and Decryption";
            this.buttonAES.UseVisualStyleBackColor = true;
            this.buttonAES.Click += new System.EventHandler(this.buttonAES_Click);
            // 
            // buttonRSA
            // 
            this.buttonRSA.Location = new System.Drawing.Point(12, 58);
            this.buttonRSA.Name = "buttonRSA";
            this.buttonRSA.Size = new System.Drawing.Size(202, 40);
            this.buttonRSA.TabIndex = 1;
            this.buttonRSA.Text = "RSA Encryption and Decryption";
            this.buttonRSA.UseVisualStyleBackColor = true;
            this.buttonRSA.Click += new System.EventHandler(this.buttonRSA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 111);
            this.Controls.Add(this.buttonRSA);
            this.Controls.Add(this.buttonAES);
            this.Name = "Form1";
            this.Text = "AES/RSA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAES;
        private System.Windows.Forms.Button buttonRSA;
    }
}

