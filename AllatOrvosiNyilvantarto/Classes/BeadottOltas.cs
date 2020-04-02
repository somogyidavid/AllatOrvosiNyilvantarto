using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatOrvosiNyilvantarto
{
    class BeadottOltas
    {
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
		private Oltas oltas;

		public Oltas Oltas
		{
			get { return oltas; }
			set
			{
				if (value == null)
					throw new Exception("Az oltás nem lehet null!");
				oltas = value;
			}
		}
		private uint  allatId;

		public uint  AllatId
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
	}
}
