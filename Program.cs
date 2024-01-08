namespace Kaszinó
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Üdvözöljük a kaszinóban!");
            Console.Write("Kérem, adja meg a játékos nevét: ");
            string nev = Console.ReadLine();

            Console.Write("Kérem, adja meg a kezdeti zseton mennyiségét: ");
            int kezdoZseton = int.Parse(Console.ReadLine());

            Jatekos jatekos = new Jatekos(nev, kezdoZseton);

            Console.WriteLine($"Szia {jatekos.GetNev()}! Kezdeti zsetonod: {jatekos.GetZseton()}");

            Console.WriteLine("Válassz játékot:");
            Console.WriteLine("1. Blackjack");
            Console.WriteLine("2. Rulett");

            int valasztas = int.Parse(Console.ReadLine());

            switch (valasztas)
            {
                case 1:
                    KaszinoJatekok.Blackjack(jatekos);
                    break;
                case 2:
                    KaszinoJatekok.Rulett(jatekos);
                    break;
                default:
                    Console.WriteLine("Érvénytelen választás.");
                    break;
            }

            Console.WriteLine($"Köszönjük, hogy játszottál a kaszinóban, {jatekos.GetNev()}!");
            Console.WriteLine($"Végleges zseton mennyiség: {jatekos.GetZseton()}");
        }
    }
}
