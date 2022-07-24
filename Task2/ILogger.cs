namespace Task2
{
    /// <summary>
    /// Определяет методы для обработки строк, передаваемых в качестве параметра
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Обработчик ошибок
        /// </summary>
        /// <param name="message"></param>
        void Error(string message);

        /// <summary>
        /// Обработчик событий
        /// </summary>
        /// <param name="message"></param>
        void Event(string message);
    }
}
