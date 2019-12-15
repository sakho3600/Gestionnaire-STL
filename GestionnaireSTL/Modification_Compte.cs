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
    public partial class Modification_Compte : Form
    {
        public Modification_Compte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "GestionnaireSTL";
            string user = "root";
            string connectionString = "database=" + database + "; server= " + server + ";user =" + user;

            string login = textBox6.Text;
            string password = textBox1.Text;
            string nom = textBox2.Text;
            string prenom = textBox3.Text;
            string email = textBox4.Text;
            int num_tel = Int32.Parse(textBox5.Text);
            string type = comboBox1.Text;

            MySqlConnection cnx = new MySqlConnection(connectionString);
            cnx.Open();

            string query = "update compte set login = @login, mot_de_passe = @password, nom = @nom, prenom = @prenom, adresse_email = @email, num_tel = @num_tel, type = @type where login = @search_login";
            MySqlCommand cmd = new MySqlCommand(query, cnx);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@num_tel", num_tel);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@search_login", Modification_Compte_Saisie.login);

            if (cmd.ExecuteNonQuery() != 0)
                MessageBox.Show("Compte modifié!");
            else
                MessageBox.Show("Erreur lors de la modification du compte!");
            cnx.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            this.Close();
            F3.Show();
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }
    }
}
