using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class HakkimizdaValidator:AbstractValidator<Hakkimizda>
    {
        public HakkimizdaValidator()
        {
            RuleFor(x => x.Aciklama1).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz ! ");
            RuleFor(x=>x.Resim1).NotEmpty().WithMessage("Lütfen görsel seçiniz ! ");
        }
    }
}
