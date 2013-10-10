using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_time_pad
{
    public static class Cryptor
    {
        private static string GenerateKey(int keylength)
        {
            int seed = DateTime.Now.Minute + DateTime.Now.Millisecond;

            Random rand = new Random(seed);

            char[] codeArray = new char[keylength];

            for (int i = 0; i < keylength; i++)
            {
                codeArray[i] = Convert.ToChar(rand.Next(0,25) + 65);
            }

            string key = new string(codeArray);

            return key;
        }

        public static string Encode(string keyInput, string input)
        {
            string text = input.ToUpper();
            string key = keyInput.ToUpper();
            string output;

            char[] charText = Encoder(key, text);

            output = new string(charText);

            return output;
        }

        public static string[] Encode(string input)
        {
            string text = input.ToUpper();
            string[] output = new string[2];

            string key = GenerateKey(text.Length);
            output[0] = key;


            char[] charText = Encoder(key, text);
            

            output[1] = new string(charText);

            return output;
        }

        private static char[] Encoder(string key, string text)
        {
            char[] charKey = key.ToCharArray();
            char[] charText = text.ToCharArray();

            for (int i = 0; i < key.Length; i++)
            {
                int temp = charKey[i] - 65;

                if ((temp + charText[i]) > 90)
                {
                    //char temporary = Convert.ToChar(((charText[i] + temp) - 90) + 64); // keeping old way as reference
                    char temporary = Convert.ToChar((charText[i] + temp) - 26);
                    charText[i] = temporary; // extra line of code added for easier debugging
                }
                else
                {
                    char temporary = Convert.ToChar(charText[i] + temp);
                    charText[i] = temporary;
                }
            }

            return charText;
        }

        
        public static string Decode(string keyInput, string textInput)
        {
            string text = textInput.ToUpper();
            string key = keyInput.ToUpper();
            char[] charKey = key.ToCharArray();
            char[] charText = text.ToCharArray();

            for (int i = 0; i < key.Length; i++)
            {
                int temp = charKey[i] - 65;
                char temporary;

                if ((charText[i] - temp) < 65)
                {
                    temporary = Convert.ToChar((charText[i] + 26) - temp);
                }
                else
                {
                    temporary = Convert.ToChar(charText[i] - temp);
                }
                charText[i] = temporary;

            }

            string output = new string(charText);
            return output;
        }
        
    }
}
