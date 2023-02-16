using MessageBird;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smarthouse1
{

    
    public partial class WelcomeForm : Form
    {
        public string randomcode;
        public static string to;

      
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
             to = textBox1.Text;
           
            sendEmail(textBox1.Text );
        }

        private void sendEmail(string em )
        {
            string from, pass, messageBody;
             Random random = new Random();
             randomcode = (random.Next(9999999)).ToString();
             MailMessage message = new MailMessage();

             to = textBox1.Text ;
             from = "YourEmail@gmail.com";
             pass = "YourPassword";
             messageBody = "votre code est :" + randomcode;
             message.To.Add(to);
             message.From = new MailAddress(from);
             message.Body = messageBody;
             message.Subject = "verification d'email";
             SmtpClient stmp = new SmtpClient("smtp.gmail.com");
             stmp.EnableSsl = true;
             stmp.Port = 587;
             stmp.DeliveryMethod = SmtpDeliveryMethod.Network;
             stmp.Credentials = new NetworkCredential(from, pass);

             try
             {
                 stmp.Send(message);
                 MessageBox.Show("code sent check your email");
                 VerifierEmail ve = new VerifierEmail(em , randomcode );
                 ve.Show();
                 this.Hide();
             }
             catch (Exception ex)
             {

                 MessageBox.Show(ex.Message);
             }
           
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
