using System;

namespace T3Activitats
{
    public class WorkCar : FourWheels
    {
        public string TypeWorkCar { get; set; }

        public WorkCar(string name, int wheels, string type, int speed, string typeWorkCar) : base(name, wheels, type, speed)
        {
            TypeWorkCar = typeWorkCar;
        }
    }
}

