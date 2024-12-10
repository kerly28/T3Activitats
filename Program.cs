using System;

namespace T3Activitats
{
    public class Program
    {
        public static void Main()
        {
            // Crear un edificio
            Building building = new Building("Hotel Vela", "Barcelona", 50, 15000.5, "Turístic");

            // Crear habitaciones (relacionadas al edificio pero no como una lista)
            Room room1 = new Room(666, "Dutxes");
            Room room2 = new Room(111, "Sala de jocs");

            // Mostrar información del edificio y las habitaciones
            Console.WriteLine("Edifici: " + building.Name + " - " + building.Location);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Número de pisos: " + building.Floors);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Superficie total: " + building.Area + " m²");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Tipus d'edifici: " + building.Type);
            Console.WriteLine("------------------------------------");

            // Habitacions
            Console.WriteLine("\nHabitacions:");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Habitació {room1.RoomNumber}: {room1.Type}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Habitació {room2.RoomNumber}: {room2.Type}");
            Console.WriteLine("------------------------------------");
        }
    }
}
