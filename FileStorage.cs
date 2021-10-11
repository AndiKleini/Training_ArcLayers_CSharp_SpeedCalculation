using System;
using System.IO;

namespace SpeedCalculation
{
    public class FileStorage : IStorage
    {
        public void Store(int meter, int seconds, float speed)
        {
            String text =
                "Speed was calculated from distance-> " +
                meter +
                " m and time " +
                seconds +
                " secs " +
                "as " +
                speed;
            File.WriteAllText("./output.txt", text);
        }
    }
}
