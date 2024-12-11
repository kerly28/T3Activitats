using System;

namespace T3Activitats
{
    public class PersonalCar : FourWheels
    {
        public string TypePersonalCar { get; set; }

        public PersonalCar(string name, int wheels, string type, int speed, string typePersonalCar) : base(name, wheels, type, speed)
        {
            TypePersonalCar = typePersonalCar;
        }
    }
}


