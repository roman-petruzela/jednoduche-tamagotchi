using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rpprojekt
{
    public partial class Form1 : Form
    {
        private List<Tamagotchi> zvirata = new List<Tamagotchi>();
        private int vybranyIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void prazdno()
        {
            lblNadpisZviratko.Text = "Zviratko: -";
            lblHlad.Text = "Hlad: -";
            lblNalada.Text = "Nalada: -";
            lblEnergie.Text = "Energie: -";
            lblVek.Text = "Vek: -";
            lblStav.Text = "Nejsou tu zadni mazlicci. Klikni na Start.";

            pbHlad.Value = 0;
            pbNalada.Value = 0;
            pbEnergie.Value = 0;

            btnKrm.Enabled = false;
            btnHraj.Enabled = false;
            btnSpi.Enabled = false;
            btnRestart.Enabled = false;
            btnPrev.Enabled = false;
            btnNext.Enabled = false;

            timerHra.Stop();
        }

        private void stav(string zprava)
        {
            Tamagotchi zviratko = null;

            if (vybranyIndex >= 0 && vybranyIndex < zvirata.Count)
            {
                zviratko = zvirata[vybranyIndex];
            }

            if (zviratko == null)
            {
                lblNadpisZviratko.Text = "Zviratko: -";
                lblHlad.Text = "Hlad: -";
                lblNalada.Text = "Nalada: -";
                lblEnergie.Text = "Energie: -";
                lblVek.Text = "Vek: -";
                lblStav.Text = zprava;
                btnKrm.Enabled = false;
                btnHraj.Enabled = false;
                btnSpi.Enabled = false;
                btnPrev.Enabled = false;
                btnNext.Enabled = false;
                return;
            }

            lblNadpisZviratko.Text = "Zviratko: " + zviratko.Name + " (" + (vybranyIndex + 1) + "/" + zvirata.Count + ")";
            lblStav.Text = zprava;
            lblHlad.Text = "Hlad: " + zviratko.hlad + " / 100";
            lblNalada.Text = "Nalada: " + zviratko.nalada + " / 100";
            lblEnergie.Text = "Energie: " + zviratko.energie + " / 100";
            lblVek.Text = "Vek: " + zviratko.DejVekText();

            pbHlad.Value = 100 - zviratko.hlad;
            pbNalada.Value = zviratko.nalada;
            pbEnergie.Value = zviratko.energie;

            btnKrm.Enabled = zviratko.zije && !zviratko.spi && zviratko.ActionCooldown == 0;
            btnHraj.Enabled = zviratko.zije && !zviratko.spi && zviratko.ActionCooldown == 0;
            btnSpi.Enabled = zviratko.zije && !zviratko.spi && zviratko.ActionCooldown == 0;
            btnRestart.Enabled = true;
            btnPrev.Enabled = zvirata.Count > 1;
            btnNext.Enabled = zvirata.Count > 1;

            if (!zviratko.zije)
            {
                lblStav.Text = zviratko.Name + " to nezvladlo. Muzes prepnout na jineho nebo ho restartovat.";
            }
            else if (zviratko.spi)
            {
                lblStav.Text = zviratko.Name + " spi a nabira energii.";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string name = txtJmeno.Text;
            if (name == null)
            {
                name = "";
            }

            name = name.Trim();
            if (name == "")
            {
                name = "Mazlík";
            }

            Tamagotchi zviratko = new Tamagotchi(name);

            zvirata.Add(zviratko);
            lstMazlicci.Items.Add(zviratko.Name);
            vybranyIndex = zvirata.Count - 1;

            txtJmeno.Text = zviratko.Name;
            trkPorce.Value = 3;
            lstMazlicci.SelectedIndex = vybranyIndex;

            timerHra.Start();
            stav("Novy mazlicek byl pridany.");
        }

        private void btnKrm_Click(object sender, EventArgs e)
        {
            Tamagotchi zviratko = null;
            if (vybranyIndex >= 0 && vybranyIndex < zvirata.Count)
            {
                zviratko = zvirata[vybranyIndex];
            }

            if (zviratko == null)
            {
                return;
            }

            zviratko.Feed(trkPorce.Value);
            stav(zviratko.Name + " dostal jidlo.");
        }

        private void btnHraj_Click(object sender, EventArgs e)
        {
            Tamagotchi zviratko = null;
            if (vybranyIndex >= 0 && vybranyIndex < zvirata.Count)
            {
                zviratko = zvirata[vybranyIndex];
            }

            if (zviratko == null)
            {
                return;
            }

            zviratko.hrat();
            stav(zviratko.Name + " si hral.");
        }

        private void btnSpi_Click(object sender, EventArgs e)
        {
            Tamagotchi zviratko = null;
            if (vybranyIndex >= 0 && vybranyIndex < zvirata.Count)
            {
                zviratko = zvirata[vybranyIndex];
            }

            if (zviratko == null)
            {
                return;
            }

            zviratko.spat();
            stav(zviratko.Name + " si odpocinul.");
        }

        private void timerHra_Tick(object sender, EventArgs e)
        {
            if (zvirata.Count == 0)
            {
                timerHra.Stop();
                prazdno();
                return;
            }

            for (int i = 0; i < zvirata.Count; i++)
            {
                zvirata[i].Tick();
            }

            stav("Cas plyne pro vsechny mazlicky...");
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Tamagotchi zviratko = null;
            if (vybranyIndex >= 0 && vybranyIndex < zvirata.Count)
            {
                zviratko = zvirata[vybranyIndex];
            }

            if (zviratko == null)
            {
                return;
            }

            zviratko.reset(zviratko.Name);
            stav("Mazlicek byl restartovan.");
        }

        private void txtJmeno_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstMazlicci_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMazlicci.SelectedIndex < 0 || lstMazlicci.SelectedIndex >= zvirata.Count)
            {
                return;
            }

            vybranyIndex = lstMazlicci.SelectedIndex;
            stav("Vybrany mazlicek.");
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (zvirata.Count == 0)
            {
                return;
            }

            vybranyIndex--;
            if (vybranyIndex < 0)
            {
                vybranyIndex = zvirata.Count - 1;
            }

            lstMazlicci.SelectedIndex = vybranyIndex;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (zvirata.Count == 0)
            {
                return;
            }

            vybranyIndex++;
            if (vybranyIndex >= zvirata.Count)
            {
                vybranyIndex = 0;
            }

            lstMazlicci.SelectedIndex = vybranyIndex;
        }
    }
}
