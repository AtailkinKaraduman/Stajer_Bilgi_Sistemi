using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StajerBilSis2
{
    public partial class FrmMailForm : Form
    {
        public FrmMailForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string fromEmail = "denemetr9@hotmail.com";
                string fromEmailPassword = "123456789C#p+ECSS";
                string toEmail = textBox1.Text;
                string subject = textBox2.Text;
                string body = textBox3.Text;
                string attachmentFilePath = "basvuruform.pdf";
                using (var message = new MailMessage(fromEmail, toEmail))
                {
                    message.Subject = subject;
                    message.Body = body;
                    Attachment attachment = new Attachment(attachmentFilePath);
                    message.Attachments.Add(attachment);
                    using (var client = new SmtpClient("smtp.office365.com", 587))
                    {
                        client.EnableSsl = true;
                        client.Timeout = 30000; // 10 seconds (adjust as needed)
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential(fromEmail, fromEmailPassword);
                        client.Send(message);
                    }
                }

                MessageBox.Show("Mail sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
