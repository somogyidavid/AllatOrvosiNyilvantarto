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
    public partial class Form1 : Form
    {
        private bool SelectionChangedByMe = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void tulajdonosokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TulajdonosFelvetel TF = new TulajdonosFelvetel();
            TF.ShowDialog();
        }

        private void összesTulajdonosListázásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tulajdonosok.TulajdonosokLista.Count > 0)
            {
                TulajdonosokDGVLetrehozas();
                TulajdonosokFeltoltese();
            }
            else MessageBox.Show("A lista üres!","Hiba");
        }

        public void TulajdonosokDGVLetrehozas()
        {
            dgvTulajdonosok.Columns.Add("Id", "Azonosító");
            dgvTulajdonosok.Columns.Add("Vnev", "Vezetéknév");
            dgvTulajdonosok.Columns.Add("Knev", "Keresztnév");
            dgvTulajdonosok.Columns.Add("SzulDatum", "Születési dátum");
            dgvTulajdonosok.Columns.Add("Irszam", "Irányítószám");
            dgvTulajdonosok.Columns.Add("Varos", "Város");
            dgvTulajdonosok.Columns.Add("Lakcim", "Lakcím");
            dgvTulajdonosok.Columns.Add("MobilSzam", "Mobilszám");
            dgvTulajdonosok.Columns.Add("Email", "Email");
        }

        public void TulajdonosokFeltoltese()
        {
            dgvTulajdonosok.Rows.Clear();
            if (Tulajdonosok.TulajdonosokLista.Count > 0)
            {
                foreach (Tulajdonos tulajdonos in Tulajdonosok.TulajdonosokLista)
                {
                    if(tulajdonos.Email == null)
                        dgvTulajdonosok.Rows.Add(new object[] { tulajdonos.Id, tulajdonos.Vnev, tulajdonos.Knev, tulajdonos.SzulDatum,
                            tulajdonos.Irszam, tulajdonos.Varos,tulajdonos.Lakcim,tulajdonos.MobilSzam,"-"});
                    else dgvTulajdonosok.Rows.Add(new object[] { tulajdonos.Id, tulajdonos.Vnev, tulajdonos.Knev, tulajdonos.SzulDatum,
                            tulajdonos.Irszam, tulajdonos.Varos,tulajdonos.Lakcim,tulajdonos.MobilSzam, tulajdonos.Email});
                }
            }
            else MessageBox.Show("A lista üres!","Hiba");
            dgvTulajdonosok.AutoResizeColumns();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frissítésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TulajdonosokFeltoltese();
        }

        private void súgóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Készítette: Somogyi Dávid\nEszterházy Károly Egyetem\nHallgató\n2020", "Súgó");
        }

        private void dgvTulajdonosok_SelectionChanged(object sender, EventArgs e)
        {
            if (SelectionChangedByMe)
            {
                DataGridView dgv = sender as DataGridView;
                if(dgv != null || dgv.SelectedRows.Count == 1)
                {
                    DataGridViewRow row = dgv.SelectedRows[0];
                    if(row != null)
                    {
                        int Id = int.Parse(row.Cells["Id"].Value.ToString());
                        foreach(Tulajdonos tulajdonos in Tulajdonosok.TulajdonosokLista)
                        {
                            //OPENDIALOG
                        }
                    }
                }
            }
        }
    }
}
