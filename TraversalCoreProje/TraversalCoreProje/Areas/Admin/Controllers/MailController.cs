using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(MailRequest p)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mbaFrom = new MailboxAddress("Admin", p.GonderenMail);//p.gonderen mail yerine hangi hesaptan gönderileceği

            mimeMessage.From.Add(mbaFrom);

            MailboxAddress mbaTo = new MailboxAddress("user",p.AliciMail);

            mimeMessage.To.Add(mbaTo);

            var bodybuilder = new BodyBuilder();
            bodybuilder.TextBody = p.icerik;
            mimeMessage.Body = bodybuilder.ToMessageBody();

            mimeMessage.Subject = p.Konu;

            SmtpClient client = new SmtpClient();

            client.Connect("smtp.gmail.com",587,false);

            client.Authenticate(p.GonderenMail, "123456aA-");//p.gonderenmail yerine hangi hesaptan gönderileceği, virgülden sonraki kısım ise google gmail'den oluşturulan uygulama şifresi gelicek

            client.Send(mimeMessage);
            client.Disconnect(true);
            return View();
        }
    }
}
