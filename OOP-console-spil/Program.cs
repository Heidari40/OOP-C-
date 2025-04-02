using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program

    {
        public static Room room1 = new Room(1, "room1", "Du står i et rum, hvor du skal vælge en retning at gå i.", new List<Item>(), null, null, null, null, new List<Monster>());
        public static Room room2 = new Room(2, "room2", "Et dunkelt rum, hvor en Red Bull-dåse ligger på gulvet.", new List<Item>(), null, null, null, null, new List<Monster>());
        public static Room room3 = new Room(3, "room3", "Et mørkt rum med en duft af pizza. Der er en vej til et andet rum.", new List<Item>(), null, null, null, null, new List<Monster>());
        public static Room room4 = new Room(4, "room4", "Et lyst oplyst rum, hvor du føler dig mere tryg.", new List<Item>(), null, null, null, null, new List<Monster>());
        public static Room room5 = new Room(5, "room5", "Et dystert rum med en ubehagelig stilhed.", new List<Item>(), null, null, null, null, new List<Monster>());
        public static Room room6 = new Room(6, "room6", "En mørk korridor fører dig ind i dette skumle rum.", new List<Item>(), null, null, null, null, new List<Monster>());
        public static Room room7 = new Room(7, "room7", "En skyggefuld krog, hvor du kan mærke en kold brise.", new List<Item>(), null, null, null, null, new List<Monster>());
        public static Room room8 = new Room(8, "room8", "Et mørkt kammer, hvor lyden af dryppende vand ekkoer i baggrunden.", new List<Item>(), null, null, null, null, new List<Monster>());
        public static Room room9 = new Room(9, "room9", "Et dystert rum, hvor du får fornemmelsen af at blive iagttaget.", new List<Item>(), null, null, null, null, new List<Monster>());

         
         


        static int Main(string[] args)                                          ////// mine beskrivelse om Itme, Weapon og Monster!
        {
            Item key = new Item(1, "Nøgle", "en gammel rusten nøgle");
            room1.Items.Add(key);
            room1.Nord = room2;

            Weapon weapon = new Weapon(2, "Weapon", " en gammel weapon! ", 30, true, "død");
            room2.Items.Add(weapon);
            room2.Nord = room3;
            room2.Syd = room3;
            room2.Øst = room5;

            Item vand = new Item(3, "Vand", "En flaske med rent vand!");
            room3.Items.Add(vand);
            room3.Syd = room2;
            room3.Nord = room4;
            room3.Vest = room6;

            Monster dragon = new Monster(1, "Dragon", "Anmoodning med Dragon", 100, 10);
            room6.Monsters.Add(dragon);
            room6.Vest = room8;

             Item Helbredelsesdrik = new Item(4, "Helbrededelsesdrik", "En rød flaske, der giver liv");
            room4.Items.Add(Helbredelsesdrik);
            room4.Syd = room3;
            room4.Øst = room7;
            Item ring = new Item(5, "Ring", "En sort ring med et uhyggeligt skær");
            room5.Items.Add(ring);
            room5.Vest = room2;

            Weapon newWeapon = new Weapon(6, "New weapon", "den er en god og powerful weapon", 30, true, "død");
            room6.Items.Add(newWeapon);
            room5.Syd = room6;
            room6.Nord = room7;

            Item gyldenBlomst = new Item(7, "Gylden Blomst", "En sjælden blomst med en magiske glød");
            room7.Items.Add(gyldenBlomst);
            room7.Øst = room3;
            Item dragonEgg = new Item(8, "Dageæg", "Et strot æg, der føles varmt");
            room8.Items.Add(dragonEgg);
            room8.Nord = room5;
            Item book = new Item(9, "Magisk Bog", "En støbet bog fyldt med fortyllelser");
            room9.Items.Add(book);
            room8.Syd = room9;
            room9.Nord = room2;

            Monster Dragon2 = new Monster(1, "Big bear", "Anmoodning med Bjørn", 100, 10);
            room9.Monsters.Add(Dragon2);
            room9.Vest = room4;
           




        ///////////Atak plyer/////////////////////////
        ///
        //int Atak()
        //{
        //    if (Plyer.Takeweapon != null)
        //    {
        //        return Plyer.Takeweapon.Damage;
        //    }
        //    else
        //    {
        //        return 2;
        //    }
        //}

          
         
        ////////////////menu/////////////////////////////////
            Console.WriteLine("Welcomme til Dark room");
            Console.WriteLine("");
            Console.WriteLine("Du skal finde en våben! ");
            Console.WriteLine(" 'N' => Nord ");
            Console.WriteLine(" 'S' => Syd ");
            Console.WriteLine(" 'Ø' => Øst ");
            Console.WriteLine(" 'V' => Vest ");
            Console.WriteLine("");
 
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
            
            for ( int i = 0; i < CurrentRoom.Monsters.Count; i++)
            {
                Console.WriteLine(CurrentRoom.Monsters[i]);
            }

              ///// Naviger i roomet

            StringBuilder sb = new StringBuilder();

            if (CurrentRoom.Nord != null)
            {
                sb.AppendLine("Nord(N)");
            }
            if (CurrentRoom.Øst != null)
            {
                sb.AppendLine("Øst(Ø)");
            }
            if (CurrentRoom.Vest != null)
            {
                sb.AppendLine("Vest(V)");
            }
            if (CurrentRoom.Syd != null)
            {
                sb.AppendLine("Syd(S)");
            }
            
            Console.WriteLine("");
            sb.AppendLine("Klar til angrib (at)");
            sb.AppendLine("Skud (sk)");
            sb.AppendLine("Pick up Item (pu)");
            sb.AppendLine("Put down(pd)");
            sb.AppendLine("Kigge i din taske (i) ");
            Console.WriteLine("");
            Console.WriteLine(sb);



            //// switch cass giver en muligheder for at navege! 
            Console.WriteLine("Hvor skla du går: ");
            string vælge = Console.ReadLine().ToLower();
            string sa = vælge;

            if ( vælge.Length > 2)
            {
                sa = vælge.Substring(0, 2);
            }

            switch (sa)
                {
                    case "n":
                    if (CurrentRoom.Nord != null)
                    {

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

                    // her giver Inventory til Takweapon
                case "at":
                    int AtakWeapon = vælge.IndexOf(' ');
                    string TakWeapon = vælge.Substring(AtakWeapon + 1);
                    Console.WriteLine(TakWeapon);

                    for (int i = 0; i < Plyer.Inventory.Count; i++)
                    {  
                        if (TakWeapon.ToLower() == Plyer.Inventory[i].Name.ToLower())
                        {
                            Plyer.Takeweapon = (Weapon)Plyer.Inventory[i];
                            Console.WriteLine($"Du bruger {Plyer.Inventory[i].Name} til at angribe!");

                        }
                       
                    }
                    break;


                                        
                case "sk":
                      // Hivs der er en monster ind i roomet så skuder elles siger der ikke noget monster!
                    if (CurrentRoom.Monsters.Count != 0 )
                    {
                        if (Plyer.Takeweapon != null)
                        {
                            Console.WriteLine("Du angriber dragon!");
                            int skade = 20;


                            // dragon værdi bliver null så skriver død.
                            
                                CurrentRoom.Monsters[0].TakeDamage(skade);
                                 skade++;

                                Console.WriteLine($"Du angiriver dragen og giver {skade} skade! Dragon har nu {dragon.Health} health tilbage.");

                                if (CurrentRoom.Monsters[0].Health <= 0)
                                {
                                    Console.WriteLine($"Dragen er død");
                                    CurrentRoom.Monsters.RemoveAt(0);
                                }
                           
                        }
                        else
                        {
                            Console.WriteLine("Du har ikke noget våben!");

                        }

                    }
                    else
                    {
                        Console.WriteLine("Der er ikke monster!");
                    }




                    break;
                           //// her er tage Items player
                case "pu":
                    int spaceIndex = vælge.IndexOf(' ');
                    string ItemName = vælge.Substring(spaceIndex + 1);

                    for (int i = 0; i < CurrentRoom.Items.Count; i++)
                       {
                        if (CurrentRoom.Items[i].Name.ToLower() == ItemName)
                        {
                            Item pickedItem = CurrentRoom.Items[i];
                            CurrentRoom.Items.RemoveAt(i);
                            Console.WriteLine($"{pickedItem.Name} er nu taget");

                            Plyer.Inventory.Add(pickedItem);
                            
                        }
                       }
                    break;
                           //// viser hilken Item player har!
                case "i":

                    if (Plyer.Inventory.Count == 0)
                    {
                        Console.WriteLine("Nu har du en Items!");
                    }
                    else
                    {
                        for(int i = 0; i < Plyer.Inventory.Count; i++)
                        {
                            Console.WriteLine(Plyer.Inventory[i].Name);
                        }
                    }

                        break;
                                //// her sat ned Item
                case "pd":
                    int indexSpace = vælge.IndexOf(" ");
                    string ItemNavn = vælge.Substring(indexSpace + 1);

                    for(int i = 0; i < Plyer.Inventory.Count; i++)
                    {
                        if(Plyer.Inventory[i].Name.ToLower() == ItemNavn.ToLower())
                        {
                            Item putItem = Plyer.Inventory[i];
                            Plyer.Inventory.RemoveAt(i);
                            CurrentRoom.Items.Add(putItem);
                            Console.WriteLine($"{putItem.Name} er nu sat ned i {CurrentRoom.Name}!");
                        }
                    }
                    break;
                case "q":
                    Console.WriteLine("afslutte spillet (q)");

                    break;

                    default:
                        Console.WriteLine("Ugyldigt valg. prøv igen.");
                        break;

                }
              
                Thread.Sleep(1000);

            }


        }
    }



