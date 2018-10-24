using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamCryptosystems
{
    public partial class Main : Form
    {
        private OpenFileDialog openFile;
        private SaveFileDialog saveFile;
        private const int COUNT_BIT = 8;
        private static int[] POLYNOMIAL_FIRST = { 24, 2 };
        private static int[] POLYNOMIAL_SECOND = { 32, 12};
        private static int[] POLYNOMIAL_THIRD = { 22, 4 };
        private const int OUTUP_ELEM = 25;
        private const int COUNT_SYMBOLS_S_BOX = 256;
        private string fileName;
        private byte[] plainBytes;
        private byte[] cipherBytes;
        //private string key, plainData, cipherData;
        private string key;
        private string errorEmptyFile = "The file is empty and does not contain any text for encryption / decryption.", errorCaption = "Error!",
            errorFormat = "The input string was not in the correct format.";


        public Main()
        {
            InitializeComponent();
            openFile = InitializeOpenFile();
            saveFile = InitializeSaveFile();
        }

        static string ByteToStringBin(byte data)
        {
            string result = Convert.ToString(data,2);
            int j = COUNT_BIT - result.Length;
            for (int k = 0; k < j; k++)
                result = '0' + result;

            return result;
        }

        static byte BinStringToByte(string value)
        {
            return Convert.ToByte(value, 2);
        }

        private void plaintext_TextChanged(object sender, EventArgs e)
        {
            lfsrButton.Enabled = ((keyTextBox.Text != "") && (plaintext.Text != "") && (keyTextBox.Text.Length == keyTextBox.MaxLength));
            geffeButton.Enabled = ((firstKey.Text != "") && (secondKey.Text != "") && (thirdKey.Text != "") && (plaintext.Text != "") &&
                                   (firstKey.Text.Length == firstKey.MaxLength) && (secondKey.Text.Length == secondKey.MaxLength) && (thirdKey.Text.Length == thirdKey.MaxLength));
            RC4button.Enabled = ((RC4KeyBox.Text != "") && (plaintext.Text != ""));
        }

        private byte[] TranslitToBinaryCode(string text)
        {
            string cipherString = text;
            string subString;
            byte[] result = new byte[cipherString.Length / COUNT_BIT];
            for (int i = 0; i < cipherString.Length / COUNT_BIT; i++)
            {
                subString = cipherString.Substring(i * COUNT_BIT, COUNT_BIT);
                result[i] = BinStringToByte(subString);
            }

            return result;
        }

        private void keyTextBox_TextChanged(object sender, EventArgs e)
        {
            keyTextBox.MaxLength = POLYNOMIAL_FIRST[0] + 1;
            lfsrButton.Enabled = ((keyTextBox.Text != "") && (plaintext.Text != "") && (keyTextBox.Text.Length == keyTextBox.MaxLength));
        }

        private void keyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            if (!(symbol == '1' || symbol == '0' || Convert.ToInt32(symbol) == Convert.ToInt32(Keys.Back)))
                e.Handled = true;
        }

        static string[] FindKey(string key, int[] polynomial)
        {
            int numberOfAddedKeys = 0;
            char[] keyChars = key.ToCharArray();
            string result = "";
            char tempChar;
            
            while (numberOfAddedKeys < COUNT_BIT)
            {
                result += keyChars[0];
                tempChar = keyChars[keyChars.Length - polynomial[0] - 1];
                for (int j = 1; j < polynomial.Length; j++)
                    tempChar = char.Parse((int.Parse(tempChar.ToString()) ^ int.Parse(keyChars[keyChars.Length - polynomial[j] - 1].ToString())).ToString());

                for (int i = 0; i < keyChars.Length - 1; i++)
                    keyChars[i] = keyChars[i + 1];
                keyChars[keyChars.Length - 1] = tempChar;
                
                numberOfAddedKeys++;
            }

            string[] resArray = {new string(keyChars),result};
            return resArray;
        }

        private char[] FindThreeKey()
        {
            string lfsr1 = firstKey.Text,
                lfsr2 = secondKey.Text,
                lfsr3 = thirdKey.Text;
            for (int j = 0; j < plainBytes.Length; j++)
            {

            }
            //lfsr1 = FindKey(lfsr1, plainData, POLYNOMIAL_FIRST);
            //lfsr1 = ChooseKey(lfsr1, plainData);
            //lfsr2 = FindKey(lfsr2, plainData, POLYNOMIAL_SECOND);
            //lfsr2 = ChooseKey(lfsr2, plainData);
            //lfsr3 = FindKey(lfsr3, plainData, POLYNOMIAL_THIRD);
            //lfsr3 = ChooseKey(lfsr3, plainData);

            int countOutputElement = (lfsr1.Length > OUTUP_ELEM) ? OUTUP_ELEM : lfsr1.Length;
            for (int i = 0; i < countOutputElement; i++)
            {
                readyFirstKey.Text += lfsr1[i];
                readySecondKey.Text += lfsr2[i];
                readyThirdKey.Text += lfsr3[i];
            }

            char[] result = lfsr1.ToCharArray();
            for (int i = 0; i < lfsr1.Length; i++)
            {
                result[i] = char.Parse(((int.Parse((result[i]).ToString()) & int.Parse((lfsr1[i]).ToString())) | (~int.Parse((result[i]).ToString()) & int.Parse((lfsr3[i]).ToString()))).ToString());
            }

            countOutputElement = (result.Length > OUTUP_ELEM) ? OUTUP_ELEM : result.Length;
            for (int i = 0; i < countOutputElement; i++)
            {
                resultKey.Text += result[i];
            }

            return result;
        }

        public string RFSRCipher(string newKey, string text)
        {
            char[] result = new char[text.Length];
            char[] sourceText = text.ToCharArray();
            char[] key = newKey.ToCharArray();
            try
            {
                for (int i = 0; i < key.Length; i++)
                    result[i] = char.Parse((int.Parse(key[i].ToString()) ^ int.Parse(sourceText[i].ToString())).ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(errorFormat,errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string myResult = new string(result);

            return myResult;
        }

        private void Swap<T>(ref T[] array, int index1, int index2)
        {
            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        private byte[] SBoxChange(byte[] sBox, byte[] keyBytes)
        {
            byte[] sBoxChange = sBox;
            int j = 0;
            for (int i = 0; i < COUNT_SYMBOLS_S_BOX; i++)
            {
                j = (j + sBoxChange[i] + keyBytes[i % keyBytes.Length]) % COUNT_SYMBOLS_S_BOX;
                Swap(ref sBoxChange,i,j);
            }

            return sBoxChange;
        }

        private byte[] GenerationKey(byte[] sBox,int lengthText)
        {
            byte[] tempSbox = sBox;
            byte[] keyBytes = new byte[lengthText];
            int i = 0, j = 0;
            
            for (int k = 0 ; k < lengthText; k++)
            {
                i = (i + 1) % COUNT_SYMBOLS_S_BOX;
                j = (j + sBox[i]) % COUNT_SYMBOLS_S_BOX;
                Swap(ref tempSbox,i,j);
                keyBytes[k] = sBox[(sBox[i] + sBox[j]) % COUNT_SYMBOLS_S_BOX];
            }

            return keyBytes;
        }

        private byte[] RC4FindKey(byte[] keyBytes)
        {
            byte[] sBox = new byte[COUNT_SYMBOLS_S_BOX];
            string result = "";

            for (int i = 0; i < COUNT_SYMBOLS_S_BOX; i++)
                sBox[i] = (byte)i;

            sBox = SBoxChange(sBox, keyBytes);

            return GenerationKey(sBox, plainBytes.Length);
        }

        private byte[] RC4Cipher(byte[] keyBytes)
        {
            byte[] result = new byte[keyBytes.Length];
            try
            {
                for (int i = 0; i < keyBytes.Length; i++)

                    result[i] = (byte)((int)keyBytes[i] ^ (int)plainBytes[i]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(errorFormat, errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

       
        private void lfsrButton_Click(object sender, EventArgs e)
        {
            lsfrKeyTextBox.Text = "";
            ciphertext.Text = "";
            key = keyTextBox.Text;
            cipherBytes = new byte[plainBytes.Length];
            for (int j = 0; j < plainBytes.Length; j++)
            {
                string[] newKeyArray = FindKey(key, POLYNOMIAL_FIRST);
                string newKey = newKeyArray[1];
                key = newKeyArray[0];
                
                string tempString = RFSRCipher(newKey,ByteToStringBin(plainBytes[j]));
                cipherBytes[j] = Convert.ToByte(tempString,2);

                if (j < OUTUP_ELEM)
                {
                    lsfrKeyTextBox.Text += newKey;
                    ciphertext.Text += tempString;
                }
            }
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog(this) == DialogResult.OK)
            {
                File.WriteAllBytes(saveFile.FileName, cipherBytes);
            }
        }

        private void geffeButton_Click(object sender, EventArgs e)
        {
            //ciphertext.Text = "";
            //for(int j = 0; j < plainBytes)
            //char[] key = FindThreeKey();
            //string newKey = new string(key);
            //cipherData = RFSRCipher(newKey);

            //int countOutputElement = (cipherData.Length > OUTUP_ELEM) ? OUTUP_ELEM : cipherData.Length;
            //for (int i = 0; i < countOutputElement; i++)
            //{
            //    ciphertext.Text += cipherData[i];
            //}
        }

        private void firstKey_TextChanged(object sender, EventArgs e)
        {
            
            firstKey.MaxLength = MaxElement(POLYNOMIAL_FIRST);
            secondKey.MaxLength = MaxElement(POLYNOMIAL_SECOND);
            thirdKey.MaxLength = MaxElement(POLYNOMIAL_THIRD);
            geffeButton.Enabled = ((firstKey.Text != "") && (secondKey.Text != "") && (thirdKey.Text != "") && (plaintext.Text != "") &&
                                   (firstKey.Text.Length == firstKey.MaxLength) && (secondKey.Text.Length == secondKey.MaxLength) && (thirdKey.Text.Length == thirdKey.MaxLength));
        }

        private int MaxElement(int[] array)
        {
            int cmpElem = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                cmpElem = (array[i] > cmpElem) ? i : cmpElem;
            }
            
            return cmpElem + 1;
        }

        private void kyeBoxRC4_KeyPress(object sender, KeyPressEventArgs e)
        {
            int symbol = (int)e.KeyChar;
            if (!(symbol >= (int)'0' && symbol <= (int)'9' || Convert.ToInt32(symbol) == Convert.ToInt32(Keys.Back)))
                e.Handled = true;
        }

        private void kyeBoxRC4_TextChanged(object sender, EventArgs e)
        {
            RC4button.Enabled = ((RC4KeyBox.Text != "") && (plaintext.Text != ""));
        }

        private void RC4button_Click(object sender, EventArgs e)
        {
            //ciphertext.Text = "";
            //RC4KeyTextBox.Text = "";
            //byte[] newKey = RC4FindKey(Encoding.Default.GetBytes(RC4KeyBox.Text));

            //int countOutputElement = (newKey.Length > OUTUP_ELEM) ? OUTUP_ELEM : newKey.Length;
            //for (int i = 0; i < countOutputElement; i++)
            //    RC4KeyTextBox.Text += newKey[i] + " ";

            //byte[] tempBytes = RC4Cipher(newKey);
            //string tempString = BytesToStringBin(tempBytes, tempBytes.Length);
            //cipherData = tempString;

            //countOutputElement = (tempString.Length > OUTUP_ELEM) ? OUTUP_ELEM : tempString.Length;
            //for (int i = 0; i < countOutputElement; i++)
            //    ciphertext.Text += tempString[i];
        }

        private OpenFileDialog InitializeOpenFile()
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "All files(*.*)|*.*";
            file.AddExtension = true;
            file.Title = "Open text";
            return file;
        }

        private SaveFileDialog InitializeSaveFile()
		{
			SaveFileDialog file = new SaveFileDialog();
		    file.Filter = "All files(*.*)|*.*";
            file.AddExtension = true;
			file.Title = "Save text";
			return file;
		}

        private void button1_Click(object sender, EventArgs e)
        {

            if (openFile.ShowDialog(this) == DialogResult.OK)
            {
               plaintext.Text = "";
               
                plainBytes = File.ReadAllBytes(openFile.FileName);
                if (plainBytes.Length != 0)
                {
                    int i = 0;
                    while (i < OUTUP_ELEM && i < plainBytes.Length)
                    {

                        plaintext.Text += ByteToStringBin(plainBytes[i]);
                        i++;
                    }
                }
                else
                    EmptyFile();
            }
        }
        public void EmptyFile()
        {
            MessageBox.Show(errorEmptyFile, errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}