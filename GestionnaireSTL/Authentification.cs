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
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Acceuil F1 = new Acceuil(); 
            F1.Show();
            FormsApplication.AddForm(F1);
            this.Close();
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

            string login;
            string password;
            login = textBox1.Text;
            password = textBox2.Text;

            MySqlConnection cnx = new MySqlConnection(connectionString);
            cnx.Open();

            string query = "select * from compte where login = @login and mot_de_passe = @password";
            MySqlCommand cmd = new MySqlCommand(query, cnx);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", password);
            MySqlDataReader rd = cmd.ExecuteReader();

            if (rd != null)
            {
                if (rd.Read())
                {
                    MessageBox.Show("Bienvenue " + rd[2] + " " + rd[3] + "!");
                    if ((string)rd[6] == "Admin")
                    {
                        cnx.Close();
                        Espace_Admin F3 = new Espace_Admin();
                        F3.Show();
                        FormsApplication.AddForm(F3);
                        this.Close();
                    }
                    else if ((string)rd[6] == "Agent")
                    {
                        cnx.Close();
                        Espace_Agent F16 = new Espace_Agent();
                        F16.Show();
                        FormsApplication.AddForm(F16);
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Compte non existant!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Authentification_Load(object sender, EventArgs e)
        {

        }
    }
}
