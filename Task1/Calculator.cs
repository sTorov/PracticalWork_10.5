namespace Task1
{
    class Calculator : ICalculator
    {
        public void Sum(double numberOne, double numberTwo)
        {
            Console.WriteLine("\nОтвет: " + Math.Round((numberOne + numberTwo), 6, MidpointRounding.AwayFromZero));
        }
    }
}
