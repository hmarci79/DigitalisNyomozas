using System.Security.Cryptography;

namespace DigitalisNyomozas
{
    internal class Program
    {
        static void UgyKezeles(UgyKezelo uk, Adattar a1)
        {
			Console.WriteLine("1. Ügy hozzáadása\n2. Személy hozzáadása\n3. Bizonyíték hozzáadása\n4. Állapot módosítása\n5. Ügyek kiírása\n6. Vissza");
			int vUgy = Convert.ToInt32(Console.ReadLine());
			switch (vUgy)
            {
                case 1:
                    UgyHAdas(uk, a1);
                    break;
                case 2:
                    SzHAdas(uk, a1);
                    break;
                case 3:
                    BHAdas(uk, a1);
                    break;
                case 4:
                    AllMod(a1);
                    break;
                case 5:
                    Console.WriteLine(a1.UgyKiiras());
                    break;
                case 6:
                    break;
            }

        }

        static void UgyHAdas(UgyKezelo uk, Adattar a1)
        {
			Console.WriteLine("Adja meg az ügy azonosítóját!\t");
            int azonosito = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Adja meg az ügy címét!\t");
            string cim = Console.ReadLine();
            Console.WriteLine("Adja meg az ügy leírását!\t");
            string leiras = Console.ReadLine();
			Console.WriteLine("Adja meg az ügy állapotát!\t");
            string allapot = Console.ReadLine();
            Ugy u = new Ugy(azonosito, cim, leiras, allapot);
            uk.UjUgy(u);
            a1.Ugyek.Add(u);
        }

        static void SzHAdas(UgyKezelo uk, Adattar a1)
        {
            if (a1.Szemelyek.Count() == 0)
            {
				Console.WriteLine("Nincs hozzáadható személy.");
            }
            else if (a1.Ugyek.Count() == 0)
            {
				Console.WriteLine("Nincsen ügy, amihez hozzá lehetne adni.");
            }
            else
            {
                Console.WriteLine($"Ügyek, amikhez hozzá lehet adni:\n{a1.UgyKiiras()}");
                int ui = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Hozzáadható személyek:\n{a1.SzemelyKiiras()}");
                int szi = Convert.ToInt32(Console.ReadLine());
                uk.SzemelyHozzadas(a1.Ugyek[ui-1], a1.Szemelyek[szi-1]);
            }
            
        }

		static void BHAdas(UgyKezelo uk, Adattar a1)
		{
			if (a1.Bizonyitekok.Count() == 0)
			{
				Console.WriteLine("Nincs hozzáadható bizonyíték.");
			}
			else if (a1.Ugyek.Count() == 0)
			{
				Console.WriteLine("Nincsen ügy, amihez hozzá lehetne adni.");
			}
			else
			{
				Console.WriteLine($"Ügyek, amikhez hozzá lehet adni:\n{a1.UgyKiiras()}");
				int ui = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine($"Hozzáadható bizonyítékok:\n{a1.BizonyitekKiiras()}");
				int bi = Convert.ToInt32(Console.ReadLine());
				uk.BizonyitekHozzadas(a1.Ugyek[ui - 1], a1.Bizonyitekok[bi - 1]);
			}

		}

        static void AllMod(Adattar a1)
        {
			if (a1.Ugyek.Count() == 0)
            {
				Console.WriteLine("Nincsen ügy, amiben állapotmódosítást lehetne végrehajtani.");
            }
            else
            {
				Console.WriteLine($"Ügyek, amikben módosítani lehet az állapotot:\n{a1.UgyKiiras()}");
				int ui = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Mire szeretné megváltoztatni az állapotot?");
                string x = Console.ReadLine();
                if (x == a1.Ugyek[ui-1].Allapot)
                {
                    Console.WriteLine("Ugyanez a jelenlegi állapot is.");
                }
                else
                {
                    a1.Ugyek[ui-1].UgyAllapota(x);
                    Console.WriteLine("Sikeres módosítás!");
                }
            }

		}

		static void Main(string[] args)
        {
            Adattar a1 = new Adattar();
			UgyKezelo uk = new UgyKezelo();

			int valasztas = 0;
            do
            {
				Console.WriteLine("1. Ügyek kezelése\n2. Személyek kezelése\n3. Bizonyítékok kezelése\n4. Idővonal megtekintése\n5. Elemzés / döntések\n6. Kilépés");
                valasztas = Convert.ToInt32(Console.ReadLine());
                switch (valasztas)
                {
                    case 1: 
                        UgyKezeles(uk, a1);
                        break;
                }
            }
            while (valasztas != 6);
        }
    }
}
