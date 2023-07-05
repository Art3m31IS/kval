using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kval
{
    public class Room:IComparable<Room>
    {
        public string Name { get; set; }
        public int Area { get; set; }

        public Room(string name, int area)
        {
            Name = name;
            Area = area;
        }

        public string Show()
        {
            return $"Имя : {Name}\nПлощадь : {Area}";
        }

        public int CompareTo(Room other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
///Залевский Артём 31ИС 
///10 билет
