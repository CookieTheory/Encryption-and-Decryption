using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption_and_Decryption
{
    public partial class formRSA : Form
    {
        private string fileLocation = "";
        private string fileText = "";
        string decryptFilepath = "";
        private RSAParameters helperRSA = new RSAParameters();
        byte[] decryptData = null;
        byte[] data;
        public formRSA()
        {
            InitializeComponent();
        }

        private void buttonOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileRSA.Filter = "Text File|*.txt|Word Doc|*.doc";
            openFileRSA.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileRSA.Title = "Open file for RSA encryption";
            openFileRSA.ShowDialog();

            textBoxFileLocation.Text = openFileRSA.FileName;
            fileLocation = openFileRSA.FileName;

            try
            {
                using (var sr = new StreamReader(fileLocation, Encoding.UTF8))
                {
                    fileText = sr.ReadToEnd(); if (fileText.Contains("�"))
                    {
                        data = LoadEncryptedFile(data, fileLocation);
                        fileText = Convert.ToBase64String(data);
                    }
                    richTextBoxFile.Text = fileText;
                }
            }
            catch
            {
                openFileRSA.FileName = "";
                textBoxFileLocation.Text = openFileRSA.FileName;
                fileLocation = openFileRSA.FileName;
            }
        }

        private void buttonOpenRSAKey_Click(object sender, EventArgs e)
        {
            openRSAKey.Filter = "Text File|*.txt";
            openRSAKey.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openRSAKey.Title = "Open key for RSA encryption/decryption";
            openRSAKey.ShowDialog();

            if (openRSAKey.FileName == "openFileDialog1") openRSAKey.FileName = "";
            textBoxKeyLocation.Text = openRSAKey.FileName;
            decryptFilepath = openRSAKey.FileName;
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                //Create a UnicodeEncoder to convert between byte array and string.
                UnicodeEncoding ByteConverter = new UnicodeEncoding();

                //Create byte arrays to hold original, encrypted, and decrypted data.
                byte[] dataToEncrypt = ByteConverter.GetBytes(fileText);
                //byte[] decryptedData;

                //Create a new instance of RSACryptoServiceProvider to generate
                //public and private key data.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {

                    //Pass the data to ENCRYPT, the public key information 
                    //(using RSACryptoServiceProvider.ExportParameters(false),
                    //and a boolean flag specifying no OAEP padding.
                    if (decryptFilepath == "")
                    {
                        helperRSA = RSA.ExportParameters(true);
                        SavePrivateAndPublicKey(helperRSA);
                    }
                    else helperRSA = LoadPublicKey(decryptFilepath);
                    byte[] encryptedData = RSAEncrypt(dataToEncrypt, helperRSA, false);
                    if(encryptedData != null)
                    {
                        SaveEncryptedFile(encryptedData);
                        richTextBoxResult.Text = Convert.ToBase64String(encryptedData);
                    }

                    //Pass the data to DECRYPT, the private key information 
                    //(using RSACryptoServiceProvider.ExportParameters(true),
                    //and a boolean flag specifying no OAEP padding.
                    /*decryptedData = RSADecrypt(encryptedData, helperRSA, false);

                    //Display the decrypted plaintext to the console. 
                    Console.WriteLine("Encrypted plaintext: {0}", ByteConverter.GetString(encryptedData));
                    Console.WriteLine("Private key: {0}", ByteConverter.GetString(helperRSA.D));
                    Console.WriteLine("Public key Mod: {0}", ByteConverter.GetString(helperRSA.Modulus));
                    Console.WriteLine("Decrypted plaintext: {0}", ByteConverter.GetString(decryptedData));*/
                }
            }
            catch
            {
                MessageBox.Show("RSA Service not working / 091");
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                //Create a UnicodeEncoder to convert between byte array and string.
                UnicodeEncoding ByteConverter = new UnicodeEncoding();

                //Create byte arrays to hold decrypted data.
                byte[] decryptedData;

                //Create a new instance of RSACryptoServiceProvider to generate
                //public and private key data.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    helperRSA = LoadPrivateKey(decryptFilepath);
                    decryptData = LoadEncryptedFile(decryptData, fileLocation);
                    byte[] encryptedData = decryptData;

                    //Pass the data to DECRYPT, the private key information 
                    //(using RSACryptoServiceProvider.ExportParameters(true),
                    //and a boolean flag specifying no OAEP padding.
                    decryptedData = RSADecrypt(encryptedData, helperRSA, false);
                    /*
                    //Display the decrypted plaintext to the console. 
                    Console.WriteLine("Encrypted plaintext: {0}", ByteConverter.GetString(encryptedData));
                    Console.WriteLine("Private key: {0}", ByteConverter.GetString(helperRSA.D));
                    Console.WriteLine("Public key Mod: {0}", ByteConverter.GetString(helperRSA.Modulus));
                    Console.WriteLine("Decrypted plaintext: {0}", ByteConverter.GetString(decryptedData));*/
                }
                richTextBoxResult.Text = ByteConverter.GetString(decryptedData);
            }
            catch
            {
                MessageBox.Show("RSA Service not working / 132");
            }
        }

        private static byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {

                    //Import the RSA Key information. This only needs
                    //toinclude the public key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Encrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
                }
                return encryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }
        }

        private static byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    //Import the RSA Key information. This needs
                    //to include the private key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Decrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
                }
                return decryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());

                return null;
            }
        }

        private static void SaveEncryptedFile(byte[] encryptedFile)
        {
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/OS2 Projekt";
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            using (FileStream fileStream = new FileStream(directory + "/rsa_enkriptirano.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                {
                    try
                    {
                        binaryWriter.Write(encryptedFile.Length);
                        binaryWriter.Write(encryptedFile);
                    }
                    catch
                    {

                    }
                }
            }
        }

        private static void SavePrivateAndPublicKey(RSAParameters RSAParams)
        {
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/OS2 Projekt";
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            using (FileStream fileStream = new FileStream(directory + "/privatni_kljuc.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                {
                    binaryWriter.Write(RSAParams.D.Length);
                    binaryWriter.Write(RSAParams.D);
                    binaryWriter.Write(RSAParams.DP.Length);
                    binaryWriter.Write(RSAParams.DP);
                    binaryWriter.Write(RSAParams.DQ.Length);
                    binaryWriter.Write(RSAParams.DQ);
                    binaryWriter.Write(RSAParams.Modulus.Length);
                    binaryWriter.Write(RSAParams.Modulus);
                    binaryWriter.Write(RSAParams.P.Length);
                    binaryWriter.Write(RSAParams.P);
                    binaryWriter.Write(RSAParams.Q.Length);
                    binaryWriter.Write(RSAParams.Q);
                    binaryWriter.Write(RSAParams.InverseQ.Length);
                    binaryWriter.Write(RSAParams.InverseQ);
                    binaryWriter.Write(RSAParams.Exponent.Length);
                    binaryWriter.Write(RSAParams.Exponent);
                }
            }

            using (FileStream fileStream = new FileStream(directory + "/javni_kljuc.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                {
                    binaryWriter.Write(RSAParams.Exponent.Length);
                    binaryWriter.Write(RSAParams.Exponent);
                    binaryWriter.Write(RSAParams.Modulus.Length);
                    binaryWriter.Write(RSAParams.Modulus);
                }
            }
        }

        private static RSAParameters LoadPublicKey(string filepath)
        {
            RSAParameters hRSA = new RSAParameters();
            using (FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    try
                    {
                        hRSA.Exponent = binaryReader.ReadBytes(binaryReader.ReadInt32());
                        hRSA.Modulus = binaryReader.ReadBytes(binaryReader.ReadInt32());
                    }
                    catch
                    {
                        MessageBox.Show("Odabrana datoteka nije javni ključ");
                    }
                }
            }
            return hRSA;
        }

        private static RSAParameters LoadPrivateKey(string filepath)
        {
            RSAParameters hRSA = new RSAParameters();
            using (FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    try
                    {
                        hRSA.D = binaryReader.ReadBytes(binaryReader.ReadInt32());
                        hRSA.DP = binaryReader.ReadBytes(binaryReader.ReadInt32());
                        hRSA.DQ = binaryReader.ReadBytes(binaryReader.ReadInt32());
                        hRSA.Modulus = binaryReader.ReadBytes(binaryReader.ReadInt32());
                        hRSA.P = binaryReader.ReadBytes(binaryReader.ReadInt32());
                        hRSA.Q = binaryReader.ReadBytes(binaryReader.ReadInt32());
                        hRSA.InverseQ = binaryReader.ReadBytes(binaryReader.ReadInt32());
                        hRSA.Exponent = binaryReader.ReadBytes(binaryReader.ReadInt32());
                    }
                    catch
                    {
                        MessageBox.Show("Odabrana datoteka nije privatni ključ");
                    }
                }
            }
            return hRSA;
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
