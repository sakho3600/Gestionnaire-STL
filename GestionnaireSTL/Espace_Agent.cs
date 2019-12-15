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
    public partial class Espace_Agent : Form
    {
        public Espace_Agent()
        {
            InitializeComponent();
        }

        private void ajouterVéhiculeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajout_Contrat F29 = new Ajout_Contrat();
            this.Close();
            F29.Show();
        }

        private void ajouterTarifToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientTunisienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajout_Client_Tunisien F17 = new Ajout_Client_Tunisien();
            this.Close();
            F17.Show();
        }

        private void clientÉtrangerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajout_Client_Etranger F18 = new Ajout_Client_Etranger();
            this.Close();
            F18.Show();
        }

        private void entrepriseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajout_Client_Entreprise F19 = new Ajout_Client_Entreprise();
            this.Close();
            F19.Show();
        }

        private void modifierTarifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modification_Client_Saisie F20 = new Modification_Client_Saisie();
            this.Close();
            F20.Show();
        }

        private void supprimerTarifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppression_Client F24 = new Suppression_Client();
            this.Close();
            F24.Show();
        }

        private void modifierVéhiculeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modification_Contrat_Saisie F30 = new Modification_Contrat_Saisie();
            this.Close();
            F30.Show();
        }

        private void supprimerVéhiculeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppression_Contrat F32 = new Suppression_Contrat();
            this.Close();
            F32.Show();
        }

        private void ajouterCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajout_Facture F25 = new Ajout_Facture();
            this.Close();
            F25.Show();
        }

        private void modifierCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modification_Facture_Saisie F27 = new Modification_Facture_Saisie();
            this.Close();
            F27.Show();
        }

        private void supprimerCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppression_Facture F28 = new Suppression_Facture();
            this.Close();
            F28.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rechercheVéhiculeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recherche_Véhicule F33 = new Recherche_Véhicule();
            this.Close();
            F33.Show();
        }
    }
}
