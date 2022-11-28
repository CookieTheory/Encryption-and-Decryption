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
            this.buttonOpenAESKey = new System.Windows.Forms.Button();
            this.textBoxKeyLocation = new System.Windows.Forms.TextBox();
            this.buttonOpenFileDialog = new System.Windows.Forms.Button();
            this.textBoxFileLocation = new System.Windows.Forms.TextBox();
            this.openFileRSA = new System.Windows.Forms.OpenFileDialog();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.richTextBoxFile = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tajni ključ (za dekripciju):";
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
            // buttonOpenAESKey
            // 
            this.buttonOpenAESKey.Location = new System.Drawing.Point(334, 68);
            this.buttonOpenAESKey.Name = "buttonOpenAESKey";
            this.buttonOpenAESKey.Size = new System.Drawing.Size(37, 20);
            this.buttonOpenAESKey.TabIndex = 13;
            this.buttonOpenAESKey.Text = "...";
            this.buttonOpenAESKey.UseVisualStyleBackColor = true;
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
            // formRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.richTextBoxFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOpenAESKey);
            this.Controls.Add(this.textBoxKeyLocation);
            this.Controls.Add(this.buttonOpenFileDialog);
            this.Controls.Add(this.textBoxFileLocation);
            this.Name = "formRSA";
            this.Text = "formRSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOpenAESKey;
        private System.Windows.Forms.TextBox textBoxKeyLocation;
        private System.Windows.Forms.Button buttonOpenFileDialog;
        private System.Windows.Forms.TextBox textBoxFileLocation;
        private System.Windows.Forms.OpenFileDialog openFileRSA;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.RichTextBox richTextBoxFile;
    }
}