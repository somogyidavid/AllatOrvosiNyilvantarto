using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatOrvosiNyilvantarto
{
    class Kutya : Allat
    {
		public Kutya(uint Id, string Nev, DateTime SzulDatum, AllatNem Nem, bool Ivartalanitva, List<Kezeles> Kezelesek, string Fajta, bool VanChipje, string ChipAzonosito, List<Oltas> BeadottOltasok)
			:base(Id, Nev, SzulDatum, Nem, Ivartalanitva, Kezelesek)
		{
			this.Fajta = Fajta;
			this.VanChipje = VanChipje;
			this.ChipAzonosito = ChipAzonosito;
			this.BeadottOltasok = BeadottOltasok;
		}

		private string fajta;

		public string Fajta
		{
			get { return fajta; }
			set
			{
				if (value == null)
					throw new Exception("A fajta nem lehet null!");
				if (value.Length < 1)
					throw new Exception("A fajta hossza legalább 1 karakter!");
				fajta = value;
			}
		}

		private bool vanChipje;

		public bool VanChipje
		{
			get { return vanChipje; }
			set
			{
				if (chipAzonosito == null)
				{
					vanChipje = value;
				}
				else throw new Exception("Nem lehet megváltoztatni!");
			}
		}

		private string chipAzonosito;

		public string ChipAzonosito
		{
			get { return chipAzonosito; }
			set
			{
				if (VanChipje)
				{
					if (value.Length == 15 && value.StartsWith("348"))
						chipAzonosito = value;
					else throw new Exception("Nem megfelelő chip azonosító formátum!");
				}
			}
		}

		private List<Oltas> beadottOltasok;

		public List<Oltas> BeadottOltasok
		{
			get
			{
				return new List<Oltas>(beadottOltasok);
			}
			private set
			{
				beadottOltasok = value;
			}
		}
	}
}
