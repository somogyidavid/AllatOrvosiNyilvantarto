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
    public partial class TulajdonosFelvetel : Form
    {
        public TulajdonosFelvetel()
        {
            InitializeComponent();
        }

        private void btnTulajdonosFelvetel_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == string.Empty)
            {
                try
                {
                    Tulajdonosok.TulajdonosFelvetele(tbVnev.Text, tbKnev.Text, dtpSzulDatum.Value, tbIrszam.Text, tbVaros.Text,
                        tbLakcim.Text, tbMobilSzam.Text);
                    MessageBox.Show("A tulajdonos mentésre került!", "Sikeres mentés");
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message,"Sikertelen mentés");
                }
            }
            else
            {
                try
                {
                    Tulajdonosok.TulajdonosFelvetele(tbVnev.Text, tbKnev.Text, dtpSzulDatum.Value, tbIrszam.Text, tbVaros.Text,
                        tbLakcim.Text, tbMobilSzam.Text, tbEmail.Text);
                    MessageBox.Show("A tulajdonos mentésre került!", "Sikeres mentés");
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message,"Sikertelen mentés");
                }
            }
        }
    }
}
