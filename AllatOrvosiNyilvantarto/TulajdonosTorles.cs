using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllatOrvosiNyilvantarto.Classes;

namespace AllatOrvosiNyilvantarto
{
    public partial class TulajdonosTorles : Form
    {
        private uint ID = 0;
        public TulajdonosTorles(uint Id)
        {
            InitializeComponent();
            ID = Id;
        }

        private void btnNem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIgen_Click(object sender, EventArgs e)
        {
            if(Tulajdonosok.TulajdonosokLista.Count > 0)
            {
                foreach(Tulajdonos tulajdonos in Tulajdonosok.TulajdonosokLista)
                {
                    if(tulajdonos.Id == ID)
                    {
                        Tulajdonosok.TulajdonosTorles(tulajdonos);
                        MessageBox.Show("A tulajdonos sikeresen eltávolítva!", "Sikeres törlés");
                        this.Close();
                    }
                }
            }
        }
    }
}
