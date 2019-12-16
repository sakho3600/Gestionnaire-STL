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
    public partial class Ajout_Client_Etranger : Form
    {
        public Ajout_Client_Etranger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "GestionnaireSTL";
            string user = "root";
            string connectionString = "database=" + database + "; server= " + server + ";user =" + user;

            int num_pass = Int32.Parse(textBox1.Text);
            string nom = textBox2.Text;
            string prenom = textBox3.Text;
            string pays_origine = textBox4.Text;
            int num_tel = Int32.Parse(textBox5.Text);
            string adresse = textBox6.Text;

            MySqlConnection cnx = new MySqlConnection(connectionString);
            cnx.Open();

            string query = "insert into client values (null, @adresse, @num_tel, null, @nom, @prenom, @numpass, @pays, null, null)";
            MySqlCommand cmd = new MySqlCommand(query, cnx);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.Parameters.AddWithValue("@adresse", adresse);
            cmd.Parameters.AddWithValue("@pays", pays_origine);
            cmd.Parameters.AddWithValue("@num_tel", num_tel);
            cmd.Parameters.AddWithValue("@numpass", num_pass);

            if (cmd.ExecuteNonQuery() != 0)
                MessageBox.Show("Client ajouté!");
            else
                MessageBox.Show("Erreur lors de l'ajout du client!");
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Espace_Agent F16 = new Espace_Agent();            
            F16.Show();
            FormsApplication.AddForm(F16);
            this.Close();
        }
    }
}
