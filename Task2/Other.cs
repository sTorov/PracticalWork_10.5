namespace Task2
{
    /// <summary>
    /// Статический класс с дополнительными методами
    /// </summary>
    public static class Other
    {
        /// <summary>
        ///Стирает информацию с предыдущих линий в консоли и переводит каретку в начало последней очищенной линии<br/>
        ///В качестве параметра указывается количество стираемых строк. По умолчанию - 1
        /// </summary>
        /// <param name="count"></param>
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
