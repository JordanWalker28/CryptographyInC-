using System;

namespace Cipher
{
    public static class AsciiGenerator
    {
        public static string convertToAscii(string text)
        {

            int[] array = new int[text.Length];

            for(int i =0; i < text.Length; i++)
            {
                array[i] = Convert.ToInt32(text[i]);
            }

            return convertArrayToString(array);
            
        }

        private static string convertArrayToString(int[] array)
        {
            string result = string.Empty;

            foreach(int c in array)
            {
                result += converFromAscii(c);
            }

            return result;
        }

        private static char converFromAscii(int c)
        {

            char d = Convert.ToChar(c);
            Console.WriteLine(d + " " + c);
            return d;
        }

        
    }
}
