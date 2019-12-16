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
    public partial class Ajout_Tarif : Form
    {
        public Ajout_Tarif()
        {
            InitializeComponent();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "GestionnaireSTL";
            string user = "root";
            string connectionString = "database=" + database + "; server= " + server + ";user =" + user;

            string catr = comboBox4.Text;
            int tarif_km = Int32.Parse(textBox1.Text);
            int tarif_jour = Int32.Parse(textBox2.Text);
            int tarif_hr = Int32.Parse(textBox3.Text);
            int tarif_chauffeur = Int32.Parse(textBox4.Text);

            MySqlConnection cnx = new MySqlConnection(connectionString);
            cnx.Open();

            string query = "insert into tarif values (@catr, @tarif_km, @tarif_jour, @tarif_hr, @tarif_chauffeur, @tarif_total, null)";
            MySqlCommand cmd = new MySqlCommand(query, cnx);
            cmd.Parameters.AddWithValue("@catr", catr);
            cmd.Parameters.AddWithValue("@tarif_km", tarif_km);
            cmd.Parameters.AddWithValue("@tarif_jour", tarif_jour);
            cmd.Parameters.AddWithValue("@tarif_hr", tarif_hr);
            cmd.Parameters.AddWithValue("@tarif_chauffeur", tarif_chauffeur);
            cmd.Parameters.AddWithValue("@tarif_total", tarif_km + tarif_jour + tarif_hr + tarif_chauffeur);
            if (cmd.ExecuteNonQuery() != 0)
                MessageBox.Show("Tarif ajouté!");
            else
                MessageBox.Show("Erreur lors de l'ajout du tarif!");
            cnx.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form F3 = new Form3();
            F3.Show();
            FormsApplication.AddForm(F3);
            this.Close();          
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
