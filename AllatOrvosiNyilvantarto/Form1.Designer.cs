namespace AllatOrvosiNyilvantarto
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTulajdonosok = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beállításokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szerkesztésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tulajdonosokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.súgóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.összesTulajdonosListázásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tulajdonosKereséseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frissítésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fájlBeolvasásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTulajdonosok)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTulajdonosok
            // 
            this.dgvTulajdonosok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTulajdonosok.Location = new System.Drawing.Point(12, 43);
            this.dgvTulajdonosok.Name = "dgvTulajdonosok";
            this.dgvTulajdonosok.Size = new System.Drawing.Size(985, 403);
            this.dgvTulajdonosok.TabIndex = 1;
            this.dgvTulajdonosok.SelectionChanged += new System.EventHandler(this.dgvTulajdonosok_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.szerkesztésToolStripMenuItem,
            this.frissítésToolStripMenuItem,
            this.súgóToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1009, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlBeolvasásaToolStripMenuItem,
            this.beállításokToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // beállításokToolStripMenuItem
            // 
            this.beállításokToolStripMenuItem.Name = "beállításokToolStripMenuItem";
            this.beállításokToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beállításokToolStripMenuItem.Text = "Beállítások";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // szerkesztésToolStripMenuItem
            // 
            this.szerkesztésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tulajdonosokToolStripMenuItem,
            this.összesTulajdonosListázásaToolStripMenuItem,
            this.tulajdonosKereséseToolStripMenuItem});
            this.szerkesztésToolStripMenuItem.Name = "szerkesztésToolStripMenuItem";
            this.szerkesztésToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.szerkesztésToolStripMenuItem.Text = "Szerkesztés";
            // 
            // tulajdonosokToolStripMenuItem
            // 
            this.tulajdonosokToolStripMenuItem.Name = "tulajdonosokToolStripMenuItem";
            this.tulajdonosokToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.tulajdonosokToolStripMenuItem.Text = "Új tulajdonos felvétele";
            this.tulajdonosokToolStripMenuItem.Click += new System.EventHandler(this.tulajdonosokToolStripMenuItem_Click);
            // 
            // súgóToolStripMenuItem
            // 
            this.súgóToolStripMenuItem.Name = "súgóToolStripMenuItem";
            this.súgóToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.súgóToolStripMenuItem.Text = "Súgó";
            this.súgóToolStripMenuItem.Click += new System.EventHandler(this.súgóToolStripMenuItem_Click);
            // 
            // összesTulajdonosListázásaToolStripMenuItem
            // 
            this.összesTulajdonosListázásaToolStripMenuItem.Name = "összesTulajdonosListázásaToolStripMenuItem";
            this.összesTulajdonosListázásaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.összesTulajdonosListázásaToolStripMenuItem.Text = "Összes tulajdonos listázása";
            this.összesTulajdonosListázásaToolStripMenuItem.Click += new System.EventHandler(this.összesTulajdonosListázásaToolStripMenuItem_Click);
            // 
            // tulajdonosKereséseToolStripMenuItem
            // 
            this.tulajdonosKereséseToolStripMenuItem.Name = "tulajdonosKereséseToolStripMenuItem";
            this.tulajdonosKereséseToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.tulajdonosKereséseToolStripMenuItem.Text = "Tulajdonos keresése";
            // 
            // frissítésToolStripMenuItem
            // 
            this.frissítésToolStripMenuItem.Name = "frissítésToolStripMenuItem";
            this.frissítésToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.frissítésToolStripMenuItem.Text = "Frissítés";
            this.frissítésToolStripMenuItem.Click += new System.EventHandler(this.frissítésToolStripMenuItem_Click);
            // 
            // fájlBeolvasásaToolStripMenuItem
            // 
            this.fájlBeolvasásaToolStripMenuItem.Name = "fájlBeolvasásaToolStripMenuItem";
            this.fájlBeolvasásaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fájlBeolvasásaToolStripMenuItem.Text = "Fájl beolvasása";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1009, 463);
            this.Controls.Add(this.dgvTulajdonosok);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Állatorvosi nyilvántartó";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTulajdonosok)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTulajdonosok;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beállításokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szerkesztésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tulajdonosokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem súgóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem összesTulajdonosListázásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tulajdonosKereséseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frissítésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fájlBeolvasásaToolStripMenuItem;
    }
}

