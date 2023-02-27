string[] ovi = new string[4] { "Auki", "Kiinni", "Lukossa", "Avaa lukko"  };

Ovi Oventilat;

Oventilat = Ovi.Auki;

while (true)
{
    if (Oventilat == Ovi.Auki)
    {


        Console.WriteLine("Ovi on auki. Mitä haluat tehdä?");
        string Vastaus = Console.ReadLine();

        if (Vastaus == ovi[1])
        {
            Console.WriteLine("Ovi on nyt kiinni. Mitä haluat tehdä?");
            Vastaus = Console.ReadLine();

            if (Vastaus == ovi[0])
            {
                Console.WriteLine("Ovi on auki. Mitä haluat tehdä?");
                Vastaus = Console.ReadLine();

            }
            else if (Vastaus == ovi[2])
            {
                Console.WriteLine("Ovi on lukossa. Mitä haluat tehdä?");
                Vastaus = Console.ReadLine();

                if (Vastaus == ovi[3])
                {
                    Console.WriteLine("Oven lukko on nyt avattu ja ovi on nyt vain kiinni. Mitä haluat tehdä?");
                    Vastaus = Console.ReadLine();
                    if (Vastaus == ovi[0])
                    {
                        Console.WriteLine("Ovi on auki. Mitä haluat tehdä?");
                        Vastaus = Console.ReadLine();
                    }
                    else if (Vastaus == ovi[2])
                    {
                        Console.WriteLine("Ovi on lukossa. Mitä haluat tehdä?");
                        Vastaus = Console.ReadLine();
                    }


                }





            }




        }
    }
}


enum Ovi { Auki, Kiinni, Lukossa, avaa_lukko  };


