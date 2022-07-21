namespace Task1
{
    delegate double CheckValueDelegate(string value);
    delegate void ReadNumberDelegate(double num1, double num2);

    class NumberReader
    {
        public event ReadNumberDelegate readNumberEvent;
        
        private double Number1 { get; set; }
        private double Number2 { get; set; }
        
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

            CallReadNumberEvent(Number1, Number2);
        }

        void CallReadNumberEvent(double num1, double num2)
        {
            readNumberEvent?.Invoke(num1, num2);
        }
    }
}
