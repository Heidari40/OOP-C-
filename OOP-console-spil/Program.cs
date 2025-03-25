using System;
using System.Text;

class Program

    {
        public static Room room1 = new Room(1, "room1", "u står i et rum, hvor du skal vælge en retning at gå i.", new List<Item>(), null, null, null, null);
        public static Room room2 = new Room(2, "room2", "Et dunkelt rum, hvor en Red Bull-dåse ligger på gulvet.", new List<Item>(), null, null, null, null);
        public static Room room3 = new Room(3, "room3", "Et mørkt rum med en duft af pizza. Der er en vej til et andet rum.", new List<Item>(), null, null, null, null);
        public static Room room4 = new Room(4, "room4", "Et lyst oplyst rum, hvor du føler dig mere tryg.", new List<Item>(), null, null, null, null);
        public static Room room5 = new Room(5, "room5", "Et dystert rum med en ubehagelig stilhed.", new List<Item>(), null, null, null, null);
        public static Room room6 = new Room(6, "room6", "En mørk korridor fører dig ind i dette skumle rum.", new List<Item>(), null, null, null, null);
        public static Room room7 = new Room(7, "room7", "En skyggefuld krog, hvor du kan mærke en kold brise.", new List<Item>(), null, null, null, null);
        public static Room room8 = new Room(8, "room8", "Et mørkt kammer, hvor lyden af dryppende vand ekkoer i baggrunden.", new List<Item>(), null, null, null, null);
        public static Room room9 = new Room(9, "room9", "Et dystert rum, hvor du får fornemmelsen af at blive iagttaget.", new List<Item>(), null, null, null, null);


  
        static void Main(string[] args)
        {
            Item key = new Item(1, "Nøgle", "en gammel rusten nøgle");
            room1.Items.Add(key);
            room1.Nord = room2;

            room2.Nord = room1;
            room2.Syd = room3;
            room2.Øst = room5;

            room3.Syd = room2;
            room3.Nord = room4;
            room3.Vest = room6;

            room4.Syd = room3;
            room4.Øst = room7;

            room5.Vest = room2;
            room5.Syd = room8;

            room6.Øst = room3;
            room7.Vest = room4;
            room7.Syd = room9;
         

        Console.WriteLine("Welcomme til Dark room");
            Console.WriteLine("Du skal finde en våben! ");
            Console.WriteLine(" 'N' => Nord ");
            Console.WriteLine(" 'S' => Syd ");
            Console.WriteLine(" 'Ø' => Øst ");
            Console.WriteLine(" 'V' => Vest ");
            Room CurrentRoom = room1;




        while (true)
            {
                Console.WriteLine(CurrentRoom.ToString());

            for (int i = 0; i < CurrentRoom.Items.Count; i++)
            {
                if (CurrentRoom.Items[i] != null)
                {
                    Console.WriteLine(CurrentRoom.Items[i]);
                    

                }
            }



             StringBuilder sb = new StringBuilder();

               if (CurrentRoom.Nord != null)
                {
                sb.AppendLine("Nord(N)");
                }
               if (CurrentRoom.Øst != null)
                {
                sb.AppendLine("Øst(Ø)");
                }
                if(CurrentRoom.Vest != null)
                 {
                sb.AppendLine("Vest(V)");
                 }
                if(CurrentRoom.Syd != null)
                 {
                sb.AppendLine("Syd(S)");
                 }
            sb.AppendLine("Pick up Item (PU)");
              Console.WriteLine(sb);



            Console.WriteLine("Hvor skla du går: ");

           
            string vælge = Console.ReadLine().ToLower();




            switch (vælge)
                {
                    case "n":
                        if (CurrentRoom.Nord != null)
                        {
                            //sb.AppendLine(CurrentRoom.Nord.Items);
                            CurrentRoom = CurrentRoom.Nord;
                            
                        }
                        else
                        {
                            Console.WriteLine("Der er ingen vej mod nord");
                        }

                        break;

                    case "s":
                        if (CurrentRoom.Syd != null)
                        {

                            CurrentRoom = CurrentRoom.Syd;
                        }
                        else
                        {
                            Console.WriteLine("Der er ingen vej mod syd");
                        }

                        break;

                    case "ø":
                        if (CurrentRoom.Øst != null)
                        {

                            CurrentRoom = CurrentRoom.Øst;

                        }
                        else
                        {
                            Console.WriteLine("Der er ingen vej mod øst");
                        }

                        break;

                    case "v":
                        if (CurrentRoom.Vest != null)
                        {

                            CurrentRoom = CurrentRoom.Vest;
                        }
                        else
                        {
                            Console.WriteLine("Der er ingen vej mod vest");
                        }
                    break;
                case "PU":

                       int spaceIndex = vælge.IndexOf(' ');
                       string ItemName = vælge.Substring(spaceIndex + 1);
                       for (int i = 0; i < CurrentRoom.Items.Count; i++)
                       {
                        if (CurrentRoom.Items[i].Name == ItemName)
                            ItemName = CurrentRoom.Items[i].Name;
                        
                       }


                    break;
                   

                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg. prøv igen.");
                        break;

                }

            }


        }
    }



