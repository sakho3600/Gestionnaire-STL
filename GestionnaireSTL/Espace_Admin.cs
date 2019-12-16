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
    public partial class Espace_Admin : Form
    {
        public Espace_Admin()
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
            Ajout_Vehicule F4 = new Ajout_Vehicule();
            F4.Show();
            FormsApplication.AddForm(F4);
            this.Close();            
        }

        private void modifierVéhiculeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modification_Vehicule_Saisie F6 = new Modification_Vehicule_Saisie();
            F6.Show();
            FormsApplication.AddForm(F6);
            this.Close();            
        }

        private void supprimerVéhiculeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppression_Vehicule F7 = new Suppression_Vehicule();
            F7.Show();
            FormsApplication.AddForm(F7);
            this.Close();            
        }

        private void ajouterTarifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajout_Tarif F8 = new Ajout_Tarif();
            F8.Show();
            FormsApplication.AddForm(F8);
            this.Close();            
        }

        private void modifierTarifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modification_Tarif_Saisie F9 = new Modification_Tarif_Saisie();
            F9.Show();
            FormsApplication.AddForm(F9);
            this.Close();            
        }

        private void supprimerTarifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppression_Tarif F11 = new Suppression_Tarif();
            F11.Show();
            FormsApplication.AddForm(F11);
            this.Close();            
        }

        private void ajouterCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajout_Compte F12 = new Ajout_Compte();
            F12.Show();
            FormsApplication.AddForm(F12);
            this.Close();            
        }

        private void modifierCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modification_Compte_Saisie F13 = new Modification_Compte_Saisie();
            F13.Show();
            FormsApplication.AddForm(F13);
            this.Close();            
        }

        private void supprimerCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppression_Compte F15 = new Suppression_Compte();
            F15.Show();
            FormsApplication.AddForm(F15);
            this.Close();            
        }

        private void afficherTarifsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Affichage_Tarif F39 = new Affichage_Tarif();
            F39.Show();
            FormsApplication.AddForm(F39);
            this.Close();
        }

        private void affichageComptesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Affichage_Compte F40 = new Affichage_Compte();
            F40.Show();
            FormsApplication.AddForm(F40);
            this.Close();
        }

        private void afficherVéhiculesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Affichage_Vehicule F41 = new Affichage_Vehicule();
            F41.Show();
            FormsApplication.AddForm(F41);
            this.Close();
        }
    }
}
