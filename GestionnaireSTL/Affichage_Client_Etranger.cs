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
    public partial class Affichage_Client_Etranger : Form
    {
        public Affichage_Client_Etranger()
        {
            InitializeComponent();
        }

        private void Affichage_Client_Etranger_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Code", 150);
            listView1.Columns.Add("Adresse", 150);
            listView1.Columns.Add("Téléphone", 150);            
            listView1.Columns.Add("Pays", 150);
            listView1.Columns.Add("Nom", 150);
            listView1.Columns.Add("Prénom", 150);
            listView1.Columns.Add("Passport", 150);

            string server = "localhost";
            string database = "GestionnaireSTL";
            string user = "root";
            string connectionString = "database=" + database + "; server= " + server + ";user =" + user;

            MySqlConnection cnx = new MySqlConnection(connectionString);
            cnx.Open();

            string query = "select * from client";
            MySqlCommand cmd = new MySqlCommand(query, cnx);

            MySqlDataReader rd = cmd.ExecuteReader();

            if (rd != null)
            {
                while (rd.Read())
                {
                    //Add items in the listview
                    string[] arr = new string[rd.FieldCount];
                    ListViewItem itm;

                    if (!rd.IsDBNull(6))
                    {
                        for (int i = 0, j = 0; i < rd.FieldCount; i++)
                        {
                            if (!rd.IsDBNull(i))
                            {
                                arr[j] = rd.GetString(i);
                                j++;
                            }
                        }
                        itm = new ListViewItem(arr);
                        listView1.Items.Add(itm);
                    }
                }
            }
            rd.Close();
            cnx.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
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
