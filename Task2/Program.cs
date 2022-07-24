namespace Task2
{
    /// <summary>
    /// Основной класс программы
    /// </summary>
    class Program
    {
        static ILogger logger { get; set; }
        
        static void Main(string[] args)
        {
            logger = new Logger();
            Calculator calculator = new Calculator(logger);

            while (true)
            {
                calculator.ReadValue();

                char ch = GetPressKey("Продолжить? ( Y / N )", new char[] { 'Y', 'N' });
                switch (ch)
                {
                    case 'Y':
                        Console.Clear();
                        continue;
                    case 'N':
                        break;
                }

                break;
            }            
        }

        /// <summary>
        /// Проверка нажатой клавиши на корректность. При корректном нажатия возвращает символ нажатой клавиши<br/>
        /// <br/>
        /// Параметры метода<br/>
        /// <br/>
        /// <c>string message</c> - Выводимое сообщение на консоль перед началом проверки<br/>
        /// <c>char[] charArray</c>: - Массив символов для проверки<br/>
        /// <br/>
        /// Данный метод будет выполнятся до тех пор, пока не будет нажата одна из клавиш, которая передаст в программу<br/>
        /// символ, который содержится в <c>char[] charArray</c>. При нажатии неверной клавиши выводится предупреждение<br/> 
        /// на консоль и происходит повторное нажате клавиши. Также, в методе происходит преобразоване символа в прописной.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="charArray"></param>
        /// <returns></returns>
        static char GetPressKey(string message, char[] charArray)
        {
            const string WARNING = "Нажата неверная клавиша!";

            bool check = false;
            bool warningPrint = false;
            char returnChar;

            Console.WriteLine();

            do
            {
                Console.WriteLine(message);

                returnChar = char.ToUpper(Console.ReadKey(true).KeyChar);
                foreach (var item in charArray)
                {
                    if (returnChar == item)
                    {
                        check = true;
                        break;
                    }
                }
                if (!check)
                {
                    if (!warningPrint)
                    {
                        Other.ClearLine();
                        logger.Error(WARNING);
                        warningPrint = true;
                    }
                    else
                    {
                        Other.ClearLine(2);
                        logger.Error(WARNING);
                    }
                }
            } while (!check);

            return returnChar;
        }
    }

}
