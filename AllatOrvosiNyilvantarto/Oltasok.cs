using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatOrvosiNyilvantarto
{
    class Oltasok
    {
        private static uint ID = 0;
        private List<Oltas> oltasok;

        public void OltasokFeltoltese()
        {
            oltasok = new List<Oltas>();

            oltasok.Add(new Oltas(++ID, "6 hetes: Parvo + szopornyica",OltasAllat.KUTYA));
            oltasok.Add(new Oltas(++ID, "12 hetes: Parvo + szopornyica + leptospira + májgyulladás", OltasAllat.KUTYA));
            oltasok.Add(new Oltas(++ID, "16 hetes: Veszettség oltás", OltasAllat.KUTYA));
            oltasok.Add(new Oltas(++ID, "1 éves: Veszettség oltás", OltasAllat.MACSKA));
            oltasok.Add(new Oltas(++ID, "1 éves: Veszettség oltás", OltasAllat.KUTYA));
        }

        public List<Oltas> OltasokLista
        {
            get
            {
                return new List<Oltas>(this.oltasok);
            }
        }
    }
}
