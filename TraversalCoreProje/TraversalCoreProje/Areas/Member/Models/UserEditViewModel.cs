namespace TraversalCoreProje.Areas.Member.Models
{
    public class UserEditViewModel
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string sifre { get; set; }
        public string sifretekrar { get; set; }
        public string telefonno { get; set; }
        public string mail { get; set; }
        public string resimurl { get; set; }
        public IFormFile resim { get; set; }
    }
}
