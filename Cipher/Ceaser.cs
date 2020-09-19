using System;

namespace Cipher
{
    public class Ceaser
    {

        public string Text { get; set; }
        public int Number { get; set; }

        public Ceaser(string text, int number)
        {
            this.Text = text;
            this.Number = number;

            Console.WriteLine(Text, Number);
        }

        public string EncrpytString()
        {
            string EncryptedString = ModifyString(Text, Number);

            return EncryptedString;
        }

        public string DecrpytString()
        {
            string DecrpytedString = ModifyString(Text, Number);

            return DecrpytedString;
        }

        private string ModifyString(string Text, int Number)
        {
            string ModifiedString = string.Empty;

            return ModifiedString;
        }
    }
}
