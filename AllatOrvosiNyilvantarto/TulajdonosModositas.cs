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
    public partial class TulajdonosModositas : Form
    {
        private bool MegfeleloAdatok = false;
        private uint ID = 0;
        public TulajdonosModositas(uint Id)
        {
            InitializeComponent();

            if(Tulajdonosok.TulajdonosokLista.Count > 0)
            {
                foreach(Tulajdonos tulajdonos in Tulajdonosok.TulajdonosokLista)
                {
                    if(tulajdonos.Id == Id)
                    {
                        tbVnev.Text = tulajdonos.Vnev;
                        tbKnev.Text = tulajdonos.Knev;
                        dtpSzulDatum.Value = tulajdonos.SzulDatum;
                        tbIrszam.Text = tulajdonos.Irszam;
                        tbVaros.Text = tulajdonos.Varos;
                        tbLakcim.Text = tulajdonos.Lakcim;
                        tbMobilSzam.Text = tulajdonos.MobilSzam;
                        tbEmail.Text = tulajdonos.Email;
                        ID = tulajdonos.Id;
                    }
                }
            }
        }

        private void AdatokMentese(uint Id)
        {
            if(Tulajdonosok.TulajdonosokLista.Count > 0)
            {
                foreach (Tulajdonos tulajdonos in Tulajdonosok.TulajdonosokLista)
                {
                    if(tulajdonos.Id == Id)
                    {
                        try
                        {
                            tulajdonos.Vnev = tbVnev.Text;
                            tulajdonos.Knev = tbKnev.Text;
                            tulajdonos.SzulDatum = dtpSzulDatum.Value;
                            tulajdonos.Irszam = tbIrszam.Text;
                            tulajdonos.Varos = tbVaros.Text;
                            tulajdonos.Lakcim = tbLakcim.Text;
                            tulajdonos.MobilSzam = tbMobilSzam.Text;
                            tulajdonos.Email = tbEmail.Text;
                            MegfeleloAdatok = true;
                        }
                        catch (Exception ex)
                        {
                            MegfeleloAdatok = false;
                            MessageBox.Show(ex.Message, "Sikertelen módosítás");
                        }
                    }
                }
            }
        }

        private void btnMegse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            AdatokMentese(ID);
            if (MegfeleloAdatok)
            {
                MessageBox.Show("A tulajdonos adatai módosítva lettek!","Sikeres módosítás");
                this.Close();
            }
        }
    }
}
