using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionnaireSTL
{
    public partial class Modification_Facture : Form
    {
        public Modification_Facture()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "GestionnaireSTL";
            string user = "root";
            string connectionString = "database=" + database + "; server= " + server + ";user =" + user;

            int num_contrat = Int32.Parse(textBox9.Text);
            int num_vehicule = Int32.Parse(textBox8.Text);
            string catr = comboBox1.Text;
            int nombre_km_hr;
            int tarif_journalier;
            int tarif_chauffeur;
            int montant_global = Int32.Parse(textBox5.Text);
            int montant_tva = Int32.Parse(textBox1.Text);
            int montant_hors_taxe = Int32.Parse(textBox6.Text);
            int montant_net = Int32.Parse(textBox7.Text);
            DateTime date = dateTimePicker1.Value;

            MySqlConnection cnx = new MySqlConnection(connectionString);
            cnx.Open();

            string query = "select compteur_fin, compteur_debut as nombre_km_hr from contrat where num_contrat = @num_contrat";
            MySqlCommand cmd = new MySqlCommand(query, cnx);
            cmd.Parameters.AddWithValue("@num_contrat", num_contrat);

            string query_2 = "select tarif_jour, tarif_chauffeur from tarif, contrat where tarif.id_tarif = contrat.tarif and num_contrat = @num_contrat";
            MySqlCommand cmd_2 = new MySqlCommand(query_2, cnx);
            cmd_2.Parameters.AddWithValue("@num_contrat", num_contrat);

            string query_3 = "update facture set num_contrat = @num_contrat, num_vehicule = @num_vehicule, categorie = @catr, nb_km_hr = @nb_km_hr, tarif_journalier = @tarif_journalier, tarif_chauffeur = @tarif_chauffeur, montant_global = @montant_global, montant_hors_taxe = @montant_hors_taxe, montant_tva = @montant_tva, montant_net = @montant_net, date_facture = @date_facture where num_facture = @search_num_facture";
            MySqlCommand cmd_3 = new MySqlCommand(query_3, cnx);
            cmd_3.Parameters.AddWithValue("@num_contrat", num_contrat);
            cmd_3.Parameters.AddWithValue("@num_vehicule", num_vehicule);
            cmd_3.Parameters.AddWithValue("@catr", catr);
            cmd_3.Parameters.AddWithValue("@montant_global", montant_global);
            cmd_3.Parameters.AddWithValue("@montant_hors_taxe", montant_hors_taxe);
            cmd_3.Parameters.AddWithValue("@montant_tva", montant_tva);
            cmd_3.Parameters.AddWithValue("@montant_net", montant_net);
            cmd_3.Parameters.AddWithValue("@date_facture", date);
            cmd_3.Parameters.AddWithValue("@search_num_facture", Modification_Facture_Saisie.num_fact);

            MySqlDataReader rd = cmd.ExecuteReader();
            if (rd != null)
            {
                rd.Read();
                nombre_km_hr = (int)rd[0] - (int)rd[1];
                cmd_3.Parameters.AddWithValue("@nb_km_hr", nombre_km_hr);
            }
            rd.Close();

            MySqlDataReader rd_2 = cmd_2.ExecuteReader();
            if (rd_2 != null)
            {
                rd_2.Read();
                tarif_journalier = (int)rd_2[0];
                tarif_chauffeur = (int)rd_2[1];
                cmd_3.Parameters.AddWithValue("@tarif_chauffeur", tarif_chauffeur);
                cmd_3.Parameters.AddWithValue("@tarif_journalier", tarif_journalier);
            }      
            rd_2.Close();

            if (cmd_3.ExecuteNonQuery() != 0)
                MessageBox.Show("Facture ajoutée!");
            else
                MessageBox.Show("Erreur lors de l'ajout de la facture!");
            cnx.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Espace_Agent F16 = new Espace_Agent();
            F16.Show();
            FormsApplication.AddForm(F16);
            this.Close();
        }

        private void Modification_Facture_Load(object sender, EventArgs e)
        {

        }
    }
}
