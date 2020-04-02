using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatOrvosiNyilvantarto
{
    class Kutya : Allat
    {
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

		//TODO: Beadott oltások listája
	}
}
