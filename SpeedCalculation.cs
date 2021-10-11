namespace SpeedCalculation
{
    public class SpeedCalculation : ISpeedCalculation
    {
        private IStorage storage;

        public SpeedCalculation(IStorage storage)
        {
            this.storage = storage;
        }

        public void ProcessSpeedCalculation(int meter, int seconds)
        {
            var speed = (float)meter / (float)seconds;
            this.storage.Store(meter, seconds, speed);
        }
    }
}
