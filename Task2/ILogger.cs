namespace Task2
{
    public interface ILogger
    {
        void Error(Exception e);

        void Result(double result);
    }
}
