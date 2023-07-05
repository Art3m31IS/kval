using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace kval
{
    public class Apartment
    {

        private List<Room> rooms = new List<Room>();
        public string Number { get; set; }
        public string Owner { get; set; }

            public Apartment(string number, string owner)
            {
                rooms = new List<Room>();
                Number = number;
                Owner = owner;  
            }

            public void AddRoom(Room room)
            {
                rooms.Add(room);
            }

        public StringBuilder ShowAll()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Owner: {Owner}");
            stringBuilder.AppendLine($"Number: {Number}");
            foreach (Room room in rooms)
            {
                stringBuilder.AppendLine(room.Show());
            }
            return stringBuilder;
        }

    }
}
///Залевский Артём 31ИС 
///10 билет
