namespace Task2
{
    class Logger : ILogger
    {
        public void Error(Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e.Message);
            Console.ResetColor();
        }

        public void Result(double result)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ответ: " + Math.Round(result, 6, MidpointRounding.AwayFromZero));
            Console.ResetColor();
        }
    }
}
