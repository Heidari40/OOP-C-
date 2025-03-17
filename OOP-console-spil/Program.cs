using System;


namespace OOP_console_spil
{
    internal class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcomme til Dark room");
            Console.WriteLine("Du skal finde en våben! ");
            Console.WriteLine(" 'N' => Nord ");
            Console.WriteLine(" 'S' => Syd ");
            Console.WriteLine(" 'Ø' => Øst ");
            Console.WriteLine(" 'V' => Vest ");
            Room CurrentRoom = Service.CurrentRoom;


            while (true)
            {
                Console.WriteLine(CurrentRoom.ToString());

                Console.WriteLine("Hvor skla du går: ");
                string vælge = Console.ReadLine().ToLower();

                switch (vælge)
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
                            Console.WriteLine("Der er ingen vej mod nord");
                        }

                        break;

                    case "ø":
                        if (CurrentRoom.Øst != null)
                        {

                            CurrentRoom = CurrentRoom.Øst;
                        }
                        else
                        {
                            Console.WriteLine("Der er ingen vej mod nord");
                        }

                        break;

                    case "v":
                        if (CurrentRoom.Vest != null)
                        {

                            CurrentRoom = CurrentRoom.Vest;
                        }
                        else
                        {
                            Console.WriteLine("Der er ingen vej mod nord");
                        }

                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg. prøv igen.");
                        break;

                }

            }


        }
    }
}


