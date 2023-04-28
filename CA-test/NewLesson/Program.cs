using NewLesson.Cars;
using NewLesson.Constants;
using System.Globalization;

namespace NewLesson
{
    public class Database
    {
        public static List<Car> _cars = new List<Car>
        {
            new Bmw(Color.Blue, 240, 2018, SpeedBoxType.AUTO, 2.4f),
            new Audi(Color.Black, 400, 2020, SpeedBoxType.AUTO, 3.2f),
            new Mercedes(Color.Orange, 320, 1995, SpeedBoxType.MECHANIC, 3.8f),
            new Mercedes(Color.Blue, 250, 1990, SpeedBoxType.ROBOT, 2)
        };
    }

    public class Program
    {
        static void Main(string[] args)
        {

            
        }
    }
}