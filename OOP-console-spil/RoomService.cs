using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_console_spil
{
    internal static class Service
    {

        public static Room CurrentRoom = new Room(1, "room1", "Current Room skal du vælge retninger", "Tom", null, room2, null, null);
        public static Room room2 = new Room(2, "room2", "Mørkeroom der er en Reedbul", "Reebul", room3, null, null, null);
        public static Room room3 = new Room(3, "room3", "Mørke room der er en Pizza også går til anden Room", "Pizza", null, null, null, room4);
        public static Room room4 = new Room(4, "room4", "Lyse room", "våben", null, room5, null, null);
        public static Room room5 = new Room(5, "room5", "Mørkeroom 5", "fjende", null, null, room6, null);
        public static Room room6 = new Room(6, "room6", "Mørkeroom 6", "våben", null, room7, null, null);
        public static Room room7 = new Room(7, "room7", "Mørkeroom 7", "våben", null, null, null, room8);
        public static Room room8 = new Room(8, "room8", "Mørkeroom 8", "våben", room9, null, null, null);
        public static Room room9 = new Room(9, "room9", "Mørkeroom 9", "våben", null, null, CurrentRoom, null);

        static Service()
        {

            CurrentRoom.Nord = room2;    
            room2.Syd = CurrentRoom;     

            room2.Nord = room3;          
            room3.Syd = room2;           

            room3.Nord = room4;         
            room4.Syd = room3;          

            room4.Øst = room5;           
            room5.Vest = room4;          

            room5.Nord = room6;          
            room6.Syd = room5;           

            room6.Øst = room7;           
            room7.Vest = room6;         

            room7.Nord = room8;          
            room8.Syd = room7;           

            room8.Nord = room9;          
            room9.Syd = room8;           

            room9.Øst = CurrentRoom;     
            CurrentRoom.Vest = room9;










        }



    }
}
