namespace Encryption_and_Decryption
{
    partial class formRSA
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpenRSAKey = new System.Windows.Forms.Button();
            this.textBoxKeyLocation = new System.Windows.Forms.TextBox();
            this.buttonOpenFileDialog = new System.Windows.Forms.Button();
            this.textBoxFileLocation = new System.Windows.Forms.TextBox();
            this.openFileRSA = new System.Windows.Forms.OpenFileDialog();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.richTextBoxFile = new System.Windows.Forms.RichTextBox();
            this.openRSAKey = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxHash = new System.Windows.Forms.GroupBox();
            this.richTextBoxHash = new System.Windows.Forms.RichTextBox();
            this.buttonHash = new System.Windows.Forms.Button();
            this.buttonSign = new System.Windows.Forms.Button();
            this.richTextBoxSignResult = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOpenSignature = new System.Windows.Forms.Button();
            this.textBoxSignedLocation = new System.Windows.Forms.TextBox();
            this.buttonCheckSignature = new System.Windows.Forms.Button();
            this.richTextBoxSign = new System.Windows.Forms.RichTextBox();
            this.textBoxCheckResult = new System.Windows.Forms.TextBox();
            this.openFileSigned = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxHash.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Javni ili tajni ključ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Datoteka:";
            // 
            // buttonOpenRSAKey
            // 
            this.buttonOpenRSAKey.Location = new System.Drawing.Point(334, 68);
            this.buttonOpenRSAKey.Name = "buttonOpenRSAKey";
            this.buttonOpenRSAKey.Size = new System.Drawing.Size(37, 20);
            this.buttonOpenRSAKey.TabIndex = 13;
            this.buttonOpenRSAKey.Text = "...";
            this.buttonOpenRSAKey.UseVisualStyleBackColor = true;
            this.buttonOpenRSAKey.Click += new System.EventHandler(this.buttonOpenRSAKey_Click);
            // 
            // textBoxKeyLocation
            // 
            this.textBoxKeyLocation.Location = new System.Drawing.Point(15, 68);
            this.textBoxKeyLocation.Name = "textBoxKeyLocation";
            this.textBoxKeyLocation.Size = new System.Drawing.Size(313, 20);
            this.textBoxKeyLocation.TabIndex = 12;
            // 
            // buttonOpenFileDialog
            // 
            this.buttonOpenFileDialog.Location = new System.Drawing.Point(334, 25);
            this.buttonOpenFileDialog.Name = "buttonOpenFileDialog";
            this.buttonOpenFileDialog.Size = new System.Drawing.Size(37, 20);
            this.buttonOpenFileDialog.TabIndex = 11;
            this.buttonOpenFileDialog.Text = "...";
            this.buttonOpenFileDialog.UseVisualStyleBackColor = true;
            this.buttonOpenFileDialog.Click += new System.EventHandler(this.buttonOpenFileDialog_Click);
            // 
            // textBoxFileLocation
            // 
            this.textBoxFileLocation.Location = new System.Drawing.Point(15, 25);
            this.textBoxFileLocation.Name = "textBoxFileLocation";
            this.textBoxFileLocation.Size = new System.Drawing.Size(313, 20);
            this.textBoxFileLocation.TabIndex = 10;
            // 
            // openFileRSA
            // 
            this.openFileRSA.FileName = "openFileRSA";
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(15, 235);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(356, 95);
            this.richTextBoxResult.TabIndex = 19;
            this.richTextBoxResult.Text = "";
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(194, 195);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(177, 34);
            this.buttonDecrypt.TabIndex = 18;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(15, 195);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(177, 34);
            this.buttonEncrypt.TabIndex = 17;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // richTextBoxFile
            // 
            this.richTextBoxFile.Location = new System.Drawing.Point(15, 94);
            this.richTextBoxFile.Name = "richTextBoxFile";
            this.richTextBoxFile.Size = new System.Drawing.Size(356, 95);
            this.richTextBoxFile.TabIndex = 16;
            this.richTextBoxFile.Text = "";
            // 
            // openRSAKey
            // 
            this.openRSAKey.FileName = "openFileDialog1";
            // 
            // groupBoxHash
            // 
            this.groupBoxHash.Controls.Add(this.textBoxCheckResult);
            this.groupBoxHash.Controls.Add(this.richTextBoxSign);
            this.groupBoxHash.Controls.Add(this.buttonCheckSignature);
            this.groupBoxHash.Controls.Add(this.label3);
            this.groupBoxHash.Controls.Add(this.buttonOpenSignature);
            this.groupBoxHash.Controls.Add(this.textBoxSignedLocation);
            this.groupBoxHash.Controls.Add(this.richTextBoxSignResult);
            this.groupBoxHash.Controls.Add(this.buttonSign);
            this.groupBoxHash.Controls.Add(this.buttonHash);
            this.groupBoxHash.Controls.Add(this.richTextBoxHash);
            this.groupBoxHash.Location = new System.Drawing.Point(378, 13);
            this.groupBoxHash.Name = "groupBoxHash";
            this.groupBoxHash.Size = new System.Drawing.Size(368, 317);
            this.groupBoxHash.TabIndex = 20;
            this.groupBoxHash.TabStop = false;
            this.groupBoxHash.Text = "Hash i digitalni potpis";
            // 
            // richTextBoxHash
            // 
            this.richTextBoxHash.Location = new System.Drawing.Point(6, 45);
            this.richTextBoxHash.Name = "richTextBoxHash";
            this.richTextBoxHash.Size = new System.Drawing.Size(356, 45);
            this.richTextBoxHash.TabIndex = 17;
            this.richTextBoxHash.Text = "";
            // 
            // buttonHash
            // 
            this.buttonHash.Location = new System.Drawing.Point(6, 19);
            this.buttonHash.Name = "buttonHash";
            this.buttonHash.Size = new System.Drawing.Size(356, 20);
            this.buttonHash.TabIndex = 18;
            this.buttonHash.Text = "Hash";
            this.buttonHash.UseVisualStyleBackColor = true;
            this.buttonHash.Click += new System.EventHandler(this.buttonHash_Click);
            // 
            // buttonSign
            // 
            this.buttonSign.Location = new System.Drawing.Point(6, 96);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(356, 20);
            this.buttonSign.TabIndex = 19;
            this.buttonSign.Text = "Potpiši";
            this.buttonSign.UseVisualStyleBackColor = true;
            // 
            // richTextBoxSignResult
            // 
            this.richTextBoxSignResult.Location = new System.Drawing.Point(6, 212);
            this.richTextBoxSignResult.Name = "richTextBoxSignResult";
            this.richTextBoxSignResult.Size = new System.Drawing.Size(356, 45);
            this.richTextBoxSignResult.TabIndex = 20;
            this.richTextBoxSignResult.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Digitalni potpis:";
            // 
            // buttonOpenSignature
            // 
            this.buttonOpenSignature.Location = new System.Drawing.Point(325, 186);
            this.buttonOpenSignature.Name = "buttonOpenSignature";
            this.buttonOpenSignature.Size = new System.Drawing.Size(37, 20);
            this.buttonOpenSignature.TabIndex = 22;
            this.buttonOpenSignature.Text = "...";
            this.buttonOpenSignature.UseVisualStyleBackColor = true;
            // 
            // textBoxSignedLocation
            // 
            this.textBoxSignedLocation.Location = new System.Drawing.Point(6, 186);
            this.textBoxSignedLocation.Name = "textBoxSignedLocation";
            this.textBoxSignedLocation.Size = new System.Drawing.Size(313, 20);
            this.textBoxSignedLocation.TabIndex = 21;
            // 
            // buttonCheckSignature
            // 
            this.buttonCheckSignature.Location = new System.Drawing.Point(6, 263);
            this.buttonCheckSignature.Name = "buttonCheckSignature";
            this.buttonCheckSignature.Size = new System.Drawing.Size(356, 20);
            this.buttonCheckSignature.TabIndex = 24;
            this.buttonCheckSignature.Text = "Provjeri potpis";
            this.buttonCheckSignature.UseVisualStyleBackColor = true;
            // 
            // richTextBoxSign
            // 
            this.richTextBoxSign.Location = new System.Drawing.Point(6, 122);
            this.richTextBoxSign.Name = "richTextBoxSign";
            this.richTextBoxSign.Size = new System.Drawing.Size(356, 45);
            this.richTextBoxSign.TabIndex = 25;
            this.richTextBoxSign.Text = "";
            // 
            // textBoxCheckResult
            // 
            this.textBoxCheckResult.Location = new System.Drawing.Point(6, 289);
            this.textBoxCheckResult.Name = "textBoxCheckResult";
            this.textBoxCheckResult.ReadOnly = true;
            this.textBoxCheckResult.Size = new System.Drawing.Size(356, 20);
            this.textBoxCheckResult.TabIndex = 26;
            // 
            // openFileSigned
            // 
            this.openFileSigned.FileName = "openFileDialog1";
            // 
            // formRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 345);
            this.Controls.Add(this.groupBoxHash);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.richTextBoxFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOpenRSAKey);
            this.Controls.Add(this.textBoxKeyLocation);
            this.Controls.Add(this.buttonOpenFileDialog);
            this.Controls.Add(this.textBoxFileLocation);
            this.Name = "formRSA";
            this.Text = "formRSA";
            this.groupBoxHash.ResumeLayout(false);
            this.groupBoxHash.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOpenRSAKey;
        private System.Windows.Forms.TextBox textBoxKeyLocation;
        private System.Windows.Forms.Button buttonOpenFileDialog;
        private System.Windows.Forms.TextBox textBoxFileLocation;
        private System.Windows.Forms.OpenFileDialog openFileRSA;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.RichTextBox richTextBoxFile;
        private System.Windows.Forms.OpenFileDialog openRSAKey;
        private System.Windows.Forms.GroupBox groupBoxHash;
        private System.Windows.Forms.TextBox textBoxCheckResult;
        private System.Windows.Forms.RichTextBox richTextBoxSign;
        private System.Windows.Forms.Button buttonCheckSignature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOpenSignature;
        private System.Windows.Forms.TextBox textBoxSignedLocation;
        private System.Windows.Forms.RichTextBox richTextBoxSignResult;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.Button buttonHash;
        private System.Windows.Forms.RichTextBox richTextBoxHash;
        private System.Windows.Forms.OpenFileDialog openFileSigned;
    }
}