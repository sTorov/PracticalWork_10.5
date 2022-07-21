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
        }       
    }
}