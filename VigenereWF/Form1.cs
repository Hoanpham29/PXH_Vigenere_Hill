﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace VigenereWF
{
    public partial class PXH_Vigenere_Hill : Form
    {
        public PXH_Vigenere_Hill()
        {
            InitializeComponent();
        }
        public static char[] Ascii = new char[]
        {
            'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v',
            'w','x','y','z','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R',
            'S','T','U','V','W','X','Y','Z',' ','~','`','!','@','#','$','%','^','&','*','(',')','-',
            '_','+','=','|','\\','\'','\n','\t','{','[',']','}',':',';','\'','<',',','.','>','?','/',
            '0','1','2','3','4','5','6','7','8','9'
        };


        // Thuật toán Vigenere
        private void Encrypted_Click(object sender, EventArgs e)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            string plainText = PlainText.Text; 
            string key = Key1.Text;
            string encryptedText = string.Empty;
            int keyLength = key.Length;
            if (Key1.Text == ""||PlainText.Text=="")
                MessageBox.Show("Nhập thiếu bản rõ hoặc khóa K!!");
            else
            {
                Key2.Clear();
                EncryptedText.Clear();
                Boolean check=true;
                for (int i = 0; i < key.Length; i++)
                {
                    if (Ascii.Contains(key[i]) == false)
                    {
                        MessageBox.Show("Khóa của bạn không hợp lệ!");
                        check=false;
                    }
                }
                if (check)
                {
                    for (int i = 0; i < plainText.Length; i++)
                    {
                        char plainChar = plainText[i];
                        if (Ascii.Contains(plainChar))
                        {
                            char keyChar = key[i % keyLength];
                            int indexPlain = Array.IndexOf(Ascii, plainChar);
                            int indexKey = Array.IndexOf(Ascii, keyChar);
                            char encryptedChar = Ascii[(indexPlain + indexKey) % Ascii.Length];
                            encryptedText += encryptedChar;
                        }
                        else
                        {
                            encryptedText += plainChar;
                        }
                    }
                    EncryptedText.Text = encryptedText;
                    Key2.Text = Key1.Text;
                }
            }
        }

        private void PlainTextDelBtn_Click(object sender, EventArgs e)
        {
            PlainText.Clear();
        }

        private void EncryptedTextDelBtn_Click(object sender, EventArgs e)
        {
            EncryptedText.Clear();
        }

        private void Decrypted_Click(object sender, EventArgs e)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            string encryptedText = EncryptedText.Text;
            string key = Key2.Text;
            string decryptedText = string.Empty;
            int keyLength = key.Length;
            if (Key2.Text == "" || EncryptedText.Text == "")
                MessageBox.Show("Nhập thiếu bản mã hoặc khóa K!!");
            else
            {
                Key1.Clear();
                PlainText.Clear();
                Boolean check = true;
                for (int i = 0; i < key.Length; i++)
                {
                    if (Ascii.Contains(key[i]) == false)
                    {
                        MessageBox.Show("Khóa của bạn không hợp lệ!");
                        check = false;
                    }
                }
                if (check)
                {
                    for (int i = 0; i < encryptedText.Length; i++)
                    {
                        char encryptedChar = encryptedText[i];
                        if (Ascii.Contains(encryptedChar))
                        {
                            char keyChar = key[i % keyLength];
                            int indexEncrypted = Array.IndexOf(Ascii, encryptedChar);
                            int indexKey = Array.IndexOf(Ascii, keyChar);
                            int decryptedIndex = (indexEncrypted - indexKey + Ascii.Length) % Ascii.Length;
                            char decryptedChar = Ascii[decryptedIndex];
                            decryptedText += decryptedChar;
                        }
                        else
                        {
                            decryptedText += encryptedChar;
                        }
                    }
                    PlainText.Text = decryptedText;
                    Key1.Text = Key2.Text;
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            PlainText.Clear();
            Key1.Clear();
            EncryptedText.Clear();
            Key2.Clear();
        }

        private void RandomKey_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int length;
            string pT = PlainText.Text;
            int RL = random.Next(pT.Length);
            string RK = new string(Enumerable.Repeat(Ascii, RL).Select(s => s[random.Next(s.Length)]).ToArray());
            Key1.Text = RK.ToString();
        }


        // Thuật toán Hill

        private static readonly char[] vietnameseChars = new char[]
        {
            'à','á','ạ','ả','ã','â','ầ','ấ','ậ','ẩ','ẫ','ă','ằ','ắ','ặ','ẳ','ẵ',
            'è','é','ẹ','ẻ','ẽ','ê','ề','ế','ệ','ể','ễ',
            'ì','í','ị','ỉ','ĩ',
            'ò','ó','ọ','ỏ','õ','ô','ồ','ố','ộ','ổ','ỗ','ơ','ờ','ớ','ợ','ở','ỡ',
            'ù','ú','ụ','ủ','ũ','ư','ừ','ứ','ự','ử','ữ',
            'ỳ','ý','ỵ','ỷ','ỹ',
            'đ',
            'À','Á','Ạ','Ả','Ã','Â','Ầ','Ấ','Ậ','Ẩ','Ẫ','Ă','Ằ','Ắ','Ặ','Ẳ','Ẵ',
            'È','É','Ẹ','Ẻ','Ẽ','Ê','Ề','Ế','Ệ','Ể','Ễ',
            'Ì','Í','Ị','Ỉ','Ĩ',
            'Ò','Ó','Ọ','Ỏ','Õ','Ô','Ồ','Ố','Ộ','Ổ','Ỗ','Ơ','Ờ','Ớ','Ợ','Ở','Ỡ',
            'Ù','Ú','Ụ','Ủ','Ũ','Ư','Ừ','Ứ','Ự','Ử','Ữ',
            'Ỳ','Ý','Ỵ','Ỷ','Ỹ',
            'Đ'
        };
        private static readonly int charSetSize = Ascii.Length;

        private static bool IsVietnameseChar(char c)
        {
            return Array.IndexOf(vietnameseChars, c) >= 0;
        }
        private static int Mod(int a, int b)
        {
            return (a % b + b) % b;
        }
        private static int ModInverse(int a, int m)
        {
            a = a % m;
            for (int x = 1; x < m; x++)
            {
                if ((a * x) % m == 1)
                    return x;
            }
            return -1;
        }

        // Chuyển ký tự thành chỉ số
        private static int CharToIndex(char c)
        {
            return Array.IndexOf(Ascii, c);
        }

        // Chuyển chỉ số thành ký tự
        private static char IndexToChar(int index)
        {
            return Ascii[Mod(index, charSetSize)];
        }

        private static bool IsInvertible(int[,] matrix)
        {
            int det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            return ModInverse(det, charSetSize) != -1;
        }

        public static string Encrypt(string plaintext, int[,] key)
        {
            int n = key.GetLength(0);
            StringBuilder ciphertext = new StringBuilder();

            for (int i = 0; i < plaintext.Length; i += n)
            { 
                int[] vector = new int[n];
                for (int j = 0; j < n; j++)
                {
                    if (i + j < plaintext.Length)
                    {
                        vector[j] = CharToIndex(plaintext[i + j]);
                    }
                    else
                    {
                        vector[j] = CharToIndex(' '); // Sử dụng ký tự khoảng trắng nếu thiếu ký tự
                    }
                }

                for (int row = 0; row < n; row++)
                {
                    int sum = 0;
                    for (int col = 0; col < n; col++)
                    {
                        sum += key[row, col] * vector[col];
                    }
                    ciphertext.Append(IndexToChar(sum));
                }
                
            }

            return ciphertext.ToString();
        }

        private static int[,] InverseMatrix(int[,] matrix)
        {
            int det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            int invDet = ModInverse(det, charSetSize);

            if (invDet == -1)
            {
                MessageBox.Show("Ma trận không có nghịch đảo");
            }

            return new int[,] {
                { Mod(matrix[1, 1] * invDet, charSetSize), Mod(-matrix[0, 1] * invDet, charSetSize) },
                { Mod(-matrix[1, 0] * invDet, charSetSize), Mod(matrix[0, 0] * invDet, charSetSize) }
            };
        }

        private void HillEncrypted_Click(object sender, EventArgs e)
        {
            string plaintText = HillPlainTxt.Text;
            string CE1 = textBox00.Text; string CE2 = textBox01.Text; string CE3 = textBox10.Text; string CE4 = textBox11.Text;
            if (CE1 == "" || CE2 == "" || CE3 == "" || CE4 == "" || plaintText == "")
                MessageBox.Show("Nhập thiếu bản rõ hoặc khóa K!!");
            else
            {
                int[,] key = {
                { int.Parse(textBox00.Text), int.Parse(textBox01.Text) },
                { int.Parse(textBox10.Text), int.Parse(textBox11.Text) }
                };

                if (!IsInvertible(key))
                {
                    MessageBox.Show("Ma trận không có nghịch đảo");
                }
                else
                {
                    string plaintext = HillPlainTxt.Text;
                    string encrypted = Encrypt(plaintext, key);
                    HillEncryptedTxt.Text = encrypted;
                }
            }
        }

        // Giải mã
        public static string Decrypt(string ciphertext, int[,] key)
        {
            int n = key.GetLength(0);

            StringBuilder plaintext = new StringBuilder();
            int[,] inverseKey = InverseMatrix(key);

            for (int i = 0; i < ciphertext.Length; i += n)
            {
                int[] vector = new int[n];
                for (int j = 0; j < n; j++)
                {
                    if (i + j < ciphertext.Length)
                    {
                        if (IsVietnameseChar(ciphertext[i + j]))
                        {
                            plaintext.Append(ciphertext[i + j]);
                        }
                        else
                        {
                            vector[j] = CharToIndex(ciphertext[i + j]);
                        }
                    }
                    else
                    {
                        vector[j] = CharToIndex(' ');
                    }
                }

                for (int row = 0; row < n; row++)
                {
                    int sum = 0;
                    for (int col = 0; col < n; col++)
                    {
                        sum += inverseKey[row, col] * vector[col];
                    }
                    plaintext.Append(IndexToChar(sum));
                }
            }

            return plaintext.ToString();
        }
        private void HillDecrypted_Click(object sender, EventArgs e)
        {
            string encryptedText = HillEncryptedTxt.Text;
            string CE1 = textBox00.Text; string CE2 = textBox01.Text; string CE3 = textBox10.Text; string CE4 = textBox11.Text;
            if (CE1 == "" || CE2 == "" || CE3 == "" || CE4 == "" || encryptedText == "")
                MessageBox.Show("Nhập thiếu bản mã hoặc khóa K!!");
            else
            {
                int[,] key = {
                { int.Parse(textBox00.Text), int.Parse(textBox01.Text) },
                { int.Parse(textBox10.Text), int.Parse(textBox11.Text) }
                };

                if (!IsInvertible(key))
                {
                    MessageBox.Show("Ma trận không có nghịch đảo");
                }
                else
                {
                    string ciphertext = HillEncryptedTxt.Text;
                    string decrypted = Decrypt(ciphertext, key);
                    HillPlainTxt.Text = decrypted;
                }
            }
        }

        private void HillRandomKey_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int[,] key;
            do
            {
                key = new int[2, 2];
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        key[i, j] = rand.Next(0, charSetSize);
                    }
                }
                textBox00.Text = key[0, 0].ToString();
                textBox01.Text = key[0, 1].ToString();
                textBox10.Text = key[1, 0].ToString();
                textBox11.Text = key[1, 1].ToString();

            } while (!IsInvertible(key));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox00.Clear();
            textBox01.Clear();
            textBox10.Clear();
            textBox11.Clear();
        }

        private void HillDelete_Click(object sender, EventArgs e)
        {
            HillPlainTxt.Clear();
            HillEncryptedTxt.Clear();
        }

        private void textBox00_Leave(object sender, EventArgs e)
        {
            string temp = textBox00.Text;
            if (temp != "")
            {
                int check = int.Parse(textBox00.Text);
                if (check < 0)
                {
                    MessageBox.Show("Giá trị không hợp lệ!!");
                    textBox00.Clear();
                }
            }
        }

        private void textBox01_Leave(object sender, EventArgs e)
        {
            string temp = textBox01.Text;
            if (temp != "")
            {
                int check = int.Parse(textBox01.Text);
                if (check < 0)
                {
                    MessageBox.Show("Giá trị không hợp lệ!!");
                    textBox01.Clear();
                }
            }
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            string temp = textBox10.Text;
            if (temp != "")
            {
                int check = int.Parse(textBox10.Text);
                if (check < 0)
                {
                    MessageBox.Show("Giá trị không hợp lệ!!");
                    textBox10.Clear();
                }
            }
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            string temp = textBox11.Text;
            if (temp != "")
            {
                int check = int.Parse(textBox11.Text);
                if (check < 0)
                {
                    MessageBox.Show("Giá trị không hợp lệ!!");
                    textBox11.Clear();
                }
            }
        }

        private void PlainDel_Click(object sender, EventArgs e)
        {
            HillPlainTxt.Clear();
        }

        private void EncryptedDel_Click(object sender, EventArgs e)
        {
            HillEncryptedTxt.Clear();
        }
    }
}
