using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaszinó
{
    public class KaszinoJatekok
    {
        
        //BlackJackhez kellő random választó
        public static int Dobas()
        {
            Random random = new Random();
            return random.Next(1, 12);
        }
        public static void Blackjack(Jatekos jatekos)
        {
            bool b = true;
            while (b = true)
            {
               
                Console.WriteLine("Üdvözöljük a Blackjack játékban!");
                Console.WriteLine($"Játékos neve: {jatekos.GetNev()}");
                Console.WriteLine($"Játékos zsetonja: {jatekos.GetZseton()}");

                //BlackJack logikai része
                int lap1 = Dobas();
                int lap2 = Dobas();

                Console.WriteLine($"Lapok: {lap1}, {lap2}");

                int osszeg = lap1 + lap2;
                Console.WriteLine($"Összeg: {osszeg}");

                while (osszeg < 21)
                {
                    Console.Write("Eldobod vagy húzol egy újabb lapot? (dob/húz): ");
                    string valasz = Console.ReadLine();

                    if (valasz.ToLower() == "húz")
                    {
                        int ujLap = Dobas();
                        Console.WriteLine($"Új lap: {ujLap}");
                        osszeg += ujLap;
                        Console.WriteLine($"Összeg: {osszeg}");
                    }
                    else if (valasz.ToLower() == "dob")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Érvénytelen válasz. Kérem, adjon meg egy érvényes választ.");
                    }
                    Console.WriteLine($"Végső összeg: {osszeg}");
                }


                Console.WriteLine("Folytatod vagy kilépsz?(igen/nem)");
                string valasz1 = Console.ReadLine();
                if (valasz1 == "igen")
                {
                    Blackjack(jatekos);
                }
                else
                {


                    Console.WriteLine($"Játékos új zsetonja: {jatekos.GetZseton()}");
                    Console.WriteLine("Köszönjük, hogy játszottál a Blackjack játékban!");




                }
            }
            

            Console.WriteLine($"Játékos új zsetonja: {jatekos.GetZseton()}");
            Console.WriteLine("Köszönjük, hogy játszottál a Blackjack játékban!");
        }

        public static void Rulett(Jatekos jatekos)
        {
            Console.WriteLine("Üdvözöljük a Rulett játékban!");
            Console.WriteLine($"Játékos neve: {jatekos.GetNev()}");
            Console.WriteLine($"Játékos zsetonja: {jatekos.GetZseton()}");
            //Rulett logikai része
            bool a = true;
            while (a = true)
            {
                Console.WriteLine("Válasszon egy számot (1-36): ");
                int szamValasz;
                while (!int.TryParse(Console.ReadLine(), out szamValasz) || szamValasz < 1 || szamValasz > 36)
                {
                    Console.WriteLine("Érvénytelen választás. Kérem, adjon meg egy érvényes számot.");
                }

                Console.WriteLine("Tegye meg a tétjét: ");
                int tet;
                while (!int.TryParse(Console.ReadLine(), out tet) || tet <= 0 || tet > jatekos.GetZseton())
                {
                    Console.WriteLine("Érvénytelen tét. Kérem, adjon meg egy érvényes tétet.");
                }

                int nyerosSzam = SorsolNyerosSzam();

                Console.WriteLine($"A rulett kereke megállt a {nyerosSzam} számon.");

                if (nyerosSzam == szamValasz)
                {
                    Console.WriteLine($"Gratulálunk, nyertél! Nyereményed: {tet * 36} zseton.");
                    jatekos.NovelZseton(tet * 36);
                }
                else
                {
                    Console.WriteLine("Sajnáljuk, nem nyertél.");
                    jatekos.CsokkentZseton(tet);
                }

                Console.WriteLine("Folytatod vagy kilépsz?(igen/nem)");
                string valasz1= Console.ReadLine();
                if (valasz1 == "igen") 
                {
                    Rulett(jatekos);
                }
                else 
                {


                    Console.WriteLine($"Játékos új zsetonja: {jatekos.GetZseton()}");
                    Console.WriteLine("Köszönjük, hogy játszottál a Rulett játékban!");

                    a = false;


                }
            }

           
        }
        //ruletthez randomizálás
        private static int SorsolNyerosSzam()
        {
            Random random = new Random();
            return random.Next(1, 37);
        }


    }
    
}

      
        
   
