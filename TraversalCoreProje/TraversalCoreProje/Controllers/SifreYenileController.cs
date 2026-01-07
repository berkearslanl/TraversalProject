using EntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class SifreYenileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SifreYenileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult SifremiUnuttum()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SifremiUnuttum(SifremiUnuttumViewModel p)
        {
            var usermail = await _userManager.FindByEmailAsync(p.Mail);
            string sifreYenileToken = await _userManager.GeneratePasswordResetTokenAsync(usermail);
            var sifreYenileTokenLink = Url.Action("SifremiYenile", "SifreYenile", new
            {
                userId = usermail.Id,
                token = sifreYenileToken
            }, HttpContext.Request.Scheme);



            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mbaFrom = new MailboxAddress("Admin", "berkearslan376@gmail.com");

            mimeMessage.From.Add(mbaFrom);

            MailboxAddress mbaTo = new MailboxAddress("user", p.Mail);

            mimeMessage.To.Add(mbaTo);

            var bodybuilder = new BodyBuilder();
            bodybuilder.TextBody = sifreYenileTokenLink;
            mimeMessage.Body = bodybuilder.ToMessageBody();
            mimeMessage.Subject = "Şifre değişiklik talebi";

            SmtpClient client = new SmtpClient();

            client.Connect("smtp.gmail.com", 587, false);

            client.Authenticate("berkearslan376@gmail.com", "awmx hyyz bpqm pemn ");//p.gonderenmail yerine hangi hesaptan gönderileceği, virgülden sonraki kısım ise google gmail'den oluşturulan uygulama şifresi gelicek

            client.Send(mimeMessage);
            client.Disconnect(true);

            TempData["SuccessMessage"] = "true";
            return View();
        }
        [HttpGet]
        public IActionResult SifremiYenile(string userid, string token)
        {
            TempData["userid"] = userid;
            TempData["token"] = token;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SifremiYenile(SifreYenileViewModel sifreYenileViewModel)
        {
            var userid = TempData["userid"];
            var token = TempData["token"];
            if (userid == null || token == null)
            {
                //hata mesajı
            }
            var user = await _userManager.FindByIdAsync(userid.ToString());
            var result = await _userManager.ResetPasswordAsync(user, token.ToString(), sifreYenileViewModel.Sifre);
            if (result.Succeeded)
            {
                return RedirectToAction("GirisYap", "Login");
            }
            return View();
        }
    }
}
