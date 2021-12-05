using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Lab05_KolisnichenkoMaksym
{
    public partial class Form1 : Form
    {
        bool rbCRC32, rbHashAlgorithm, rbRIPEMD160, rbMD5, rbSHA_1, rbSHA_256, rbSHA_384, rbSHA_512;
        public Form1()
        {
            InitializeComponent();
            rb_CRC32.Checked = true;
        }

        private void button_fileIN_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Шлях до файлу
                    string fileINpath = openFileDialog.FileName;
                    textBox_fileIN.Text = fileINpath;
                }
            }
        }

        private void button_fileOUT_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Шлях до файлу
                string fileOUTpath = saveFileDialog.FileName;
                textBox_fileOUT.Text = fileOUTpath;
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                byte[] inArr = File.ReadAllBytes(textBox_fileIN.Text); // читаємо байти з файлу
                byte[] arr = myEncoding(inArr); //Закодований масив байт

                FileInfo fileIN = new FileInfo(textBox_fileIN.Text);
                long size = fileIN.Length;
                labelFileINLength.Text = ("Вхідний файл: " + size.ToString() + " байт");

                mySaveToFileOUT(arr, textBox_fileOUT.Text); //збереження у файл

                FileInfo fileOUT = new FileInfo(textBox_fileOUT.Text);
                long size1 = fileOUT.Length;
                labelFileOUTLength.Text = ("Вихідний файл: " + size1.ToString() + " байт");

                Cursor.Current = Cursors.Default;
                MessageBox.Show("У файлі записане число (контрольна сума вхідного файлу):\n" + BitConverter.ToString(arr), Name = "Результат");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Clean_Click(object sender, EventArgs e)
        {
            textBox_fileIN.Text = "";
            textBox_fileOUT.Text = "";
            textBox_fileIN.Focus();
            labelFileINLength.Text = "Вхідний файл:  ???";
            labelFileOUTLength.Text = "Вихідний файл:  ???";
        }

        private byte[] myEncoding(byte[] inArr)
        {
            byte[] result = { 0 };

            if (rb_CRC32.Checked == true)
            {
                uint a = Crc.Crc32(inArr);
                return BitConverter.GetBytes(a);
            }
            if (rb_HashAlgorithm.Checked == true)
            {
                HashAlgorithm sha = KeyedHashAlgorithm.Create();
                return sha.ComputeHash(inArr);
            }
            if (rb_RIPEMD160.Checked == true)
            {
                HashAlgorithm sha = RIPEMD160.Create();
                return sha.ComputeHash(inArr);
            }
            if (rb_MD5.Checked == true)
            {
                HashAlgorithm sha = MD5.Create();
                return sha.ComputeHash(inArr);
            }
            if (rb_SHA_1.Checked == true)
            {
                HashAlgorithm sha = SHA1.Create();
                return sha.ComputeHash(inArr);
            }
            if (rb_SHA_256.Checked == true)
            {
                HashAlgorithm sha = SHA256.Create();
                return sha.ComputeHash(inArr);
            }
            if (rb_SHA_384.Checked == true)
            {
                HashAlgorithm sha = SHA384.Create();
                return sha.ComputeHash(inArr);
            }
            if (rb_SHA_512.Checked == true)
            {
                HashAlgorithm sha = SHA512.Create();
                return sha.ComputeHash(inArr);
            }
            
            return result;
        }

        private void rb_CRC32_CheckedChanged(object sender, EventArgs e)
        {
            rbCRC32 = true;
            rbHashAlgorithm = false;
            rbRIPEMD160 = false;
            rbMD5 = false;
            rbSHA_1 = false;
            rbSHA_256 = false;
            rbSHA_384 = false;
            rbSHA_512 = false;
        }

        private void rb_HashAlgorithm_CheckedChanged(object sender, EventArgs e)
        {
            rbCRC32 = false;
            rbHashAlgorithm = true;
            rbRIPEMD160 = false;
            rbMD5 = false;
            rbSHA_1 = false;
            rbSHA_256 = false;
            rbSHA_384 = false;
            rbSHA_512 = false;
        }

        private void rb_RIPEMD160_CheckedChanged(object sender, EventArgs e)
        {
            rbCRC32 = false;
            rbHashAlgorithm = false;
            rbRIPEMD160 = true;
            rbMD5 = false;
            rbSHA_1 = false;
            rbSHA_256 = false;
            rbSHA_384 = false;
            rbSHA_512 = false;
        }

        private void rb_MD5_CheckedChanged(object sender, EventArgs e)
        {
            rbCRC32 = false;
            rbHashAlgorithm = false;
            rbRIPEMD160 = false;
            rbMD5 = true;
            rbSHA_1 = false;
            rbSHA_256 = false;
            rbSHA_384 = false;
            rbSHA_512 = false;
        }

        private void rb_SHA_1_CheckedChanged(object sender, EventArgs e)
        {
            rbCRC32 = false;
            rbHashAlgorithm = false;
            rbRIPEMD160 = false;
            rbMD5 = false;
            rbSHA_1 = true;
            rbSHA_256 = false;
            rbSHA_384 = false;
            rbSHA_512 = false;
        }

        private void rb_SHA_256_CheckedChanged(object sender, EventArgs e)
        {
            rbCRC32 = false;
            rbHashAlgorithm = false;
            rbRIPEMD160 = false;
            rbMD5 = false;
            rbSHA_1 = false;
            rbSHA_256 = true;
            rbSHA_384 = false;
            rbSHA_512 = false;
        }

        private void rb_SHA_384_CheckedChanged(object sender, EventArgs e)
        {
            rbCRC32 = false;
            rbHashAlgorithm = false;
            rbRIPEMD160 = false;
            rbMD5 = false;
            rbSHA_1 = false;
            rbSHA_256 = false;
            rbSHA_384 = true;
            rbSHA_512 = false;
        }

        private void rb_SHA_512_CheckedChanged(object sender, EventArgs e)
        {
            rbCRC32 = false;
            rbHashAlgorithm = false;
            rbRIPEMD160 = false;
            rbMD5 = false;
            rbSHA_1 = false;
            rbSHA_256 = false;
            rbSHA_384 = false;
            rbSHA_512 = true;
        }

        private void mySaveToFileOUT(byte[] arrCipher, string fileOUTpath)
        {
            //Збереження у файл
            using (FileStream fs = File.Create(fileOUTpath))
            {
                fs.Write(arrCipher, 0, arrCipher.Length);
                fs.Close();
            }
        }

        private void labelAboutAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAboutAuthor formAboutAuthor = new FormAboutAuthor();
            formAboutAuthor.Show();
        }

        private void labelAboutCipher_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAboutCipher formAboutCipher = new FormAboutCipher();
            formAboutCipher.Show();
        }
    }
}
