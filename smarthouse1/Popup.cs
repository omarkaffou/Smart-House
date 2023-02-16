using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace smarthouse1
{
    public partial class Popup : Form
    {
        public String name;
        public int xx, yy;
        public Popup(String n, int x , int y)
        {
            InitializeComponent();
            name = n;
            xx = x;
            yy = y;
            
        }

        private void Popup_Load(object sender, EventArgs e)
        {
            loadByName();
           // Dashboard d = new Dashboard();
          
        }

        private void loadByName()
        {
            
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='exam';port=3306;username=root;password=");
                connection.Open();
           
                if (connection.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("select  description   from capteur where nom=@x   ", connection);
                    cmd.Parameters.AddWithValue("@x", name);
                    String USRole = (String)cmd.ExecuteScalar();
                    /*MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {*/
                           textBox1.Text = USRole;
                       
                    //}



                    connection.Close();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='exam';port=3306;username=root;password=");
                connection.Open();
             
                if (connection.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("update capteur set description=@x   where nom = @t ", connection);

                    cmd.Parameters.AddWithValue("@x", textBox1.Text);
                    cmd.Parameters.AddWithValue("@t", name);


                    cmd.ExecuteNonQuery();

                    connection.Close();

                   

                }
            }
            catch (Exception)
            {

                throw;
            }
           
            this.Close();
            load(xx , yy);
        }

        public void load(int x, int y)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='exam';port=3306;username=root;password=");
                connection.Open();
               
                if (connection.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("select id, nom , description , connexion , demarrage, zoneType from capteur where locationX=@x and locationY=@y   ", connection);
                    cmd.Parameters.AddWithValue("@x", x);
                    cmd.Parameters.AddWithValue("@y",y);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr[5].ToString() != "bin")
                        {
                            ListViewItem lv = new ListViewItem(dr[0].ToString());
                            lv.SubItems.Add(dr[1].ToString());
                            lv.SubItems.Add(dr[2].ToString());
                            lv.SubItems.Add(dr[3].ToString());
                            lv.SubItems.Add(dr[4].ToString());
                            lv.SubItems.Add(dr[5].ToString());
                          
                        }

                    }



                    connection.Close();

                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
