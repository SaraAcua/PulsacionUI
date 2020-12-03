using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Entity;


namespace Infraestructura
{
    public class EnviarEmail

    {
        private MailMessage email;
        private SmtpClient smtp;
        public EnviarEmail()
        {
            smtp = new SmtpClient();
        }
      
        private void ConfigurarSmt()
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("katerinmurcia6@gmail.com", "colombiana");
        }
        private void ConfigurarEmail(Persona persona)
        {
            email = new MailMessage();
            email.To.Add(persona.Email);
            email.From = new MailAddress("MiAplicacion@miempresa.com");
            email.Subject = "Registro de Usuario "
                + DateTime.Now.ToString("dd/MMM/yyy hh:mm:ss");
            email.Body = $"<b>Sr {persona.Nombre }</b> <br " +
                $" > Se ha realizado su registro Satisfactoriamente";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
        }

        public string EnviaEmail(Persona persona)
        {

            try
            {
                ConfigurarSmt();
                ConfigurarEmail(persona);
                smtp.Send(email);
                return ("Correo enviado a  Satifactoriamente");
            }
            catch (Exception e)
            {

                return ("error al enviar correo" + e.Message);
            }
            finally
            {
                email.Dispose();
            }
        }

    }
}
