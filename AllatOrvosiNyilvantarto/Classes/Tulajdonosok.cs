using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace AllatOrvosiNyilvantarto.Classes
{
    static class Tulajdonosok
    {
		private static uint ID = 0;

		private static List<Tulajdonos> tulajdonosok = new List<Tulajdonos>();

		public static List<Tulajdonos> TulajdonosokLista
		{
			get { return new List<Tulajdonos>(tulajdonosok); }
		}

		public static void TulajdonosFelvetele(string Vnev, string Knev, DateTime SzulIdo, string Irszam, string Varos, string Lakcim, string MobilSzam)
		{
			tulajdonosok.Add(new Tulajdonos(++ID, Vnev, Knev, SzulIdo, Irszam, Varos, Lakcim, MobilSzam));
		}
		public static void TulajdonosFelvetele(string Vnev, string Knev, DateTime SzulIdo, string Irszam, string Varos, string Lakcim, string MobilSzam, string Email)
		{
			tulajdonosok.Add(new Tulajdonos(++ID, Vnev, Knev, SzulIdo, Irszam, Varos, Lakcim, MobilSzam, Email));
		}
		public static void TulajdonosTorles(Tulajdonos tulajdonos)
		{
			tulajdonosok.Remove(tulajdonos);
		}
	}
}
