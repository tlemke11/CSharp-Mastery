using System;
namespace Vehicles
{
    //inspired by https://videos.raywenderlich.com/courses/47-beginning-c/lessons/26

    abstract class Vehicle
    {
        public abstract string honk();
        public abstract string revEngine();
    }

    class Lambo : Vehicle
    {
        public override string honk()
        {
            return "TootToot!";
        }

        public override string revEngine()
        {
            return "VROOM!";
        }
    }

    class GeoMetro : Vehicle
    {
        public override string honk()
        {
            return "tootle!";
        }

        public override string revEngine()
        {
            return "put put";
        }
    }
}
