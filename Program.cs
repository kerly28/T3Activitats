using System;

namespace T3Activitats
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Vehicle
            Vehicle1 vehicle = new Vehicle1("Generic Vehicle");
            Console.WriteLine($"Vehicle: {vehicle.Name}\n");
            //Rodes
            Wheeled wheeledVehicle = new Wheeled("Wheeled Vehicle", 4);
            Console.WriteLine($"Wheeled Vehicle: {wheeledVehicle.Name}, Wheels: {wheeledVehicle.Wheels}\n");
            //Barco
            Boat boat = new Boat("Titanic", "Cruise");
            Console.WriteLine($"Boat: {boat.Name}, Type: {boat.Type}\n");
            //Dos rodes
            TwoWheels twoWheelsVehicle = new TwoWheels("Bike", 2, "Mountain", 20);
            Console.WriteLine($"TwoWheels: {twoWheelsVehicle.Name}, Wheels: {twoWheelsVehicle.Wheels}, Type: {twoWheelsVehicle.Type}, Speed: {twoWheelsVehicle.Speed} km/h\n");
            //Quatre rodes
            FourWheels fourWheelsVehicle = new FourWheels("Car", 4, "Sedan", 150);
            Console.WriteLine($"FourWheels: {fourWheelsVehicle.Name}, Wheels: {fourWheelsVehicle.Wheels}, Type: {fourWheelsVehicle.Type}, Speed: {fourWheelsVehicle.Speed} km/h\n");
            //Cotxe personal
            PersonalCar personalCar = new PersonalCar("RayoMcqueen", 4, "Toyota", 200, "Personal");
            Console.WriteLine($"PersonalCar: {personalCar.Name}, Wheels: {personalCar.Wheels}, Type: {personalCar.Type}, Speed: {personalCar.Speed} km/h, Personal Type: {personalCar.TypePersonalCar}\n");
            //Cotxe de treball
            WorkCar workCar = new WorkCar("TMB", 8, "Bus", 120, "Public");
            Console.WriteLine($"WorkCar: {workCar.Name}, Wheels: {workCar.Wheels}, Type: {workCar.Type}, Speed: {workCar.Speed} km/h, Work Type: {workCar.TypeWorkCar}\n");
        }
    }
}
