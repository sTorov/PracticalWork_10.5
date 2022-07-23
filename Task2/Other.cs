namespace Task2
{
    public static class Other
    {
        public static void ClearLine(int count = 1)
        {
            for(int i = 1; i <= count; i++)
            {
                Console.SetCursorPosition(0, Console.GetCursorPosition().Top - 1);
                Console.Write(new string(' ', Console.BufferWidth) + "\r");
            }
        }
    }
}
