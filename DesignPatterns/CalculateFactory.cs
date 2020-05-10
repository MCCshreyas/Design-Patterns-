namespace DesignPatterns
{
    public class CalculateFactory
    {
        public ICalculate GetCalculation(string type)
        {
            ICalculate calculate;

            if (type.Equals("add"))
            {
                calculate = new Add();
                return calculate;
            }

            if(type.Equals("subtract"))
            {
                calculate = new Subtract();
                return calculate;
            }

            return null;
        }
    }
}
