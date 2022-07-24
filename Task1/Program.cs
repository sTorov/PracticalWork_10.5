namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

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
                    if(!warningPrint)
                    {
                        Other.ClearLine();
                        Console.WriteLine(WARNING);
                        warningPrint = true;
                    }
                    else
                    {
                        Other.ClearLine(2);
                        Console.WriteLine(WARNING);
                    }
                }
            } while (!check);

            return returnChar;
        }
    }
}