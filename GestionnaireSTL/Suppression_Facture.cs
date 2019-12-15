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
    public partial class Suppression_Facture : Form
    {
        public Suppression_Facture()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "GestionnaireSTL";
            string user = "root";
            string connectionString = "database=" + database + "; server= " + server + ";user =" + user;

            int num_fact = Int32.Parse(textBox5.Text);

            MySqlConnection cnx = new MySqlConnection(connectionString);
            cnx.Open();

            string query = "delete from facture where num_facture = @search_num_facture";
            MySqlCommand cmd = new MySqlCommand(query, cnx);
            cmd.Parameters.AddWithValue("@search_num_facture", num_fact);
            if (cmd.ExecuteNonQuery() != 0)
                MessageBox.Show("Facture supprimée!");
            else
                MessageBox.Show("Erreur lors de la suppression de la facture!");
            cnx.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Espace_Agent F16 = new Espace_Agent();
            this.Close();
            F16.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Suppression_Facture_Load(object sender, EventArgs e)
        {

        }
    }
}
