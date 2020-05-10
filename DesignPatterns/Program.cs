using System;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            ExcelFile e = new ExcelFile();
            e.ReadProcessAndSave();

            Console.ReadLine();
        }
    }
}
