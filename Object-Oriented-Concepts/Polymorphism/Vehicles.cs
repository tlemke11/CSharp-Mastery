using System;
namespace Vehicles
{
    //PolyMorphism is enabled by Abstract Classes and Interfaces
    //PolyMorphism means "many forms" - https://www.artima.com/objectsandjava/webuscript/PolymorphismInterfaces1.html
    //Here it enables us to create two different "forms" of a vehicle
    //inspired by https://videos.raywenderlich.com/courses/47-beginning-c/lessons/26


    //C++ uses the "virtual" keywork instead of "abstract"
    abstract class Vehicle
    {
        //abstract means that there no concrete implementations
        //so we merely allude to a honk and revEngine, but we don't know how they work except for the data type
        //that they return
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
