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
    public partial class Suppression_Tarif : Form
    {
        public Suppression_Tarif()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "GestionnaireSTL";
            string user = "root";
            string connectionString = "database=" + database + "; server= " + server + ";user =" + user;

            int tarif = Int32.Parse(textBox5.Text);

            MySqlConnection cnx = new MySqlConnection(connectionString);
            cnx.Open();

            string query = "delete from tarif where id_tarif = @tarif";
            MySqlCommand cmd = new MySqlCommand(query, cnx);
            cmd.Parameters.AddWithValue("@tarif", tarif);
            if (cmd.ExecuteNonQuery() != 0)
                MessageBox.Show("Tarif supprimé!");
            else
                MessageBox.Show("Erreur lors de suppression du tarif!");
            cnx.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form F3 = new Espace_Admin();
            F3.Show();
            FormsApplication.AddForm(F3);
            this.Close();
        }
    }
}
