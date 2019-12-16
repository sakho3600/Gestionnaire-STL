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
    public partial class Ajout_Compte : Form
    {
        public Ajout_Compte()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

            string query = "insert into compte values (@login, @password, @nom, @prenom, @email, @num_tel, @type)";
            MySqlCommand cmd = new MySqlCommand(query, cnx);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@num_tel", num_tel);
            cmd.Parameters.AddWithValue("@type", type);

            int login_found = 0;
            string query_2 = "select login from compte";
            MySqlCommand cmd_2 = new MySqlCommand(query_2, cnx);
            MySqlDataReader rd = cmd_2.ExecuteReader();
            if (rd != null)
            {
                while (rd.Read())
                    if ((string)rd[0] == login)
                    {
                        MessageBox.Show("Ce login existe déjà!");
                        login_found = 1;
                    }
            }
            rd.Close();

            if (login_found == 0)
            {
                if (cmd.ExecuteNonQuery() != 0)
                    MessageBox.Show("Compte ajouté!");
                else
                    MessageBox.Show("Erreur lors de l'ajout du compte!");
            }
            cnx.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Espace_Admin F3 = new Espace_Admin();
            F3.Show();
            FormsApplication.AddForm(F3);
            this.Close();
        }
    }
}
