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
    public partial class Ajout_Contrat : Form
    {
        public Ajout_Contrat()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "GestionnaireSTL";
            string user = "root";
            string connectionString = "database=" + database + "; server= " + server + ";user =" + user;

            int code_client =  Int32.Parse(textBox6.Text);
            int num_vehicule = Int32.Parse(textBox5.Text);
            int tarif = Int32.Parse(textBox1.Text);
            int avance = Int32.Parse(textBox2.Text);
            DateTime date_debut = dateTimePicker1.Value;
            DateTime date_fin = dateTimePicker2.Value;
            int comp_deb = Int32.Parse(textBox3.Text);
            int comp_fin = Int32.Parse(textBox4.Text);
            string chauffeur = comboBox1.Text;

            MySqlConnection cnx = new MySqlConnection(connectionString);
            cnx.Open();

            string query = "insert into contrat values (null, @code_client, @num_vehicule, @tarif, @avance, @date_debut, @date_fin, @compteur_debut, @compteur_fin, @chauffeur)";
            MySqlCommand cmd = new MySqlCommand(query, cnx);
            cmd.Parameters.AddWithValue("@code_client", code_client);
            cmd.Parameters.AddWithValue("@num_vehicule", num_vehicule);
            cmd.Parameters.AddWithValue("@tarif", tarif);
            cmd.Parameters.AddWithValue("@avance", avance);
            cmd.Parameters.AddWithValue("@date_debut", date_debut);
            cmd.Parameters.AddWithValue("@date_fin", date_fin);
            cmd.Parameters.AddWithValue("@compteur_debut", comp_deb);
            cmd.Parameters.AddWithValue("@compteur_fin", comp_fin);
            cmd.Parameters.AddWithValue("@chauffeur", chauffeur);

            if (cmd.ExecuteNonQuery() != 0)
                MessageBox.Show("Contrat ajouté!");
            else
                MessageBox.Show("Erreur lors de l'ajout du contrat!");
            cnx.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Espace_Agent F16 = new Espace_Agent();
            F16.Show();
            FormsApplication.AddForm(F16);
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
