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
    public partial class Suppression_Compte : Form
    {
        public Suppression_Compte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "GestionnaireSTL";
            string user = "root";
            string connectionString = "database=" + database + "; server= " + server + ";user =" + user;

            string login = textBox5.Text;

            MySqlConnection cnx = new MySqlConnection(connectionString);
            cnx.Open();

            string query = "delete from compte where login = @login";
            MySqlCommand cmd = new MySqlCommand(query, cnx);
            cmd.Parameters.AddWithValue("@login", login);
            if (cmd.ExecuteNonQuery() != 0)
                MessageBox.Show("Compte supprimé!");
            else
                MessageBox.Show("Erreur lors de suppression du compte!");
            cnx.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Espace_Admin F3 = new Espace_Admin();
            F3.Show();
            FormsApplication.AddForm(F3);
            this.Close();
        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }
    }
}
