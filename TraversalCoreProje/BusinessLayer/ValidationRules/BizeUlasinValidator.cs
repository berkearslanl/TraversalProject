using DTOLayer.Dtos.iletisimDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BizeUlasinValidator:AbstractValidator<iletisimAddDto>
    {
        public BizeUlasinValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez");
            RuleFor(x => x.Konu).NotEmpty().WithMessage("Konu alanı boş geçilemez");
            RuleFor(x => x.icerik).NotEmpty().WithMessage("Mesaj alanı boş geçilemez");
        }
    }
}
