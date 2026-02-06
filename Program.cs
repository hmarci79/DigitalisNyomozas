using System.Security.Cryptography;

namespace DigitalisNyomozas
{
    internal class Program
    {
        static void UgyKezeles(UgyKezelo uk, Adattar a1)
        {
			Console.WriteLine("1. Ügy létrehozása\n2. Személy hozzáadása\n3. Bizonyíték hozzáadása\n4. Állapot módosítása\n5. Ügyek kiírása\n6. Vissza");
			int vUgy = Convert.ToInt32(Console.ReadLine());
			switch (vUgy)
            {
                case 1:
                    UgyLetrehozas(uk, a1);
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

        static void UgyLetrehozas(UgyKezelo uk, Adattar a1)
        {
            bool letezik = false;
			Console.WriteLine("Adja meg az ügy azonosítóját!\t");
            int azonosito = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Adja meg az ügy címét!\t");
            string cim = Console.ReadLine();
            Console.WriteLine("Adja meg az ügy leírását!\t");
            string leiras = Console.ReadLine();
			Console.WriteLine("Adja meg az ügy állapotát!\t");
            string allapot = Console.ReadLine();
            Ugy u = new Ugy(azonosito, cim, leiras, allapot);
            foreach (var item in uk.Ugyek)
            {
                if (item.Azonosito == u.Azonosito)
                {
					letezik = true;
                }
            }
            if (letezik)
            {
				Console.WriteLine("Már létezik ügy, ezzel az azonosítóval.");
            }
            else
            {
                uk.UjUgy(u);
                a1.Ugyek.Add(u);
				Console.WriteLine("Ügy hozzáadva!");
            }
                
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

		static void SzKezeles(UgyKezelo uk, Adattar a1)
		{
			Console.WriteLine("1. Személy létrehozása\n2. Személy hozzáadása ügyhöz\n3. Személyek kiiratása\n4. Vissza");
            int vSz = Convert.ToInt32(Console.ReadLine());
            switch (vSz)
            {
                case 1:
                    SzLetrehozas(a1);
                    break;
                case 2:
                    SzHAdas(uk, a1);
                    break;
                case 3:
					Console.WriteLine(a1.SzemelyKiiras());
                    break;
                case 4:
                    break;
            }
		}

        static void SzLetrehozas(Adattar a1)
        {
			Console.WriteLine("Adja meg a személy nevét!\t");
            string nev = Console.ReadLine();
			Console.WriteLine("Adja meg a személy életkorát!\t");
            int kor = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Adjon meg egy megjegyzést ehhez a személyhez!\t");
            string megjegyzes = Console.ReadLine();
            Szemely sz = new Szemely(nev, kor, megjegyzes);
            a1.Szemelyek.Add(sz);
			Console.WriteLine("Személy hozzáadva!");
        }

        static void BKezeles(UgyKezelo uk, Adattar a1, BizonyitekKezelo b1)
        {
            Console.WriteLine("1. Bizonyíték rögzítése\n2. Bizonyíték hozzáadása ügyhöz\n3. Bizonyítékok kiiratása\n4. Vissza");
			int vB = Convert.ToInt32(Console.ReadLine());
			switch (vB)
			{
				case 1:
					bLetrehozas(a1, b1);
					break;
				case 2:
					BHAdas(uk, a1);
					break;
				case 3:
					Console.WriteLine(a1.BizonyitekKiiras());
					break;
				case 4:
					break;
			}
		}

        static void bLetrehozas(Adattar a1, BizonyitekKezelo b1)
        {
            bool letezik = false;
			Console.WriteLine("Adja meg a bizonyíték azonosítóját!\t");
            int azonosito = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Adja meg a bizonyíték típusát!\t");
            string tipus = Console.ReadLine();
			Console.WriteLine("Adja meg a bizonyíték leírását!\t");
            string leiras = Console.ReadLine();
			Console.WriteLine("Adja meg a bizonyíték megbízhatóságát!\t");
            int megbizhatosag = Convert.ToInt32(Console.ReadLine());
            Bizonyitek b = new Bizonyitek(azonosito, tipus, leiras, megbizhatosag);
			foreach (var item in a1.Bizonyitekok)
			{
				if (item.Azonosito == b.Azonosito)
				{
					letezik = true;
				}
			}
			if (letezik)
			{
				Console.WriteLine("Már létezik bizonyíték, ezzel az azonosítóval.");
			}
			else
			{
				b1.Bizonyitekok.Add(b);
				a1.Bizonyitekok.Add(b);
				Console.WriteLine("Bizonyíték hozzáadva!");
			}
        }

		static void Main(string[] args)
        {
            Adattar a1 = new Adattar();
			UgyKezelo uk = new UgyKezelo();
            BizonyitekKezelo b1 = new BizonyitekKezelo();

			int valasztas = 0;
            do
            {
				Console.WriteLine("1. Ügyek kezelése\n2. Személyek kezelése\n3. Bizonyítékok kezelése\n4. Idővonal megtekintése\n5. Elemzés / Döntések\n6. Kilépés");
                valasztas = Convert.ToInt32(Console.ReadLine());
                switch (valasztas)
                {
                    case 1: 
                        UgyKezeles(uk, a1);
                        break;
                    case 2:
                        SzKezeles(uk, a1);
                        break;
                    case 3:
                        BKezeles(uk, a1, b1);
                        break;
                }
            }
            while (valasztas != 6);
        }
    }
}
