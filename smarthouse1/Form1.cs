using MessageBird;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smarthouse1
{
    public partial class Dashboard : Form
    {
        public static int tmp = 0;
        List<Coordonne> points = new List<Coordonne>();
        public static int xx = 0;
        public static int yy = 0;
        public static bool stat = false;
        public static String etatDeDemarrage;
        public static String decon;
        public static String demarra;
        public static String em;
       
        public Dashboard(string e )
        {
            InitializeComponent();
            em = e;
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ajouterDansZone1(String nom, String des, String etatC, String etatD, String zone, int lx, int ly)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='exam';port=3306;username=root;password=");
                connection.Open();
                listView1.Items.Clear();

                if (connection.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("insert into capteur (nom , description   , connexion , demarrage , zoneType , locationX , locationY) values (@nom , @description , @connexion , @demarrage , @zoneType , @lx , @ly  ) ", connection);
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@description", des);
                    cmd.Parameters.AddWithValue("@connexion", etatC);
                    cmd.Parameters.AddWithValue("@demarrage", etatD);
                    cmd.Parameters.AddWithValue("@zoneType", zone);
                    cmd.Parameters.AddWithValue("@lx", lx);
                    cmd.Parameters.AddWithValue("@ly", ly);
                    cmd.ExecuteNonQuery();
                   
                    connection.Close();

                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        void button_click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            
          

            DialogResult res = MessageBox.Show("modifier emplacement : ok // afficher les information : no", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            Rectangle r = new Rectangle(btn.Location.X, btn.Location.Y, btn.Size.Width, btn.Size.Height);
            Rectangle b = new Rectangle(panel3.Location.X, panel3.Location.Y, panel3.Size.Width, panel3.Size.Height);
            Rectangle bd1 = new Rectangle(bedroom1.Location.X, bedroom1.Location.Y, bedroom1.Size.Width, bedroom1.Size.Height);
            Rectangle bd2 = new Rectangle(bedroom2.Location.X, bedroom2.Location.Y, bedroom2.Size.Width, bedroom2.Size.Height);
            Rectangle lr = new Rectangle(livingroom.Location.X, livingroom.Location.Y, livingroom.Size.Width, livingroom.Size.Height);
            Rectangle dr = new Rectangle(diningroom.Location.X, diningroom.Location.Y, diningroom.Size.Width, diningroom.Size.Height);
            Rectangle kc = new Rectangle(kitchen.Location.X, kitchen.Location.Y, kitchen.Size.Width, kitchen.Size.Height);
            Rectangle ed = new Rectangle(panel2.Location.X, panel2.Location.Y, panel2.Size.Width, panel2.Size.Height);


            if (res == DialogResult.Yes)
            {
             
                   

                if (r.IntersectsWith(bd1))
                {
                   
                    if (verifyIfExists(btn.Name))
                    {
                          updateButton(btn.Name , btn.Location.X, btn.Location.Y , "bedroom1");
                       
                    }
                    else
                    {
                       
                        ajouterDansZone1(btn.Name, "description", "connecter", "arreter", "bedroom1", btn.Location.X, btn.Location.Y);
                        Popup pp = new Popup(btn.Name , btn.Location.X, btn.Location.Y);
                        pp.Show();
                        load(btn.Location.X, btn.Location.Y);
                        dem.Visible = true;
                        dec.Visible = true;
                        holder.Text = btn.Name;
                    }
                   
                }else if (r.IntersectsWith(bd2))
                {
                    if (verifyIfExists(btn.Name))
                    {
                       
                        updateButton(btn.Name, btn.Location.X, btn.Location.Y, "bedroom2");
                       
                    }
                    else
                    {
                        
                        ajouterDansZone1(btn.Name, "description", "connecter", "arreter", "bedroom2", btn.Location.X, btn.Location.Y);
                        load(btn.Location.X, btn.Location.Y);
                        dem.Visible = true;
                        dec.Visible = true;
                        holder.Text = btn.Name;
                    }
                }
                else if (r.IntersectsWith(lr))
                {
                    if (verifyIfExists(btn.Name))
                    {
                        updateButton(btn.Name, btn.Location.X, btn.Location.Y, "livingroom");

                    }
                    else
                    {
                       
                        ajouterDansZone1(btn.Name, "description", "connecter", "arreter", "livingroom", btn.Location.X, btn.Location.Y);
                        load(btn.Location.X, btn.Location.Y);
                        dem.Visible = true;
                        dec.Visible = true;
                        holder.Text = btn.Name;
                    }
                }
                else if (r.IntersectsWith(dr))
                {
                    if (verifyIfExists(btn.Name))
                    {
                        updateButton(btn.Name, btn.Location.X, btn.Location.Y, "diningroom");

                    }
                    else
                    {
                        
                        ajouterDansZone1(btn.Name, "description", "connecter", "arreter", "diningroom", btn.Location.X, btn.Location.Y);
                        load(btn.Location.X, btn.Location.Y);
                        dem.Visible = true;
                        dec.Visible = true;
                        holder.Text = btn.Name;
                    }
                }
                else if (r.IntersectsWith(kc))
                {
                    if (verifyIfExists(btn.Name))
                    {
                        updateButton(btn.Name, btn.Location.X, btn.Location.Y, "kitchen");

                    }
                    else
                    {
                      
                        ajouterDansZone1(btn.Name, "description", "connecter", "arreter", "kitchen", btn.Location.X, btn.Location.Y);
                        load(btn.Location.X, btn.Location.Y);
                        dem.Visible = true;
                        dec.Visible = true;
                        holder.Text = btn.Name;
                    }
                }
                else if (r.IntersectsWith(b))
                {
                  
                  
                    if (verifyIfExists(btn.Name))
                    {
                        updateButton(btn.Name, btn.Location.X, btn.Location.Y, "bin");
                        deleteAllUiButtons();
                        uploadButtons();
                      

                    }
                }
                else if (r.IntersectsWith(ed))
                {

                  
                    if (verifyIfExists(btn.Name))
                    {
                         Popup p = new Popup(btn.Name  , btn.Location.X, btn.Location.Y);
                       
                         p.Show();
                        
                        if (stat)
                        {
                            deleteAllUiButtons();
                            uploadButtons();
                        }

                    }
                   
                }

                this.Refresh();
            }
            if (res == DialogResult.No)
            {
                xx = btn.Location.X;
                yy = btn.Location.Y;
                load(btn.Location.X , btn.Location.Y);
                dem.Visible = true;
                dec.Visible = true;
                deconnecterT.Visible = false;
                demarrerT.Visible = false;
                holder.Text = btn.Name;
            decon =     getDecEtat(btn.Name);
             demarra=   getDecEtat(btn.Name);
                deleteAllUiButtons();
                uploadButtons();
               
            }

           


        }

      private void button_In(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='exam';port=3306;username=root;password=");
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("select  demarrage   from capteur where nom=@x   ", connection);
                    cmd.Parameters.AddWithValue("@x", btn.Name);
                    String USRole = (String)cmd.ExecuteScalar();

                    if (USRole == "arreter")
                    {
                        etatDeDemarrage = btn.Text;
                        btn.Text = "arreter";
                    }
                    else
                    {
                        etatDeDemarrage = btn.Text;
                        btn.Text = "demarrer";
                    }


                    connection.Close();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button_Out(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Text = etatDeDemarrage;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Button b = new Button();

            this.Controls.Add(b);
          
            b.Name = getLatestId().ToString();
            b.Text = getLatestId().ToString();
            b.BackColor = Color.Green;
            b.Size = new Size(75, 23);
            b.Font = new Font("inion Pro", 8);
            b.Padding = new Padding(0);
         
            b.BringToFront();
           
            b.MouseEnter += new EventHandler(this.button_In);
            b.MouseLeave += new EventHandler(this.button_Out);
            b.MouseUp += new MouseEventHandler(this.button_click);
         
            ControlExtension.Draggable(b, true);
        }

        private void bedroom2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void load()
        {
            dem.Visible = false;
            dec.Visible = false;
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='exam';port=3306;username=root;password=");
                connection.Open();
                listView1.Items.Clear();
                if (connection.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("select id, nom , description, connexion , demarrage  , zoneType from capteur   ", connection);

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
                        listView1.Items.Add(lv);
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

        public  void load(int x , int y)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='exam';port=3306;username=root;password=");
                connection.Open();
                listView1.Items.Clear();
                if (connection.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("select id, nom , description , connexion , demarrage, zoneType from capteur where locationX=@x and locationY=@y   ", connection);
                    cmd.Parameters.AddWithValue("@x", x);
                    cmd.Parameters.AddWithValue("@y", y);
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
                        listView1.Items.Add(lv);
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

        public void delete(String name)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='exam';port=3306;username=root;password=");
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("delete from capteur where  nom = @nom   ", connection);
                    cmd.Parameters.AddWithValue("@nom", name);

                    MessageBox.Show("sds");
                    connection.Close();

                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void loadButtons()
        {
           
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='exam';port=3306;username=root;password=");
                connection.Open();
           
                if (connection.State == ConnectionState.Open) {

                   // Button btn = new Button();
                   
                    int i = 0;
                    MySqlCommand cmd = new MySqlCommand("select * from capteur", connection);

                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr.GetString(5) != "bin")
                        {

                            if (dr.GetString(3) == "connecter")
                            {
                                Button b = addButton(dr.GetString(1), dr.GetInt32(6), dr.GetInt32(7));
                                b.BackColor = Color.Green;
                            }
                            else if (dr.GetString(3) == "deconnecter")
                            {
                                Button b = addButton(dr.GetString(1), dr.GetInt32(6), dr.GetInt32(7));
                                b.BackColor = Color.Red;
                            }
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


        private void bedroom1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void updateButton(String t , int x , int y, String room)
        {
           
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='exam';port=3306;username=root;password=");
                connection.Open();
                listView1.Items.Clear();
                if (connection.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("update capteur set locationX=@x , locationY=@y , zoneType=@type  where nom = @t ", connection);
                    
                    cmd.Parameters.AddWithValue("@x", x);
                    cmd.Parameters.AddWithValue("@y", y);
                    cmd.Parameters.AddWithValue("@t", t);
                    cmd.Parameters.AddWithValue("@type", room);

                    cmd.ExecuteNonQuery();

                    connection.Close();
                   
                    this.Refresh();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uploadButtons();
          
        }

        private bool verifyIfExists(String t)
        {
            bool a = false;
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='exam';port=3306;username=root;password=");
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("select count(*) from capteur where nom = @t  ", connection);
                    cmd.Parameters.AddWithValue("@t" , t);
                  
                    Int64 recordExists = (Int64)cmd.ExecuteScalar();
                    if (recordExists >0)
                    {
                        a =  true;
                    }
                    else
                    {
                        a= false;
                    }
                    connection.Close();

                }
            }
            catch (Exception)
            {

                throw;
            }
            return a;
        }

        private void uploadButtons()
        {

           
            loadButtons();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            ListViewItem item = listView1.SelectedItems[0];
          

            holder.Text = item.SubItems[0].Text;
          
            dec.Visible = true;

            if (item.SubItems[3].Text == "connecter")
            {
                dec.Text = "deconnecter";
                dem.Text = "demarrer";
                dem.Visible = true;
            }
            else
            {
                dec.Text = "connecter";
                dem.Visible = false;
            }

           
            
        }
    


        private Button addButton(String n , int x , int y)
        {
            Button b = new Button();

            this.Controls.Add(b);

            b.Name =n;
            b.Text = n;
            b.Size = new Size(75, 23);
            b.Font = new Font("inion Pro", 8);
          
            b.BringToFront();
           b.Location = new Point(x , y);            

            b.MouseUp += new MouseEventHandler(this.button_click);
            b.MouseEnter += new EventHandler(this.button_In);
            b.MouseLeave += new EventHandler(this.button_Out);
         
            ControlExtension.Draggable(b, true);
            return b;
        }


        private int getLatestId()
        {

            int a = 0 ;
           
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='exam';port=3306;username=root;password=");
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT id FROM capteur WHERE id=(SELECT max(id) FROM capteur); ", connection);
                    Int32 recordExists = (Int32)cmd.ExecuteScalar();

                    a = ((int)recordExists);
                    connection.Close();

                }
            }
            catch (Exception)
            {

                throw;
            }
            return a+1;
        }

   
        private void dec_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            if (dec.Text == "connecter")
            {
                dec.Text = "deconnecter";
               connecterDevice("connecter");
            
                dem.Visible = true;

            }
            else if(dec.Text == "deconnecter")
            {
                dec.Text = "connecter";
                connecterDevice("deconnecter");
                
                dem.Visible = false;
            }
            deleteAllUiButtons();
            this.Refresh();
            loadButtons();
           
        }

        private void dem_Click(object sender, EventArgs e)
        {
            if (dem.Text == "arreter")
            {
                dem.Text = "demarrer";
                startDevice("arreter");
            }else if (dem.Text == "demarrer")
            {
                startDevice("demarrer");
                dem.Text = "arreter";
            }
            deleteAllUiButtons();
            this.Refresh();
            loadButtons();
           
        }

        private void connecterDevice(String etat)
        {
            
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='exam';port=3306;username=root;password=");
                connection.Open();
              
                if (connection.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("update capteur set  connexion=@etat  where nom = @t ", connection);

                    cmd.Parameters.AddWithValue("@etat", etat);
                    cmd.Parameters.AddWithValue("@t", holder.Text);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
            load(xx, yy);
          
        }

        private void startDevice(String etat)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='exam';port=3306;username=root;password=");
                connection.Open();
                
                if (connection.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("update capteur set  demarrage=@etat  where nom = @t ", connection);

                    cmd.Parameters.AddWithValue("@etat", etat);
                    cmd.Parameters.AddWithValue("@t", holder.Text);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }

            load(xx , yy);
           
        }

            private void startOstopAll(String etat)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='exam';port=3306;username=root;password=");
                connection.Open();
                listView1.Items.Clear();
                if (connection.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("update capteur set  demarrage=@etat  ", connection);

                    cmd.Parameters.AddWithValue("@etat", etat);
                    cmd.ExecuteNonQuery();

                    connection.Close();

                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }


        private void connectOdisconnectAll(String etat)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='exam';port=3306;username=root;password=");
                connection.Open();
                listView1.Items.Clear();
                if (connection.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("update capteur set  connexion=@etat  ", connection);

                    cmd.Parameters.AddWithValue("@etat", etat);
                    cmd.ExecuteNonQuery();

                    connection.Close();




                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void deleteAllUiButtons()
        {
            List<Button> buttons = this.Controls.OfType<Button>().ToList();
            foreach (var control in this.Controls)
            {
                if (control is Button )
                {
                  
                    buttons.Add((Button)control);
                }
            }

            foreach ( Button btn in buttons)
            {
             
                this.Controls.Remove(btn);
            }

        }

        private void deconnecterT_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("vous etes sure d'effectuer cet operation ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (res == DialogResult.Yes)
            {
                if (deconnecterT.Text == "deconnecterT")
                {
                    connectOdisconnectAll("deconnecter");
                    deconnecterT.Text = "connecterT";
                    demarrerT.Visible = false;
                    test.Visible = false;
                }
                else if (deconnecterT.Text == "connecterT")
                {
                    connectOdisconnectAll("connecter");
                    deconnecterT.Text = "deconnecterT";
                    demarrerT.Visible = true;
                    test.Visible = true;
                }
                deleteAllUiButtons();
                loadButtons();
                load();
            }
            else
            {

            }
           
            
        }

        private void demarrerT_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("vous etes sure d'effectuer cet operation ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            load();
            if (res == DialogResult.Yes)
            {
                if (demarrerT.Text == "demarrerT")
                {
                    startOstopAll("demarrer");
                    demarrerT.Text = "arreterT";
                }
                else if (demarrerT.Text == "arreterT")
                {
                    startOstopAll("arreter");
                    demarrerT.Text = "demarrerT";
                }
                deleteAllUiButtons();
                loadButtons();
                load();
            }
               
               
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
         
            deconnecterT.Visible = true;
            load();
        }

        private void bedroom2_MouseClick(object sender, MouseEventArgs e)
        {
            listView1.Items.Clear();
           
            loadByRoom("bedroom2");
        }


        private void loadByRoom(String room)
        {

            demarrerT.Visible = false;
            deconnecterT.Visible = false;
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='exam';port=3306;username=root;password=");
                connection.Open();
                listView1.Items.Clear();
                if (connection.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("select id, nom , description , connexion , demarrage , zoneType from capteur where zoneType=@x   ", connection);
                    cmd.Parameters.AddWithValue("@x", room);
                   
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ListViewItem lv = new ListViewItem(dr[0].ToString());
                        lv.SubItems.Add(dr[1].ToString());
                        lv.SubItems.Add(dr[2].ToString());
                        lv.SubItems.Add(dr[3].ToString());
                        lv.SubItems.Add(dr[4].ToString());
                        lv.SubItems.Add(dr[5].ToString());
                        listView1.Items.Add(lv);
                    }



                    connection.Close();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void bedroom1_MouseClick(object sender, MouseEventArgs e)
        {

         
            listView1.Items.Clear();
            demarrerT.Visible = false;
            deconnecterT.Visible = false;
            loadByRoom("bedroom1");
        }

        private void kitchen_MouseClick(object sender, MouseEventArgs e)
        {
            listView1.Items.Clear();
            demarrerT.Visible = false;
            deconnecterT.Visible = false;
            loadByRoom("kitchen");
        }

        private void diningroom_MouseClick(object sender, MouseEventArgs e)
        {
            listView1.Items.Clear();
            demarrerT.Visible = false;
            deconnecterT.Visible = false;
            loadByRoom("diningroom");
        }

        private void livingroom_MouseClick(object sender, MouseEventArgs e)
        {
            listView1.Items.Clear();
            demarrerT.Visible = false;
            deconnecterT.Visible = false;
            loadByRoom("livingroom");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteAllUiButtons();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadButtons();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            test.Visible = false;
            listView1.Items.Clear();
            dem.Visible = false;
            dec.Visible = false;
            deconnecterT.Visible = false;
            demarrerT.Visible = false;
        }

        private void bin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private String getDecEtat(String n)
        {
            String USRole="";
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='exam';port=3306;username=root;password=");
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("select  connexion   from capteur where nom=@x   ", connection);
                    cmd.Parameters.AddWithValue("@x", n);
                     USRole = (String)cmd.ExecuteScalar();
                   



                    connection.Close();

                }
            }
            catch (Exception)
            {

                throw;
            }
            return USRole;

        }

      

        private void test_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            button1.Visible = true;
            label6.Visible = true;
            test.Visible = false;
            listView1.Visible = false;
            deconnecterT.Visible = false;
            demarrerT.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteAllUiButtons();
         
            loadButtons();
            sendphoneAsync();
            lancerEvenement(comboBox1.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            test.Visible = true;
            label6.Visible = false;
            button1.Visible = false;
            listView1.Visible = true;
            deconnecterT.Visible = true;
            demarrerT.Visible = true;
            deleteAllUiButtons();
           
            loadButtons();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void lancerEvenement(string ev)
        {
           
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='exam';port=3306;username=root;password=");
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {

                  

                    int i = 0;
                    MySqlCommand cmd = new MySqlCommand("select * from capteur ", connection);
                  
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr.GetString(2) == ev && dr.GetString(5) != "bin" )
                        {

                                Button b = addButton(dr.GetString(1), dr.GetInt32(6), dr.GetInt32(7));
                                b.BackColor = Color.Yellow;

                        }
                    }

                    sendMessage(ev);
                   

                    connection.Close();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void sendphoneAsync()
        {
            const string YourAccessKey = "IWABV8596hPKZaYgX5lltDSJZ"; // your access key here , make sure you install messagebird 
            Client client = Client.CreateDefault(YourAccessKey);
          const long Msisdn = +222222222; // your phone number here
         
            MessageBird.Objects.Message message =
            client.SendMessage("OMAR CHAKIR", "WARNING", new[] { Msisdn });
        }

        private void sendMessage(string s)
        {
            string from, pass, messageBody;
           
           
            MailMessage message = new MailMessage();
            string to = em;
            from = "YourEmail@gmail.com";
            pass = "YourPassword";
            messageBody = "attention le " +s+ " a detecter un danger"   ;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "attention le " + s + " a detecter un danger";
            SmtpClient stmp = new SmtpClient("smtp.gmail.com");
            stmp.EnableSsl = true;
            stmp.Port = 587;
            stmp.DeliveryMethod = SmtpDeliveryMethod.Network;
            stmp.Credentials = new NetworkCredential(from, pass);

            try
            {
                stmp.Send(message);
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }
    }


}
