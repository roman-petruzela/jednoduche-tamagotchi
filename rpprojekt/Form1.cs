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
        private List<Tamagotchi> pets = new List<Tamagotchi>();
        private int selectedPetIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void empty()
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

        private void stav(string message)
        {
            Tamagotchi pet = null;

            if (selectedPetIndex >= 0 && selectedPetIndex < pets.Count)
            {
                pet = pets[selectedPetIndex];
            }

            if (pet == null)
            {
                lblNadpisZviratko.Text = "Zviratko: -";
                lblHlad.Text = "Hlad: -";
                lblNalada.Text = "Nalada: -";
                lblEnergie.Text = "Energie: -";
                lblVek.Text = "Vek: -";
                lblStav.Text = message;
                btnKrm.Enabled = false;
                btnHraj.Enabled = false;
                btnSpi.Enabled = false;
                btnPrev.Enabled = false;
                btnNext.Enabled = false;
                return;
            }

            lblNadpisZviratko.Text = "Zviratko: " + pet.Name + " (" + (selectedPetIndex + 1) + "/" + pets.Count + ")";
            lblStav.Text = message;
            lblHlad.Text = "Hlad: " + pet.hlad + " / 100";
            lblNalada.Text = "Nalada: " + pet.nalada + " / 100";
            lblEnergie.Text = "Energie: " + pet.energie + " / 100";
            lblVek.Text = "Vek: " + pet.DejVekText();

            pbHlad.Value = 100 - pet.hlad;
            pbNalada.Value = pet.nalada;
            pbEnergie.Value = pet.energie;

            btnKrm.Enabled = pet.zije && !pet.spi && pet.ActionCooldown == 0;
            btnHraj.Enabled = pet.zije && !pet.spi && pet.ActionCooldown == 0;
            btnSpi.Enabled = pet.zije && !pet.spi && pet.ActionCooldown == 0;
            btnRestart.Enabled = true;
            btnPrev.Enabled = pets.Count > 1;
            btnNext.Enabled = pets.Count > 1;

            if (!pet.zije)
            {
                lblStav.Text = pet.Name + " to nezvladlo. Muzes prepnout na jineho nebo ho restartovat.";
            }
            else if (pet.spi)
            {
                lblStav.Text = pet.Name + " spi a nabira energii.";
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

            Tamagotchi pet = new Tamagotchi(name);

            pets.Add(pet);
            lstMazlicci.Items.Add(pet.Name);
            selectedPetIndex = pets.Count - 1;

            txtJmeno.Text = pet.Name;
            trkPorce.Value = 3;
            lstMazlicci.SelectedIndex = selectedPetIndex;

            timerHra.Start();
            stav("Novy mazlicek byl pridany.");
        }

        private void btnKrm_Click(object sender, EventArgs e)
        {
            Tamagotchi pet = null;
            if (selectedPetIndex >= 0 && selectedPetIndex < pets.Count)
            {
                pet = pets[selectedPetIndex];
            }

            if (pet == null)
            {
                return;
            }

            pet.Feed(trkPorce.Value);
            stav(pet.Name + " dostal jidlo.");
        }

        private void btnHraj_Click(object sender, EventArgs e)
        {
            Tamagotchi pet = null;
            if (selectedPetIndex >= 0 && selectedPetIndex < pets.Count)
            {
                pet = pets[selectedPetIndex];
            }

            if (pet == null)
            {
                return;
            }

            pet.hrat();
            stav(pet.Name + " si hral.");
        }

        private void btnSpi_Click(object sender, EventArgs e)
        {
            Tamagotchi pet = null;
            if (selectedPetIndex >= 0 && selectedPetIndex < pets.Count)
            {
                pet = pets[selectedPetIndex];
            }

            if (pet == null)
            {
                return;
            }

            pet.spat();
            stav(pet.Name + " si odpocinul.");
        }

        private void timerHra_Tick(object sender, EventArgs e)
        {
            if (pets.Count == 0)
            {
                timerHra.Stop();
                empty();
                return;
            }

            for (int i = 0; i < pets.Count; i++)
            {
                pets[i].Tick();
            }

            stav("Cas plyne pro vsechny mazlicky...");
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Tamagotchi pet = null;
            if (selectedPetIndex >= 0 && selectedPetIndex < pets.Count)
            {
                pet = pets[selectedPetIndex];
            }

            if (pet == null)
            {
                return;
            }

            pet.reset(pet.Name);
            stav("Mazlicek byl restartovan.");
        }

        private void txtJmeno_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstMazlicci_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMazlicci.SelectedIndex < 0 || lstMazlicci.SelectedIndex >= pets.Count)
            {
                return;
            }

            selectedPetIndex = lstMazlicci.SelectedIndex;
            stav("Vybrany mazlicek.");
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (pets.Count == 0)
            {
                return;
            }

            selectedPetIndex--;
            if (selectedPetIndex < 0)
            {
                selectedPetIndex = pets.Count - 1;
            }

            lstMazlicci.SelectedIndex = selectedPetIndex;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pets.Count == 0)
            {
                return;
            }

            selectedPetIndex++;
            if (selectedPetIndex >= pets.Count)
            {
                selectedPetIndex = 0;
            }

            lstMazlicci.SelectedIndex = selectedPetIndex;
        }
    }
}
