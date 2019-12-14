using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace DryCleaning
{
    public partial class FeedBackForm : Form
    {
        public FeedBackForm()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            openFileDialog1.FileName = "";
        }

        public void MySendMail(string bodyMail, string nameAuthor, string subject)
        {
            string body = "<html><head> " +
    "</head><body><center>Уведомление<br/> " +
    "<img src=\"https://img.freepik.com/free-vector/abstract-dynamic-pattern-wallpaper-vector_53876-59131.jpg?size=338&ext=jpg\"/>" +
    "</center></br></body></html>";

            try
            {
                // Отправитель
                var from = new MailAddress(tbFrom.Text.ToString(), nameAuthor);

                // Кому отправляем
                var to = new MailAddress("andrey5062@yandex.ru");

                // адрес smtp-сервера и порт, с которого будем отправлять письмо
                SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587);

                // логин и пароль
                smtp.Credentials = new NetworkCredential(from.Address, "Pa$$w0rd");
                smtp.EnableSsl = true;

                // Создаем объект сообщения
                MailMessage mail = new MailMessage(from, to);

                // Указываем, что письмо с кодом html
                mail.IsBodyHtml = true;

                // Записываем тему письма
                mail.Subject = subject;

                // Содержимое пиьсма
                mail.Body = body + bodyMail;
                smtp.Send(mail);
                MessageBox.Show("Сообщение доставлено!", "Информационное письмо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка отправки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            //file = openFileDialog1.FileName;
            // Перадаем значения в класс MySendMail
            MySendMail(tbBody.Text, tbTema.Text, tbFrom.Text);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
