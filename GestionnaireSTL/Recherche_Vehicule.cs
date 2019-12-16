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
    public partial class Recherche_Vehicule : Form
    {
        public Recherche_Vehicule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "GestionnaireSTL";
            string user = "root";
            string connectionString = "database=" + database + "; server= " + server + ";user =" + user;

            string catr = comboBox2.Text;
            string etat = comboBox3.Text;
            DateTime date_debut = dateTimePicker1.Value;
            DateTime date_fin = dateTimePicker2.Value;
            string chauffeur = comboBox1.Text;
            string vehicules = "";
            List<int> T = new List<int>();


            MySqlConnection cnx = new MySqlConnection(connectionString);
            cnx.Open();

            string query = "select * from vehicule where categorie = @catr and etat = @etat";
            MySqlCommand cmd = new MySqlCommand(query, cnx);
            cmd.Parameters.AddWithValue("@catr", catr);
            cmd.Parameters.AddWithValue("@etat", etat);

            MySqlDataReader rd = cmd.ExecuteReader();
            if (rd != null)
            {
                while (rd.Read())
                {
                    T.Add((int)rd[0]);
                }
            }
            rd.Close();

            if (T.Count != 0)
            {
                string query_2 = "select num_vehicule, date_debut, date_fin from contrat where num_vehicule = @chassis";
                MySqlCommand cmd_2 = new MySqlCommand(query_2, cnx);
                for (int i = 0; i < T.Count; i++)
                {
                    cmd_2.Parameters.AddWithValue("@chassis", T[i]);
                    MySqlDataReader rd_2 = cmd_2.ExecuteReader();
                    if (rd_2 != null)
                    {
                        rd_2.Read();
                        if ((DateTime)rd_2[2] > date_debut)
                            T.Remove(T[i]);
                    }
                    rd_2.Close();
                }
            }

            string query_3 = "select num_vehicule, matr, marque, categorie from vehicule where num_vehicule = @chassis";
            MySqlCommand cmd_3 = new MySqlCommand(query_3, cnx);
            foreach (int i in T)
            {
                cmd_3.Parameters.AddWithValue("@chassis", i);
                MySqlDataReader rd_3 = cmd_3.ExecuteReader();
                if (rd_3 != null)
                {
                    while (rd_3.Read())
                    {
                        vehicules += "" + rd_3[3] + "de chassis: " + rd_3[0] + ", marque: " + rd_3[2] + ", matricule: " + rd_3[1] + " disponible! \n";
                    }
                }
                rd_3.Close();
            }
            if (vehicules != "")
                MessageBox.Show(vehicules);
            else
                MessageBox.Show("Véhicule non disponible!");
            cnx.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Espace_Agent F16 = new Espace_Agent();
            F16.Show();
            FormsApplication.AddForm(F16);
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
