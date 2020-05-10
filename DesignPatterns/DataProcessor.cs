using System;

namespace DesignPatterns
{
    public abstract class DataProcessor
    {
        public void ReadProcessAndSave()
        {
            ReadData();
            ProcessData();
            SaveData();
        }

        protected abstract void ReadData();

        protected abstract void ProcessData();

        private void SaveData()
        {
            Console.WriteLine("Save data to DB");
        }
    }
}
