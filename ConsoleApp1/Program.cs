using kval;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apartment apartment = new Apartment("12", "Залевский Артём");
            Room room = new Room("Гостиная", 10);
            Room room1 = new Room("Спальня", 20);
            Room room2 = new Room("1-я комната", 13);
            Room room3 = new Room("2-я комната", 15);

            apartment.AddRoom(room);
            apartment.AddRoom(room1);
            apartment.AddRoom(room2);
            apartment.AddRoom(room3);

            Console.WriteLine(apartment.ShowAll());
            Console.WriteLine(room.CompareTo(room1));
            Console.ReadLine();

        }
    }
}
///Залевский Артём 31ИС 
///10 билет