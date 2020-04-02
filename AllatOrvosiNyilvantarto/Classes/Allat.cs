using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatOrvosiNyilvantarto
{
    abstract class Allat
    {
		public Allat(uint Id, string Nev, DateTime SzulDatum, AllatNem Nem, bool Ivartalanitva, List<Kezeles> Kezelesek)
		{
			this.Id = Id;
			this.Nev = Nev;
			this.SzulDatum = SzulDatum;
			this.Nem = Nem;
			this.Ivartalanitva = Ivartalanitva;
			this.Kezelesek = Kezelesek;
		}

		private uint id;

		public uint Id
		{
			get { return id; }
			set
			{
				if (value < 1)
					throw new Exception("Az azonosító nem lehet kisebb mint 1!");
				id = value;
			}
		}
		private string  nev;

		public string  Nev
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

		private DateTime szulDatum;

		public DateTime SzulDatum
		{
			get { return szulDatum; }
			set
			{
				if (value == null)
					throw new Exception("A születési dátum nem lehet null!");
				szulDatum = value;
			}
		}
		public AllatNem Nem { get; set; }

		private bool Valtoztatva = false;
		private bool ivartalanitva;

		public bool Ivartalanitva
		{
			get { return ivartalanitva; }
			set
			{
				if (!Valtoztatva)
				{
					ivartalanitva = value;
					Valtoztatva = true;
				}
				else throw new Exception("Az érték már meg lett változtatva!");
			}
		}

		private List<Kezeles> kezelesek;

		public List<Kezeles> Kezelesek
		{
			get
			{
				return new List<Kezeles>(kezelesek);
			}
			private set
			{
				kezelesek = value;
			}
		}

	}
}
