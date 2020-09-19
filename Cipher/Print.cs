using System;
namespace Cipher
{
    public static class Print
    {
        

        public static void PrintOutput(string Message, string MessageType)
        {
            switch (MessageType)
            {
                case "Error":
                    PrintErrorMessage(Message);
                    break;
                case "Warning":
                    PrintWarningMessage(Message);
                    break;
                case "Update":
                    PrintUpdateMessage(Message);
                    break;
                default:
                    PrintMessage(Message);
                    break;
            }
        }

        private static void PrintUpdateMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            PrintMessage(message);
        }

        private static void PrintWarningMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintMessage(message);
        }

        private static void PrintErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            PrintMessage(message);
        }

        private static void PrintMessage(string message)
        {
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
