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
    public partial class TulajdonosMegtekintes : Form
    {
        public TulajdonosMegtekintes(int Id)
        {
            InitializeComponent();

            foreach(Tulajdonos tulajdonos in Tulajdonosok.TulajdonosokLista)
            {
                if(tulajdonos.Id == Id)
                {
                    lblId.Text = tulajdonos.Id.ToString();
                    lblVnev.Text = tulajdonos.Vnev;
                    lblKnev.Text = tulajdonos.Knev;
                    lblSzulDatum.Text = tulajdonos.SzulDatum.ToString("yyyy.mm.dd");
                    lblIrszam.Text = tulajdonos.Irszam;
                    lblVaros.Text = tulajdonos.Varos;
                    lblLakcim.Text = tulajdonos.Lakcim;
                    lblMobilSzam.Text = tulajdonos.MobilSzam;
                    lblEmail.Text = tulajdonos.Email == null ? "-" : tulajdonos.Email;
                }
            }
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModositas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módosító ablak!");
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Törlés visszakérdezés!");
        }
    }
}
