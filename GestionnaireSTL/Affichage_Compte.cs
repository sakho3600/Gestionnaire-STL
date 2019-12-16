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
    public partial class Affichage_Compte : Form
    {
        public Affichage_Compte()
        {
            InitializeComponent();
        }

        private void Affichage_Compte_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Login", 150);
            listView1.Columns.Add("Mot de Passe", 150);
            listView1.Columns.Add("Nom", 150);
            listView1.Columns.Add("Prénom", 150);
            listView1.Columns.Add("Email", 150);
            listView1.Columns.Add("Téléphone", 150);
            listView1.Columns.Add("Type", 150);

            string server = "localhost";
            string database = "GestionnaireSTL";
            string user = "root";
            string connectionString = "database=" + database + "; server= " + server + ";user =" + user;

            MySqlConnection cnx = new MySqlConnection(connectionString);
            cnx.Open();

            string query = "select * from compte";
            MySqlCommand cmd = new MySqlCommand(query, cnx);

            MySqlDataReader rd = cmd.ExecuteReader();

            if (rd != null)
            {
                while (rd.Read())
                {
                    //Add items in the listview
                    string[] arr = new string[rd.FieldCount];
                    ListViewItem itm;

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
            rd.Close();
            cnx.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
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
