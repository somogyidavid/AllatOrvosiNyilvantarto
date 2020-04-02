using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatOrvosiNyilvantarto
{
    class Oltas
    {
		public Oltas(uint Id, string Nev, OltasAllat Allat)
		{
			this.Id = Id;
			this.Nev = Nev;
			this.Allat = Allat;
		}

		private uint id;

		public uint Id
		{
			get { return id; }
			set
			{
				if (value < 1)
					throw new Exception("Az azonosító nem lehet 1-nél kisebb!");
				id = value;
			}
		}
		private string nev;

		public string Nev
		{
			get { return nev; }
			set
			{
				if (value == null)
					throw new Exception("A név nem lehet null!");
				if (value.Length < 1)
					throw new Exception("A név hossza legalább 1!");
				nev = value;
			}
		}

		public OltasAllat Allat { get; set; }
	}
}
