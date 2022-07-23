namespace Task2
{
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

        static char GetPressKey(string message, char[] charArray)
        {
            const string WARNING = "Нажата неверная клавиша!";

            bool check = false;
            bool warningPrint = false;
            char returnChar;

            do
            {
                Console.WriteLine(message);

                returnChar = Console.ReadKey(true).KeyChar;
                foreach (var item in charArray)
                {
                    string temp = returnChar.ToString().ToUpper();
                    if (temp[0] == item)
                    {
                        check = true;
                        returnChar = item;
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
