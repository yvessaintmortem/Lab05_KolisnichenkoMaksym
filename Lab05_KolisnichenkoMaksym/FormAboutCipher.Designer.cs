
namespace Lab05_KolisnichenkoMaksym
{
    partial class FormAboutCipher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutCipher));
            this.labelEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel_AES = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Rijndael = new System.Windows.Forms.LinkLabel();
            this.linkLabel_DES = new System.Windows.Forms.LinkLabel();
            this.linkLabel_TriplDES = new System.Windows.Forms.LinkLabel();
            this.linkLabel_RC2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(223, 40);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(241, 19);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "алгоритми шифрування, вбудовані";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(223, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Програма використовує симетричні";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(223, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "в .NET Framework";
            // 
            // linkLabel_AES
            // 
            this.linkLabel_AES.AutoSize = true;
            this.linkLabel_AES.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_AES.Location = new System.Drawing.Point(237, 100);
            this.linkLabel_AES.Name = "linkLabel_AES";
            this.linkLabel_AES.Size = new System.Drawing.Size(38, 19);
            this.linkLabel_AES.TabIndex = 8;
            this.linkLabel_AES.TabStop = true;
            this.linkLabel_AES.Text = "AES";
            this.linkLabel_AES.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_AES_LinkClicked);
            // 
            // linkLabel_Rijndael
            // 
            this.linkLabel_Rijndael.AutoSize = true;
            this.linkLabel_Rijndael.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_Rijndael.Location = new System.Drawing.Point(237, 135);
            this.linkLabel_Rijndael.Name = "linkLabel_Rijndael";
            this.linkLabel_Rijndael.Size = new System.Drawing.Size(58, 19);
            this.linkLabel_Rijndael.TabIndex = 9;
            this.linkLabel_Rijndael.TabStop = true;
            this.linkLabel_Rijndael.Text = "Rijndael";
            this.linkLabel_Rijndael.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Rijndael_LinkClicked);
            // 
            // linkLabel_DES
            // 
            this.linkLabel_DES.AutoSize = true;
            this.linkLabel_DES.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_DES.Location = new System.Drawing.Point(380, 100);
            this.linkLabel_DES.Name = "linkLabel_DES";
            this.linkLabel_DES.Size = new System.Drawing.Size(38, 19);
            this.linkLabel_DES.TabIndex = 10;
            this.linkLabel_DES.TabStop = true;
            this.linkLabel_DES.Text = "DES";
            this.linkLabel_DES.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_DES_LinkClicked);
            // 
            // linkLabel_TriplDES
            // 
            this.linkLabel_TriplDES.AutoSize = true;
            this.linkLabel_TriplDES.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_TriplDES.Location = new System.Drawing.Point(380, 135);
            this.linkLabel_TriplDES.Name = "linkLabel_TriplDES";
            this.linkLabel_TriplDES.Size = new System.Drawing.Size(65, 19);
            this.linkLabel_TriplDES.TabIndex = 11;
            this.linkLabel_TriplDES.TabStop = true;
            this.linkLabel_TriplDES.Text = "TriplDES";
            this.linkLabel_TriplDES.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_TriplDES_LinkClicked);
            // 
            // linkLabel_RC2
            // 
            this.linkLabel_RC2.AutoSize = true;
            this.linkLabel_RC2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_RC2.Location = new System.Drawing.Point(237, 166);
            this.linkLabel_RC2.Name = "linkLabel_RC2";
            this.linkLabel_RC2.Size = new System.Drawing.Size(38, 19);
            this.linkLabel_RC2.TabIndex = 12;
            this.linkLabel_RC2.TabStop = true;
            this.linkLabel_RC2.Text = "RC2";
            this.linkLabel_RC2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_RC2_LinkClicked);
            // 
            // FormAboutCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 200);
            this.Controls.Add(this.linkLabel_RC2);
            this.Controls.Add(this.linkLabel_TriplDES);
            this.Controls.Add(this.linkLabel_DES);
            this.Controls.Add(this.linkLabel_Rijndael);
            this.Controls.Add(this.linkLabel_AES);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAboutCipher";
            this.Text = "About Cipher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel_AES;
        private System.Windows.Forms.LinkLabel linkLabel_Rijndael;
        private System.Windows.Forms.LinkLabel linkLabel_DES;
        private System.Windows.Forms.LinkLabel linkLabel_TriplDES;
        private System.Windows.Forms.LinkLabel linkLabel_RC2;
    }
}