using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionnaireSTL
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gérerLeParcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajouterVéhiculeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajout_Véhicule F4 = new Ajout_Véhicule();
            this.Close();
            F4.Show();
        }

        private void modifierVéhiculeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modification_Véhicule_Saisie F6 = new Modification_Véhicule_Saisie();
            this.Close();
            F6.Show();
        }

        private void supprimerVéhiculeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppression_Véhicule F7 = new Suppression_Véhicule();
            this.Close();
            F7.Show();
        }

        private void ajouterTarifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajout_Tarif F8 = new Ajout_Tarif();
            this.Close();
            F8.Show();
        }

        private void modifierTarifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modification_Tarif_Saisie F9 = new Modification_Tarif_Saisie();
            this.Close();
            F9.Show();
        }

        private void supprimerTarifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppression_Tarif F11 = new Suppression_Tarif();
            this.Close();
            F11.Show();
        }

        private void ajouterCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajout_Compte F12 = new Ajout_Compte();
            this.Close();
            F12.Show();
        }

        private void modifierCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modification_Compte_Saisie F13 = new Modification_Compte_Saisie();
            this.Close();
            F13.Show();
        }

        private void supprimerCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppression_Compte F15 = new Suppression_Compte();
            this.Close();
            F15.Show();
        }
    }
}
