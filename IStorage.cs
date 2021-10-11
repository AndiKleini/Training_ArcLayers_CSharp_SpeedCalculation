namespace SpeedCalculation
{
    public interface IStorage
    {
        void Store(int meter, int seconds, float speed);
    }
}