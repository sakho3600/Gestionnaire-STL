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

        private void ajouterTarifToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ajouterVéhiculeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajout_Contrat F29 = new Ajout_Contrat();
            F29.Show();
            FormsApplication.AddForm(F29);
            this.Close();            
        }

        private void clientTunisienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajout_Client_Tunisien F17 = new Ajout_Client_Tunisien();
            F17.Show();
            FormsApplication.AddForm(F17);
            this.Close();            
        }

        private void clientÉtrangerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajout_Client_Etranger F18 = new Ajout_Client_Etranger();
            F18.Show();
            FormsApplication.AddForm(F18);
            this.Close();            
        }

        private void entrepriseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajout_Client_Entreprise F19 = new Ajout_Client_Entreprise();
            F19.Show();
            FormsApplication.AddForm(F19);
            this.Close();            
        }

        private void modifierTarifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modification_Client_Saisie F20 = new Modification_Client_Saisie();
            F20.Show();
            FormsApplication.AddForm(F20);
            this.Close();            
        }

        private void supprimerTarifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppression_Client F24 = new Suppression_Client();
            F24.Show();
            FormsApplication.AddForm(F24);
            this.Close();            
        }

        private void modifierVéhiculeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modification_Contrat_Saisie F30 = new Modification_Contrat_Saisie();
            F30.Show();
            FormsApplication.AddForm(F30);
            this.Close();            
        }

        private void supprimerVéhiculeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppression_Contrat F32 = new Suppression_Contrat();
            F32.Show();
            FormsApplication.AddForm(F32);
            this.Close();            
        }

        private void ajouterCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajout_Facture F25 = new Ajout_Facture();
            F25.Show();
            FormsApplication.AddForm(F25);
            this.Close();            
        }

        private void modifierCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modification_Facture_Saisie F27 = new Modification_Facture_Saisie();
            F27.Show();
            FormsApplication.AddForm(F27);
            this.Close();            
        }

        private void supprimerCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppression_Facture F28 = new Suppression_Facture();
            F28.Show();
            FormsApplication.AddForm(F28);
            this.Close();            
        }

        private void rechercheVéhiculeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recherche_Vehicule F33 = new Recherche_Vehicule();
            F33.Show();
            FormsApplication.AddForm(F33);
            this.Close();            
        }

        private void clientsEntreprisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Affichage_Client_Entreprise F36 = new Affichage_Client_Entreprise();
            F36.Show();
            FormsApplication.AddForm(F36);
            this.Close();
        }

        private void clientsTunisiensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Affichage_Client_Tunisien F34 = new Affichage_Client_Tunisien();
            F34.Show();
            FormsApplication.AddForm(F34);
            this.Close();
        }

        private void clientsÉtrangersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Affichage_Client_Etranger F35 = new Affichage_Client_Etranger();
            F35.Show();
            FormsApplication.AddForm(F35);
            this.Close();
        }

        private void afficherFacturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Affichage_Facture F37 = new Affichage_Facture();
            F37.Show();
            FormsApplication.AddForm(F37);
            this.Close();
        }

        private void afficherContratsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Affichage_Contrat F38 = new Affichage_Contrat();
            F38.Show();
            FormsApplication.AddForm(F38);
            this.Close();
        }
    }
}
