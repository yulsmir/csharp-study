using System;

namespace _002_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printText = new Printer();
            printText.Value = "This is a loooong text for Printer";
            printText.Print(printText.Value);

            Printer1 printText1 = new Printer1();
            printText = printText1 as Printer;
            printText1.Value = "This is a loooong text for Printer1";
            printText1.Print(printText1.Value);

            Printer2 printText2 = new Printer2();
            printText = printText2 as Printer;
            printText2.Value = "This is a loooong text for Printer2";
            printText2.Print(printText2.Value);

            Printer3 printText3 = new Printer3();
            printText = printText3 as Printer;
            printText3.Value = "This is a loooong text for Printer3";
            printText3.Print(printText3.Value);

            Console.ReadKey();
        }
        // TODO: Optimize method for each child
    }
}
