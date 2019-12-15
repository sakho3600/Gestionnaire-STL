﻿using System;
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
    public partial class Modification_Client_Tunisien : Form
    {
        public Modification_Client_Tunisien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "GestionnaireSTL";
            string user = "root";
            string connectionString = "database=" + database + "; server= " + server + ";user =" + user;

            int cin = Int32.Parse(textBox1.Text);
            string nom = textBox2.Text;
            string prenom = textBox3.Text;
            string adresse = textBox4.Text;
            int num_tel = Int32.Parse(textBox5.Text);

            MySqlConnection cnx = new MySqlConnection(connectionString);
            cnx.Open();

            string query = "update client set adresse = @adresse, num_tel = @num_tel, cin = @cin, nom = @nom, prenom = @prenom where cin = @search_cin";
            MySqlCommand cmd = new MySqlCommand(query, cnx);
            cmd.Parameters.AddWithValue("@adresse", adresse);
            cmd.Parameters.AddWithValue("@num_tel", num_tel);
            cmd.Parameters.AddWithValue("@cin", cin);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.Parameters.AddWithValue("@search_cin", Modification_Client_Saisie.code_client);

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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Espace_Agent F16 = new Espace_Agent();
            this.Hide();
            F16.Show();
        }
    }
}
