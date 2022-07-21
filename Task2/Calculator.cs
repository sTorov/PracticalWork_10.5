namespace Task2
{
    delegate double CheckValueDelegate(int oper);

    class Calculator : ICalculator
    {       
        private double Number1 { get; set; }
        private double Number2 { get; set; }
        public ILogger Logger { get; set; }

        public Calculator(ILogger logger)
        {
            Logger = logger;
        }

        public void Sum(double num1, double num2)
        {
            Logger.Result(num1 + num2);
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
                        Logger.Error(e);                        
                        continue;
                    }
                }                             
            };

            Number1 = checkValue(1);            
            Number2 = checkValue(2);

            Sum(Number1, Number2);
        }        
    }
}
