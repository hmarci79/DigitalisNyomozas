using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class UgyKezelo
	{
		private List<Ugy> ugyek;

		public UgyKezelo()
		{
			this.ugyek = new List<Ugy>();
		}

		internal List<Ugy> Ugyek { get => ugyek; set => ugyek = value; }

		public void UjUgy(Ugy u)
		{
			this.ugyek.Add(u);
		}

		public void SzemelyHozzadas(Ugy u, Szemely s)
		{
			u.UgyesSzemelyek.Add(s);
		}

		public void BizonyitekHozzadas(Ugy u, Bizonyitek b)
		{
			u.UgyesBizonyitekok.Add(b);
		}

		public void EsemenyekHozzadas(Ugy u, Idovonal e)
		{
			u.UgyesIdovonal.Add(e);
		}

		public override string ToString()
		{
			string s = "";
			foreach (var item in ugyek)
			{
				s += item.ToString()+"\n";
			}
			return s;
		}
	}
}
