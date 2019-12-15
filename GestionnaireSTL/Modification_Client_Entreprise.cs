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
    public partial class Modification_Client_Entreprise : Form
    {
        public Modification_Client_Entreprise()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "GestionnaireSTL";
            string user = "root";
            string connectionString = "database=" + database + "; server= " + server + ";user =" + user;

            string raison = textBox1.Text;
            int code_fisc = Int32.Parse(textBox2.Text);
            string adresse = textBox3.Text;

            MySqlConnection cnx = new MySqlConnection(connectionString);
            cnx.Open();

            string query = "update client set adresse = @adresse, code_fisc = @code_fisc, raison = @raison where code_fisc = @search_code_fisc";
            MySqlCommand cmd = new MySqlCommand(query, cnx);
            cmd.Parameters.AddWithValue("@adresse", adresse);
            cmd.Parameters.AddWithValue("@code_fisc", code_fisc);
            cmd.Parameters.AddWithValue("@raison", raison);
            cmd.Parameters.AddWithValue("@search_code_fisc", Modification_Client_Saisie.code_client);

            if (cmd.ExecuteNonQuery() != 0)
                MessageBox.Show("Client modifié!");
            else
                MessageBox.Show("Erreur lors de l'ajout du modifié!");
            cnx.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form21_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Espace_Agent F16 = new Espace_Agent();
            this.Close();
            F16.Show();
        }
    }
}
