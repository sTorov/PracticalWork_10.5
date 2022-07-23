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
            bool check = false;
            char returnChar;
            bool warningPrint = false;
            const string WARNING = "Нажата неверная клавиша!";

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