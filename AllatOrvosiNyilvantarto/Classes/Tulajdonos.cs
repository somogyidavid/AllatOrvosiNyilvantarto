using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace AllatOrvosiNyilvantarto
{
	class Tulajdonos
	{
		public Tulajdonos(uint Id, string Vnev, string Knev, DateTime SzulDatum, string Irszam, string Varos, string Lakcim, string MobilSzam)
		{
			this.Id = Id;
			this.Vnev = Vnev;
			this.Knev = Knev;
			this.SzulDatum = SzulDatum;
			this.Irszam = Irszam;
			this.Varos = Varos;
			this.Lakcim = Lakcim;
			this.MobilSzam = MobilSzam;
		}
		public Tulajdonos(uint Id, string Vnev, string Knev, DateTime SzulDatum, string Irszam, string Varos, string Lakcim, string MobilSzam, MailAddress Email)
			:this(Id, Vnev, Knev, SzulDatum, Irszam, Varos, Lakcim, MobilSzam)
		{
			this.Email = Email;
		}

		private uint id;

		public uint Id
		{
			get { return id; }
			set
			{
				if (value < 1)
					throw new Exception("Az azonosító nem lehet 0-nál kisebb!");
				id = value;
			}
		}
		private string vnev;

		public string Vnev
		{
			get { return vnev; }
			set
			{
				if (value == null)
					throw new Exception("A vezetéknév nem lehet null!");
				if (value.Length < 1)
					throw new Exception("A vezetéknév hossza legalább 1!");
				vnev = value;
			}
		}
		private string knev;

		public string Knev
		{
			get { return knev; }
			set
			{
				if (value == null)
					throw new Exception("A keresztnév nem lehet null!");
				if (value.Length < 1)
					throw new Exception("A keresztnév hossza legalább 1!");
				knev = value;
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
				if (value > DateTime.Today)
					throw new Exception("A születési dátum nem megfelelő!");
				szulDatum = value;
			}
		}
		private string irszam;

		public string Irszam
		{
			get { return irszam; }
			set
			{
				if (value == null)
					throw new Exception("A keresztnév nem lehet null!");
				if (value.Length != 4)
					throw new Exception("Az irányítószám pontosan 4 karakter kell hogy legyen!");
				if (!value.All(char.IsDigit))
					throw new Exception("Nem megfelelő irányítószám formátum!");
				irszam = value;
			}
		}
		private string varos;

		public string Varos
		{
			get { return varos; }
			set
			{
				if (value == null)
					throw new Exception("A város nem lehet null!");
				if (value.Length < 1)
					throw new Exception("A város hossza legalább 1!");
				varos = value;
			}
		}
		private string lakcim;

		public string Lakcim
		{
			get { return lakcim; }
			set
			{
				if (value == null)
					throw new Exception("A lakcím nem lehet null!");
				if (value.Length < 1)
					throw new Exception("A lakcím hossza legalább 1!");
				lakcim = value;
			}
		}

		private string mobilSzam;

		public string MobilSzam
		{
			get { return mobilSzam; }
			set
			{
				if (value == null)
					throw new Exception("A mobilszám nem lehet null!");
				value = value.Trim('-', ' ');
				if(!value.StartsWith("+36") || !value.StartsWith("06"))
					throw new Exception("Hibás telefonszám formátum!");
				if (value.StartsWith("+36") && value.Length != 12)
					throw new Exception("Hibás telefonszám formátum!");
				else if (value.StartsWith("06") && value.Length != 11)
					throw new Exception("Hibás telefonszám formátum!");
				mobilSzam = value;
			}
		}
		private MailAddress email;

		public MailAddress Email
		{
			get { return email; }
			set
			{
				try
				{
					MailAddress MA = new MailAddress(value.ToString());
					email = value;
				}
				catch (FormatException)
				{
					throw new Exception("Nem megfelelő email formátum!");
				}
			}
		}

		//TODO: Állatok lista
	}
}