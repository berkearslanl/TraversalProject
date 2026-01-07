using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.Dtos.MailDtos
{
    public class MailAddDto
    {
        public string GonderenMail { get; set; }
        public string Ad { get; set; }
        public string AliciMail { get; set; }
        public string Konu { get; set; }
        public string icerik { get; set; }
    }
}
