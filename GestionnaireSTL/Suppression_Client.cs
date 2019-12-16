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
    public partial class Suppression_Client : Form
    {
        public Suppression_Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "GestionnaireSTL";
            string user = "root";
            string connectionString = "database=" + database + "; server= " + server + ";user =" + user;

            int code_client = Int32.Parse(textBox5.Text);
            string type_client = comboBox1.Text;

            MySqlConnection cnx = new MySqlConnection(connectionString);
            cnx.Open();

            string query;
            MySqlCommand cmd;

            switch (type_client)
            {
                case "Tunisien":
                    {
                        query = "delete from client where cin = @search_cin";
                        cmd = new MySqlCommand(query, cnx);
                        cmd.Parameters.AddWithValue("@search_cin", code_client);

                        if (cmd.ExecuteNonQuery() != 0)
                            MessageBox.Show("Client supprimé!");
                        else
                            MessageBox.Show("Erreur lors de l'ajout du supprimé!");
                        cnx.Close();
                        break;
                    }
                case "Etranger":
                    {
                        query = "delete from client where numpass = @search_numpass";
                        cmd = new MySqlCommand(query, cnx);
                        cmd.Parameters.AddWithValue("@search_numpass", code_client);

                        if (cmd.ExecuteNonQuery() != 0)
                            MessageBox.Show("Client supprimé!");
                        else
                            MessageBox.Show("Erreur lors de l'ajout du supprimé!");
                        cnx.Close();
                        break;
                    }
                case "Entreprise":
                    {
                        query = "delete from client where code_fisc = @search_code_fisc";
                        cmd = new MySqlCommand(query, cnx);
                        cmd.Parameters.AddWithValue("@search_code_fisc", code_client);

                        if (cmd.ExecuteNonQuery() != 0)
                            MessageBox.Show("Client supprimé!");
                        else
                            MessageBox.Show("Erreur lors de l'ajout du supprimé!");
                        cnx.Close();
                        break;
                    }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Espace_Agent F16 = new Espace_Agent();
            F16.Show();
            FormsApplication.AddForm(F16);
            this.Close();
        }

        private void Form24_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
