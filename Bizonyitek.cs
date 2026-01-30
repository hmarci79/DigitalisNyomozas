using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Bizonyitek
	{
		private int azonosito;
		private string tipus;
		private string leiras;
		private int megbizhatosag;

		public Bizonyitek(int azonosito, string tipus, string leiras, int megbizhatosag)
		{
			this.azonosito = azonosito;
			this.tipus = tipus;
			this.leiras = leiras;
			this.megbizhatosag = megbizhatosag;
		}

		public int Azonosito { get => azonosito; set => azonosito = value; }
		public string Tipus { get => tipus; set => tipus = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public int Megbizhatosag { get => megbizhatosag; set => megbizhatosag = value; }

		public override string ToString()
		{
			return $"{this.azonosito} ({this.tipus}): {this.leiras}\n\tMegbízhatóság: {this.megbizhatosag}";
		}
	}
}
