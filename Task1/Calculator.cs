namespace Task1
{
    /// <summary>
    /// Класс, реализующий интерфейс ICalculator<br/>
    /// Выполнение операций над 2-мя числами
    /// </summary>
    class Calculator : ICalculator
    {
        private double Number1 { get; set; }
        private double Number2 { get; set; }

        public void Sum(double numberOne, double numberTwo)
        {
            Console.WriteLine("Ответ: " + Math.Round((numberOne + numberTwo), 6, MidpointRounding.AwayFromZero));
        }

        /// <summary>
        /// Ввод 2-х чисел в консоль с клавиатуры и вызов метода, складывающего их<br/>
        /// Проверка введённых значений на корректность
        /// </summary>
        public void ReadValue()
        {
            Func<int, double> checkValue = (int oper) =>
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

        /// <summary>
        /// Вывод на консоль сообщения об ошибке с форматированием
        /// </summary>
        /// <param name="e"></param>
        private static void PrintException(Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(e.Message);
            Console.ResetColor();
        }
    }
}
