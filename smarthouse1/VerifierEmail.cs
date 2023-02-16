
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace smarthouse1
{
    public partial class VerifierEmail : Form
    {
       
        public static string email;
        public static string randomcode;
           
        public VerifierEmail(string em , string a )
        {
            InitializeComponent();
            email = em;
            randomcode = a;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (randomcode == (textBox1.Text).ToString())
            {
                MessageBox.Show(email);
               
                Dashboard rp = new Dashboard(email );
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("wrong code");
            }
        }

      

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeForm wf = new WelcomeForm();
            wf.Show();
        }

        private void VerifierEmail_Load(object sender, EventArgs e)
        {

        }
    }
}
