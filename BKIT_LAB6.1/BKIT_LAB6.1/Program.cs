using System;

namespace BKIT_LAB6
{
    public delegate T3 Operation<T1, T2, T3>(T1 firstValue, T2 secondValue);

    class Program
    {
        static void Main(string[] args)
        {
            string inputText;
            char inputChar;

            Console.Write("Enter the text: ");
            inputText = Console.ReadLine();
            Console.Write("Enter the symbol you want to delete from the text: ");
            inputChar = Console.ReadLine()[0];

            Console.Write("\n    Opertion<> delegate result (using method): ");
            Print(new Operation<string, char, string>(DeleteSymbol), inputText, inputChar);
            Console.Write("    Func<> delegate result (using method): ");
            Print(new Func<string, char, string>(DeleteSymbol), inputText, inputChar);

            Console.Write("\nEnter the text: ");
            inputText = Console.ReadLine();
            Console.Write("Enter the symbol you want to add to the end of the text: ");
            inputChar = Console.ReadLine()[0];

            Console.Write("\n    Opertion<> delegate result (using lambda): ");
            Print((Operation<string, char, string>)((text, symbol) => text + symbol), inputText, inputChar);
            Console.Write("    Func<> delegate result (using labmda): ");
            Print((Func<string, char, string>)((text, symbol) => text + symbol), inputText, inputChar);

            Console.ReadKey();
        }

        static string DeleteSymbol(string text, char symbol)
        {
            string modifiedText = "";
            foreach (char ch in text)
                if (ch != symbol)
                    modifiedText += ch;
            return modifiedText;
        }

        static void Print(Operation<string, char, string> textOperation, string text, char symbol)
        {
            Console.WriteLine("\"" + text + "\" => \"" + textOperation(text, symbol) + "\"");
        }

        static void Print(Func<string, char, string> textOperation, string text, char symbol)
        {
            Console.WriteLine("\"" + text + "\" => \"" + textOperation(text, symbol) + "\"");
        }
    }
}
