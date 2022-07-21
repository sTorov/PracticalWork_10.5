namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new Logger();            
            Calculator calculator = new Calculator();
            calculator.operationEvent += logger.Result;

            while (true)
            {
                try
                {
                    calculator.ReadValue();

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
                    logger.Error(e);
                    Console.ReadKey();
                    Console.Clear();
                }
            }            
        }        
    }
}