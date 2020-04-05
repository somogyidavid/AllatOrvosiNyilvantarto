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
        private uint ID = 0;

        public Form1()
        {
            InitializeComponent();
            Tulajdonosok.TulajdonosFelvetele("Somogyi", "Dávid", DateTime.ParseExact("2000.03.08", "yyyy.mm.dd", null), "2660", "Balassagyarmat", "Szabó Püspök u.", "+36307415497");
            Tulajdonosok.TulajdonosFelvetele("Somogyi", "Dávid", DateTime.ParseExact("2000.03.08", "yyyy.mm.dd", null), "2660", "Balassagyarmat", "Szabó Püspök u.", "+36307415497");

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
                TablazatGombokLetrehozasa();
                dgvTulajdonosok.AutoResizeColumns();
            }
            else MessageBox.Show("A lista üres!","Hiba");
        }

        public void TulajdonosokDGVLetrehozas()
        {
            dgvTulajdonosok.AutoGenerateColumns = false;

            dgvTulajdonosok.Columns.Add("Id", "ID");
            dgvTulajdonosok.Columns.Add("Vnev", "Vezetéknév");
            dgvTulajdonosok.Columns.Add("Knev", "Keresztnév");
            dgvTulajdonosok.Columns.Add("SzulDatum", "Születési dátum");
            dgvTulajdonosok.Columns.Add("Varos", "Város");
            dgvTulajdonosok.Columns.Add("MobilSzam", "Mobilszám");
            dgvTulajdonosok.Columns.Add("Email", "Email");

        }

        public void TulajdonosokFeltoltese()
        {
            dgvTulajdonosok.Rows.Clear();
            SelectionChangedByMe = false;
            if (Tulajdonosok.TulajdonosokLista.Count > 0)
            {
                foreach (Tulajdonos tulajdonos in Tulajdonosok.TulajdonosokLista)
                {
                    if(tulajdonos.Email == null)
                        dgvTulajdonosok.Rows.Add(new object[] { tulajdonos.Id, tulajdonos.Vnev, tulajdonos.Knev, tulajdonos.SzulDatum.ToString("yyyy.mm.dd"),
                            tulajdonos.Varos,tulajdonos.MobilSzam,"-"});
                    else dgvTulajdonosok.Rows.Add(new object[] { tulajdonos.Id, tulajdonos.Vnev, tulajdonos.Knev, tulajdonos.SzulDatum,
                            tulajdonos.Varos,tulajdonos.MobilSzam, tulajdonos.Email});
                }
            }
            else MessageBox.Show("A lista üres!","Hiba");
            
            dgvTulajdonosok.Rows[0].Selected = false;
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

        private void TablazatGombokLetrehozasa()
        {
            DataGridViewButtonColumn dgvbcModosit = new DataGridViewButtonColumn();
            dgvbcModosit.Text = "Módosít";
            dgvbcModosit.Name = "dgvbcModosit";
            dgvbcModosit.HeaderText = "Módosítás";
            dgvbcModosit.UseColumnTextForButtonValue = true;
            dgvTulajdonosok.Columns.Add(dgvbcModosit);

            DataGridViewButtonColumn dgvbcTorol = new DataGridViewButtonColumn();
            dgvbcTorol.Text = "Töröl";
            dgvbcTorol.Name = "dgvbcTorol";
            dgvbcTorol.HeaderText = "Törlés";
            dgvbcTorol.UseColumnTextForButtonValue = true;
            
            dgvTulajdonosok.Columns.Add(dgvbcTorol);
        }

        private void dgvTulajdonosok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            switch (dgv.Columns[e.ColumnIndex].Name)
            {
                case "dgvbcModosit":
                    ID = Convert.ToUInt32(dgv.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    TulajdonosModositas TMO = new TulajdonosModositas(ID);
                    TMO.ShowDialog();
                    break;
                case "dgvbcTorol":
                    MessageBox.Show("Törlés visszakérdezés");
                    break;
            }
        }

        private void dgvTulajdonosok_SelectionChanged(object sender, EventArgs e)
        {
            if (SelectionChangedByMe)
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv != null && dgv.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgv.SelectedRows[0];
                    if (row != null)
                    {
                        int Id = int.Parse(row.Cells["Id"].Value.ToString());
                        foreach (Tulajdonos tulajdonos in Tulajdonosok.TulajdonosokLista)
                        {
                            if (tulajdonos.Id == Id)
                            {
                                TulajdonosMegtekintes TM = new TulajdonosMegtekintes(int.Parse(row.Cells["Id"].Value.ToString()));
                                TM.ShowDialog();
                                dgvTulajdonosok.SelectedRows[0].Selected = false;
                            }
                        }
                    }
                }
            }
            SelectionChangedByMe = true; 
        }

        private void dgvTulajdonosok_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            switch (dgv.Columns[e.ColumnIndex].Name)
            {
                case "dgvbcModosit":
                    dgvTulajdonosok.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
                    break;
                case "dgvbcTorol":
                    dgvTulajdonosok.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
                    break;
            }
        }

        private void dgvTulajdonosok_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvTulajdonosok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

    }
}
