namespace Task2
{
    /// <summary>
    /// Определяет метод сложения 2-х чисел
    /// </summary>
    interface ICalculator
    {
        /// <summary>
        /// Сложение 2-х чисел
        /// </summary>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        void Sum(double numberOne, double numberTwo);
    }
}
