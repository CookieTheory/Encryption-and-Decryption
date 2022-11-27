﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Encryption_and_Decryption
{
    public partial class formAES : Form
    {
        string fileLocation = "";
        string fileText = "";
        AesCryptoServiceProvider decryptAes = new AesCryptoServiceProvider();
        byte[] data;
        public formAES()
        {
            InitializeComponent();
        }

        private void buttonOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileAES.Filter = "Text File|*.txt|Word Doc|*.doc";
            openFileAES.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileAES.Title = "Open file for AES encryption";
            openFileAES.ShowDialog();

            textBoxFileLocation.Text = openFileAES.FileName;
            fileLocation = openFileAES.FileName;


            using (var sr = new StreamReader(fileLocation, Encoding.UTF8))
            {
                fileText = sr.ReadToEnd();
                if (fileText.Contains("�"))
                {
                    data = LoadEncryptedFile(data, fileLocation);
                    fileText = Convert.ToBase64String(data);
                }
                richTextBoxFile.Text = fileText;
            }/*
            StreamReader sr = new StreamReader(fileLocation);
            fileText = sr.ReadToEnd();
            richTextBoxFile.Text = fileText;
            sr.Close();*/
        }

        private void buttonOpenAESKey_Click(object sender, EventArgs e)
        {
            openAESKey.Filter = "Text File|*.txt";
            openAESKey.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openAESKey.Title = "Open key for AES decryption";
            openAESKey.ShowDialog();

            textBoxKeyLocation.Text = openAESKey.FileName;
            string decryptFilepath = openAESKey.FileName;
            LoadIVAndKey(decryptAes, decryptFilepath);
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            using (Aes myAes = Aes.Create())
            {
                byte[] encrypted = EncryptStringToBytes_Aes(fileText, myAes.Key, myAes.IV);
                SaveIVAndKey(myAes);
                SaveEncryptedFile(encrypted);

                richTextBoxResult.Text = Convert.ToBase64String(encrypted);
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            data = LoadEncryptedFile(data, fileLocation);
            string decrypt = DecryptStringFromBytes_Aes(data, decryptAes.Key, decryptAes.IV);

            richTextBoxResult.Text = decrypt;
        }

        byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.dsad
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }

        private static void SaveIVAndKey(Aes myaes)
        {
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/OS2 Projekt";
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            using (FileStream fileStream = new FileStream(directory+"/tajni_kljuc.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                {
                    binaryWriter.Write(myaes.IV.Length);
                    binaryWriter.Write(myaes.IV);
                    binaryWriter.Write(myaes.Key.Length);
                    binaryWriter.Write(myaes.Key);
                }
            }
        }

        private static void SaveEncryptedFile(byte[] encryptedFile)
        {
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/OS2 Projekt";
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            using (FileStream fileStream = new FileStream(directory + "/aes_enkriptirano.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                {
                    binaryWriter.Write(encryptedFile.Length);
                    binaryWriter.Write(encryptedFile);
                }
            }
        }

        private static void LoadIVAndKey(AesCryptoServiceProvider decryptAes, string filepath)
        {
            using (FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    decryptAes.IV = binaryReader.ReadBytes(binaryReader.ReadInt32());
                    decryptAes.Key = binaryReader.ReadBytes(binaryReader.ReadInt32());
                }
            }
        }

        private static byte[] LoadEncryptedFile(byte[] text, string filepath)
        {
            using (FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    text = binaryReader.ReadBytes(binaryReader.ReadInt32());
                    return text;
                }
            }
        }
    }
}
