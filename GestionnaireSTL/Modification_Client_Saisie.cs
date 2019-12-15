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
    public partial class Modification_Client_Saisie : Form
    {
        public static int code_client;
        public Modification_Client_Saisie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "GestionnaireSTL";
            string user = "root";
            string connectionString = "database=" + database + "; server= " + server + ";user =" + user;

            code_client = Int32.Parse(textBox5.Text);
            string type_client = comboBox1.Text;

            MySqlConnection cnx = new MySqlConnection(connectionString);
            cnx.Open();
            string query;
            MySqlCommand cmd;
            MySqlDataReader rd;

            switch (type_client)
            {
                case "Tunisien":
                    {
                        query = "select * from client where code_client = @code_client";
                        cmd = new MySqlCommand(query, cnx);
                        cmd.Parameters.AddWithValue("@code_client", code_client);
                        rd = cmd.ExecuteReader();

                        if (rd != null)
                        {
                            if (rd.Read())
                            {
                                rd.Close();
                                Modification_Client_Tunisien F23 = new Modification_Client_Tunisien();
                                this.Close();
                                F23.Show();
                            }
                            else
                                MessageBox.Show("Client non existant!");
                        }
                        break;
                    }
                case "Etranger":
                    {
                        query = "select * from client where code_client = @code_client";
                        cmd = new MySqlCommand(query, cnx);
                        cmd.Parameters.AddWithValue("@code_client", code_client);
                        rd = cmd.ExecuteReader();

                        if (rd != null)
                        {
                            if (rd.Read())
                            {
                                rd.Close();
                                Modification_Client_Etranger F22 = new Modification_Client_Etranger();
                                this.Close();
                                F22.Show();
                            }
                            else
                                MessageBox.Show("Client non existant!");
                        }
                        break;
                    }
                case "Entreprise":
                    {
                        query = "select * from client where code_client = @code_client";
                        cmd = new MySqlCommand(query, cnx);
                        cmd.Parameters.AddWithValue("@code_client", code_client);
                        rd = cmd.ExecuteReader();

                        if (rd != null)
                        {
                            if (rd.Read())
                            {
                                rd.Close();
                                Modification_Client_Entreprise F21 = new Modification_Client_Entreprise();
                                this.Close();
                                F21.Show();
                            }
                            else
                                MessageBox.Show("Client non existant!");
                        }
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
            this.Close();
            F16.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
