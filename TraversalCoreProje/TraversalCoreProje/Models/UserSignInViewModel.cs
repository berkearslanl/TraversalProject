using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adını giriniz!")]
        public string KullaniciAdi { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz!")]
        public string Sifre { get; set; }
    }
}
