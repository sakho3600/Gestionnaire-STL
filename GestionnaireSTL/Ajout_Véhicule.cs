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
    public partial class Ajout_Véhicule : Form
    {
        public Ajout_Véhicule()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "GestionnaireSTL";
            string user = "root";
            string connectionString = "database=" + database + "; server= " + server + ";user =" + user;

            int chassis = Int32.Parse(textBox5.Text);
            int matr = Int32.Parse(textBox1.Text);
            string marque = comboBox2.Text;
            string catr = comboBox1.Text;
            int nombre_km_hr = Int32.Parse(textBox4.Text);
            string etat;

            MySqlConnection cnx = new MySqlConnection(connectionString);
            cnx.Open();

            string query = "insert into vehicule values (@chassis, @matr, @marque, @catr, @etat, @nb_km, @nb_hr)";
            MySqlCommand cmd = new MySqlCommand(query, cnx);
            cmd.Parameters.AddWithValue("@chassis", chassis);
            cmd.Parameters.AddWithValue("@matr", matr);
            cmd.Parameters.AddWithValue("@marque", marque);
            cmd.Parameters.AddWithValue("@catr", catr);
            if (catr == "Voiture" || catr == "Camion")
            {
                cmd.Parameters.AddWithValue("@nb_km", nombre_km_hr);
                cmd.Parameters.AddWithValue("@nb_hr", null);
            }
            else
            {
                cmd.Parameters.AddWithValue("@nb_hr", nombre_km_hr);
                cmd.Parameters.AddWithValue("@nb_km", null);
            }
            if (nombre_km_hr >= 10000)
                etat = "Ancien";
            else
                etat = "Neuf";
            cmd.Parameters.AddWithValue("@etat", etat);
            if (cmd.ExecuteNonQuery() != 0)
                MessageBox.Show("Vehicule ajouté!");
            else
                MessageBox.Show("Erreur lors de l'ajout du véhicule!");
            cnx.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.Show();
            FormsApplication.AddForm(F3);
            this.Close();            
        }
    }
}
