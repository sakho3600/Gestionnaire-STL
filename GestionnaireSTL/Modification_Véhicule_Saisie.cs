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
    public partial class Modification_Véhicule_Saisie : Form
    {
        public static int chassis;
        public Modification_Véhicule_Saisie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "GestionnaireSTL";
            string user = "root";
            string connectionString = "database=" + database + "; server= " + server + ";user =" + user;

            chassis = Int32.Parse(textBox5.Text);

            MySqlConnection cnx = new MySqlConnection(connectionString);
            cnx.Open();

            string query = "select * from vehicule where num_vehicule = @chassis";
            MySqlCommand cmd = new MySqlCommand(query, cnx);
            cmd.Parameters.AddWithValue("@chassis", chassis);
            MySqlDataReader rd = cmd.ExecuteReader();

            if (rd != null)
            {
                if (rd.Read())
                {
                    Modification_Véhicule F5 = new Modification_Véhicule();
                    this.Close();
                    F5.Show();
                }
                else
                    MessageBox.Show("Véhicule non existant!");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            this.Close();
            F3.Show();
        }
    }
}
