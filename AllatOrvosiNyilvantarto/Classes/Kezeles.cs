using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatOrvosiNyilvantarto
{
    class Kezeles
    {
		public Kezeles(uint Id, uint AllatId, DateTime Datum, string Leiras)
		{
			this.Id = Id;
			this.AllatId = AllatId;
			this.Datum = Datum;
			this.Leiras = Leiras;
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
		private uint allatId;

		public uint AllatId
		{
			get { return allatId; }
			set
			{
				if (value < 1)
					throw new Exception("Az állat azonosítója nem lehet 1-nél kisebb!");
				allatId = value;
			}
		}

		private DateTime datum;

		public DateTime Datum
		{
			get { return datum; }
			set
			{
				if (value == null)
					throw new Exception("A dátum nem lehet null!");
				datum = value;
			}
		}

		private string leiras;

		public string Leiras
		{
			get { return leiras; }
			set
			{
				if (value == null)
					throw new Exception("A leírás nem lehet null!");
				if (value.Length < 1)
					throw new Exception("A leírás hossza minimum 1 karakter kell hogy legyen!");
				leiras = value;
			}
		}

	}
}
