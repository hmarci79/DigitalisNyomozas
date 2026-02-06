using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Idovonal
	{
		private int ev;
		private int honap;
		private int nap;
		private string leiras;

		public Idovonal(int ev, int honap, int nap, string leiras)
		{
			this.ev = ev;
			this.honap = honap;
			this.nap = nap;
			this.leiras = leiras;
		}

		public int Ev { get => ev; set => ev = value; }
		public int Honap { get => honap; set => honap = value; }
		public int Nap { get => nap; set => nap = value; }
		public string Leiras { get => leiras; set => leiras = value; }

		public override string ToString()
		{
			return $"{this.ev}.{this.honap}.{this.nap}: {this.leiras}";
		}
	}
}
