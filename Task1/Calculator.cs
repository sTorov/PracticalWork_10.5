namespace Task1
{
    delegate double CheckValueDelegate(int oper);

    class Calculator : ICalculator
    {
        private double Number1 { get; set; }
        private double Number2 { get; set; }

        public void Sum(double numberOne, double numberTwo)
        {
            Console.WriteLine("Ответ: " + Math.Round((numberOne + numberTwo), 6, MidpointRounding.AwayFromZero));
        }

        public void ReadValue()
        {
            CheckValueDelegate checkValue = (int oper) =>
            {
                while (true)
                {
                    Console.Write($"Введите {oper}-ю цифру: ");
                    try
                    {
                        if (double.TryParse(Console.ReadLine(), out double result))
                            return result;
                        else
                            throw new Exception("Ошибка! Неверное значение. Попробуйте снова.");
                    }
                    catch (Exception e)
                    {
                        PrintException(e);
                        Console.ReadKey();
                        Other.ClearLine(2);
                        continue;
                    }
                }
            };

            Number1 = checkValue(1);
            Number2 = checkValue(2);

            Sum(Number1, Number2);
        }

        private void PrintException(Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(e.Message);
            Console.ResetColor();
        }
    }
}
