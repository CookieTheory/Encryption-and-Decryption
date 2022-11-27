namespace Encryption_and_Decryption
{
    partial class formAES
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
            this.richTextBoxFile = new System.Windows.Forms.RichTextBox();
            this.textBoxFileLocation = new System.Windows.Forms.TextBox();
            this.buttonOpenFileDialog = new System.Windows.Forms.Button();
            this.openFileAES = new System.Windows.Forms.OpenFileDialog();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.textBoxKeyLocation = new System.Windows.Forms.TextBox();
            this.buttonOpenAESKey = new System.Windows.Forms.Button();
            this.openAESKey = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxFile
            // 
            this.richTextBoxFile.Location = new System.Drawing.Point(15, 94);
            this.richTextBoxFile.Name = "richTextBoxFile";
            this.richTextBoxFile.Size = new System.Drawing.Size(356, 95);
            this.richTextBoxFile.TabIndex = 0;
            this.richTextBoxFile.Text = "";
            // 
            // textBoxFileLocation
            // 
            this.textBoxFileLocation.Location = new System.Drawing.Point(15, 25);
            this.textBoxFileLocation.Name = "textBoxFileLocation";
            this.textBoxFileLocation.Size = new System.Drawing.Size(313, 20);
            this.textBoxFileLocation.TabIndex = 1;
            // 
            // buttonOpenFileDialog
            // 
            this.buttonOpenFileDialog.Location = new System.Drawing.Point(334, 25);
            this.buttonOpenFileDialog.Name = "buttonOpenFileDialog";
            this.buttonOpenFileDialog.Size = new System.Drawing.Size(37, 20);
            this.buttonOpenFileDialog.TabIndex = 2;
            this.buttonOpenFileDialog.Text = "...";
            this.buttonOpenFileDialog.UseVisualStyleBackColor = true;
            this.buttonOpenFileDialog.Click += new System.EventHandler(this.buttonOpenFileDialog_Click);
            // 
            // openFileAES
            // 
            this.openFileAES.FileName = "openFileAES";
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(15, 195);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(177, 34);
            this.buttonEncrypt.TabIndex = 3;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(194, 195);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(177, 34);
            this.buttonDecrypt.TabIndex = 4;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(15, 235);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(356, 95);
            this.richTextBoxResult.TabIndex = 5;
            this.richTextBoxResult.Text = "";
            // 
            // textBoxKeyLocation
            // 
            this.textBoxKeyLocation.Location = new System.Drawing.Point(15, 68);
            this.textBoxKeyLocation.Name = "textBoxKeyLocation";
            this.textBoxKeyLocation.Size = new System.Drawing.Size(313, 20);
            this.textBoxKeyLocation.TabIndex = 6;
            // 
            // buttonOpenAESKey
            // 
            this.buttonOpenAESKey.Location = new System.Drawing.Point(334, 68);
            this.buttonOpenAESKey.Name = "buttonOpenAESKey";
            this.buttonOpenAESKey.Size = new System.Drawing.Size(37, 20);
            this.buttonOpenAESKey.TabIndex = 7;
            this.buttonOpenAESKey.Text = "...";
            this.buttonOpenAESKey.UseVisualStyleBackColor = true;
            this.buttonOpenAESKey.Click += new System.EventHandler(this.buttonOpenAESKey_Click);
            // 
            // openAESKey
            // 
            this.openAESKey.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Datoteka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tajni ključ (za dekripciju):";
            // 
            // formAES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 337);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOpenAESKey);
            this.Controls.Add(this.textBoxKeyLocation);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.buttonOpenFileDialog);
            this.Controls.Add(this.textBoxFileLocation);
            this.Controls.Add(this.richTextBoxFile);
            this.Name = "formAES";
            this.Text = "formAES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxFile;
        private System.Windows.Forms.TextBox textBoxFileLocation;
        private System.Windows.Forms.Button buttonOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileAES;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.TextBox textBoxKeyLocation;
        private System.Windows.Forms.Button buttonOpenAESKey;
        private System.Windows.Forms.OpenFileDialog openAESKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}