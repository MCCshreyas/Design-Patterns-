using System;

namespace DesignPatterns
{
    public class Program
    {
        static void Main()
        {
            ExcelFile e = new ExcelFile();
            e.ReadProcessAndSave();

            Console.ReadLine();
        }
    }
}
