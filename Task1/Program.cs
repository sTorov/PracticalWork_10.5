namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberReader numberReader = new NumberReader();
            Calculator calculator = new Calculator();
            numberReader.readNumberEvent += calculator.Sum;

            while (true)
            {
                try
                {
                    numberReader.ReadValue();

                    Console.WriteLine("\nДля продолжения нажмите 'y'\nДля выхода нажмите любую другую клавишу");
                    char ch = Console.ReadKey(true).KeyChar;
                    switch (ch)
                    {
                        case 'y':
                            Console.Clear();
                            continue;
                        default:
                            break;
                    }

                    break;
                }
                catch (Exception e)
                {
                    PrintException(e);
                    Console.ReadKey();
                    Console.Clear();
                }
            }            
        }

        static void PrintException(Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n" + e.Message);
            Console.ResetColor();
        }
    }
}