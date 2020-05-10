using System;

namespace DesignPatterns
{
    public class ExcelFile : DataProcessor
    {
        protected override void ReadData()
        {
            Console.WriteLine("Read data from Excel file");
        }

        protected override void ProcessData()
        {
            Console.WriteLine("Process data from Excel file");
        }
    }
}
