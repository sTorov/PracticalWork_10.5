namespace Task2
{
    delegate double CheckValueDelegate(string value);
    delegate void OperationDelegate(double num);

    class Calculator : ICalculator
    {
        public event OperationDelegate operationEvent;
        
        private double Number1 { get; set; }
        private double Number2 { get; set; }

        public void Sum(double num1, double num2)
        {
            CallOperationEvent(num1 + num2);
        }

        public void ReadValue()
        {
            Console.WriteLine("Введите 2 цифры\n");
            CheckValueDelegate checkValue = (string value) =>
            {
                if (double.TryParse(value, out double result))
                    return result;
                else
                    throw new Exception("Ошибка! Неверное значение. Попробуйте снова.");
            };

            Console.Write("1-я цифра: ");
            Number1 = checkValue(Console.ReadLine());
            
            Console.Write("2-я цифра: ");
            Number2 = checkValue(Console.ReadLine());

            Sum(Number1, Number2);
        }
        
         protected void CallOperationEvent(double num1)
        {
            operationEvent?.Invoke(num1);
        }
    }
}
