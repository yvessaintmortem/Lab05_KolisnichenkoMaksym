
namespace Lab05_KolisnichenkoMaksym
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_fileIN = new System.Windows.Forms.TextBox();
            this.textBox_fileOUT = new System.Windows.Forms.TextBox();
            this.button_fileIN = new System.Windows.Forms.Button();
            this.button_fileOUT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_SHA_512 = new System.Windows.Forms.RadioButton();
            this.rb_SHA_384 = new System.Windows.Forms.RadioButton();
            this.rb_SHA_256 = new System.Windows.Forms.RadioButton();
            this.rb_SHA_1 = new System.Windows.Forms.RadioButton();
            this.rb_MD5 = new System.Windows.Forms.RadioButton();
            this.rb_RIPEMD160 = new System.Windows.Forms.RadioButton();
            this.rb_HashAlgorithm = new System.Windows.Forms.RadioButton();
            this.rb_CRC32 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelFileINLength = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelFileOUTLength = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.button_Clean = new System.Windows.Forms.Button();
            this.labelAboutAuthor = new System.Windows.Forms.LinkLabel();
            this.labelAboutCipher = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вхідний файл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вихідний файл";
            // 
            // textBox_fileIN
            // 
            this.textBox_fileIN.Location = new System.Drawing.Point(132, 16);
            this.textBox_fileIN.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_fileIN.Name = "textBox_fileIN";
            this.textBox_fileIN.Size = new System.Drawing.Size(352, 26);
            this.textBox_fileIN.TabIndex = 2;
            // 
            // textBox_fileOUT
            // 
            this.textBox_fileOUT.Location = new System.Drawing.Point(132, 56);
            this.textBox_fileOUT.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_fileOUT.Name = "textBox_fileOUT";
            this.textBox_fileOUT.Size = new System.Drawing.Size(352, 26);
            this.textBox_fileOUT.TabIndex = 3;
            // 
            // button_fileIN
            // 
            this.button_fileIN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_fileIN.Location = new System.Drawing.Point(491, 16);
            this.button_fileIN.Name = "button_fileIN";
            this.button_fileIN.Size = new System.Drawing.Size(45, 26);
            this.button_fileIN.TabIndex = 4;
            this.button_fileIN.Text = "...";
            this.button_fileIN.UseVisualStyleBackColor = true;
            this.button_fileIN.Click += new System.EventHandler(this.button_fileIN_Click);
            // 
            // button_fileOUT
            // 
            this.button_fileOUT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_fileOUT.Location = new System.Drawing.Point(491, 55);
            this.button_fileOUT.Name = "button_fileOUT";
            this.button_fileOUT.Size = new System.Drawing.Size(45, 26);
            this.button_fileOUT.TabIndex = 5;
            this.button_fileOUT.Text = "...";
            this.button_fileOUT.UseVisualStyleBackColor = true;
            this.button_fileOUT.Click += new System.EventHandler(this.button_fileOUT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_SHA_512);
            this.groupBox1.Controls.Add(this.rb_SHA_384);
            this.groupBox1.Controls.Add(this.rb_SHA_256);
            this.groupBox1.Controls.Add(this.rb_SHA_1);
            this.groupBox1.Controls.Add(this.rb_MD5);
            this.groupBox1.Controls.Add(this.rb_RIPEMD160);
            this.groupBox1.Controls.Add(this.rb_HashAlgorithm);
            this.groupBox1.Controls.Add(this.rb_CRC32);
            this.groupBox1.Location = new System.Drawing.Point(23, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 148);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим роботи";
            // 
            // rb_SHA_512
            // 
            this.rb_SHA_512.AutoSize = true;
            this.rb_SHA_512.Location = new System.Drawing.Point(145, 114);
            this.rb_SHA_512.Name = "rb_SHA_512";
            this.rb_SHA_512.Size = new System.Drawing.Size(88, 23);
            this.rb_SHA_512.TabIndex = 7;
            this.rb_SHA_512.TabStop = true;
            this.rb_SHA_512.Text = "SHA-512";
            this.rb_SHA_512.UseVisualStyleBackColor = true;
            this.rb_SHA_512.CheckedChanged += new System.EventHandler(this.rb_SHA_512_CheckedChanged);
            // 
            // rb_SHA_384
            // 
            this.rb_SHA_384.AutoSize = true;
            this.rb_SHA_384.Location = new System.Drawing.Point(145, 85);
            this.rb_SHA_384.Name = "rb_SHA_384";
            this.rb_SHA_384.Size = new System.Drawing.Size(88, 23);
            this.rb_SHA_384.TabIndex = 6;
            this.rb_SHA_384.TabStop = true;
            this.rb_SHA_384.Text = "SHA-384";
            this.rb_SHA_384.UseVisualStyleBackColor = true;
            this.rb_SHA_384.CheckedChanged += new System.EventHandler(this.rb_SHA_384_CheckedChanged);
            // 
            // rb_SHA_256
            // 
            this.rb_SHA_256.AutoSize = true;
            this.rb_SHA_256.Location = new System.Drawing.Point(145, 55);
            this.rb_SHA_256.Name = "rb_SHA_256";
            this.rb_SHA_256.Size = new System.Drawing.Size(88, 23);
            this.rb_SHA_256.TabIndex = 5;
            this.rb_SHA_256.TabStop = true;
            this.rb_SHA_256.Text = "SHA-256";
            this.rb_SHA_256.UseVisualStyleBackColor = true;
            this.rb_SHA_256.CheckedChanged += new System.EventHandler(this.rb_SHA_256_CheckedChanged);
            // 
            // rb_SHA_1
            // 
            this.rb_SHA_1.AutoSize = true;
            this.rb_SHA_1.Location = new System.Drawing.Point(145, 25);
            this.rb_SHA_1.Name = "rb_SHA_1";
            this.rb_SHA_1.Size = new System.Drawing.Size(72, 23);
            this.rb_SHA_1.TabIndex = 4;
            this.rb_SHA_1.TabStop = true;
            this.rb_SHA_1.Text = "SHA-1";
            this.rb_SHA_1.UseVisualStyleBackColor = true;
            this.rb_SHA_1.CheckedChanged += new System.EventHandler(this.rb_SHA_1_CheckedChanged);
            // 
            // rb_MD5
            // 
            this.rb_MD5.AutoSize = true;
            this.rb_MD5.Location = new System.Drawing.Point(7, 115);
            this.rb_MD5.Name = "rb_MD5";
            this.rb_MD5.Size = new System.Drawing.Size(60, 23);
            this.rb_MD5.TabIndex = 3;
            this.rb_MD5.TabStop = true;
            this.rb_MD5.Text = "MD5";
            this.rb_MD5.UseVisualStyleBackColor = true;
            this.rb_MD5.CheckedChanged += new System.EventHandler(this.rb_MD5_CheckedChanged);
            // 
            // rb_RIPEMD160
            // 
            this.rb_RIPEMD160.AutoSize = true;
            this.rb_RIPEMD160.Location = new System.Drawing.Point(7, 86);
            this.rb_RIPEMD160.Name = "rb_RIPEMD160";
            this.rb_RIPEMD160.Size = new System.Drawing.Size(109, 23);
            this.rb_RIPEMD160.TabIndex = 2;
            this.rb_RIPEMD160.TabStop = true;
            this.rb_RIPEMD160.Text = "RIPEMD160";
            this.rb_RIPEMD160.UseVisualStyleBackColor = true;
            this.rb_RIPEMD160.CheckedChanged += new System.EventHandler(this.rb_RIPEMD160_CheckedChanged);
            // 
            // rb_HashAlgorithm
            // 
            this.rb_HashAlgorithm.AutoSize = true;
            this.rb_HashAlgorithm.Location = new System.Drawing.Point(7, 56);
            this.rb_HashAlgorithm.Name = "rb_HashAlgorithm";
            this.rb_HashAlgorithm.Size = new System.Drawing.Size(117, 23);
            this.rb_HashAlgorithm.TabIndex = 1;
            this.rb_HashAlgorithm.TabStop = true;
            this.rb_HashAlgorithm.Text = "HashAlgorithm";
            this.rb_HashAlgorithm.UseVisualStyleBackColor = true;
            this.rb_HashAlgorithm.CheckedChanged += new System.EventHandler(this.rb_HashAlgorithm_CheckedChanged);
            // 
            // rb_CRC32
            // 
            this.rb_CRC32.AutoSize = true;
            this.rb_CRC32.Location = new System.Drawing.Point(7, 26);
            this.rb_CRC32.Name = "rb_CRC32";
            this.rb_CRC32.Size = new System.Drawing.Size(75, 23);
            this.rb_CRC32.TabIndex = 0;
            this.rb_CRC32.TabStop = true;
            this.rb_CRC32.Text = "CRC32";
            this.rb_CRC32.UseVisualStyleBackColor = true;
            this.rb_CRC32.CheckedChanged += new System.EventHandler(this.rb_CRC32_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelFileINLength);
            this.groupBox2.Location = new System.Drawing.Point(284, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 49);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Оцінка розміру (Мбайт)";
            // 
            // labelFileINLength
            // 
            this.labelFileINLength.AutoSize = true;
            this.labelFileINLength.Location = new System.Drawing.Point(14, 24);
            this.labelFileINLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFileINLength.Name = "labelFileINLength";
            this.labelFileINLength.Size = new System.Drawing.Size(133, 19);
            this.labelFileINLength.TabIndex = 2;
            this.labelFileINLength.Text = "Вхідний файл:  ???";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelFileOUTLength);
            this.groupBox3.Location = new System.Drawing.Point(284, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 49);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Оцінка розміру (Мбайт)";
            // 
            // labelFileOUTLength
            // 
            this.labelFileOUTLength.AutoSize = true;
            this.labelFileOUTLength.Location = new System.Drawing.Point(16, 25);
            this.labelFileOUTLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFileOUTLength.Name = "labelFileOUTLength";
            this.labelFileOUTLength.Size = new System.Drawing.Size(142, 19);
            this.labelFileOUTLength.TabIndex = 2;
            this.labelFileOUTLength.Text = "Вихідний файл:  ???";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(284, 212);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(120, 74);
            this.button_start.TabIndex = 11;
            this.button_start.Text = "Виконати";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_Clean
            // 
            this.button_Clean.Location = new System.Drawing.Point(416, 212);
            this.button_Clean.Name = "button_Clean";
            this.button_Clean.Size = new System.Drawing.Size(120, 74);
            this.button_Clean.TabIndex = 12;
            this.button_Clean.Text = "Очистити";
            this.button_Clean.UseVisualStyleBackColor = true;
            this.button_Clean.Click += new System.EventHandler(this.button_Clean_Click);
            // 
            // labelAboutAuthor
            // 
            this.labelAboutAuthor.AutoSize = true;
            this.labelAboutAuthor.Location = new System.Drawing.Point(39, 259);
            this.labelAboutAuthor.Name = "labelAboutAuthor";
            this.labelAboutAuthor.Size = new System.Drawing.Size(51, 19);
            this.labelAboutAuthor.TabIndex = 15;
            this.labelAboutAuthor.TabStop = true;
            this.labelAboutAuthor.Text = "Автор";
            this.labelAboutAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelAboutAuthor_LinkClicked);
            // 
            // labelAboutCipher
            // 
            this.labelAboutCipher.AutoSize = true;
            this.labelAboutCipher.Location = new System.Drawing.Point(164, 259);
            this.labelAboutCipher.Name = "labelAboutCipher";
            this.labelAboutCipher.Size = new System.Drawing.Size(46, 19);
            this.labelAboutCipher.TabIndex = 16;
            this.labelAboutCipher.TabStop = true;
            this.labelAboutCipher.Text = "Опис";
            this.labelAboutCipher.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelAboutCipher_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 305);
            this.Controls.Add(this.labelAboutCipher);
            this.Controls.Add(this.labelAboutAuthor);
            this.Controls.Add(this.button_Clean);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_fileOUT);
            this.Controls.Add(this.button_fileIN);
            this.Controls.Add(this.textBox_fileOUT);
            this.Controls.Add(this.textBox_fileIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Циклічний надлишковий код (CRC)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_fileIN;
        private System.Windows.Forms.TextBox textBox_fileOUT;
        private System.Windows.Forms.Button button_fileIN;
        private System.Windows.Forms.Button button_fileOUT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_SHA_512;
        private System.Windows.Forms.RadioButton rb_SHA_384;
        private System.Windows.Forms.RadioButton rb_SHA_256;
        private System.Windows.Forms.RadioButton rb_SHA_1;
        private System.Windows.Forms.RadioButton rb_MD5;
        private System.Windows.Forms.RadioButton rb_RIPEMD160;
        private System.Windows.Forms.RadioButton rb_HashAlgorithm;
        private System.Windows.Forms.RadioButton rb_CRC32;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelFileINLength;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelFileOUTLength;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_Clean;
        private System.Windows.Forms.LinkLabel labelAboutAuthor;
        private System.Windows.Forms.LinkLabel labelAboutCipher;
    }
}

