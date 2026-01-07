using DTOLayer.Dtos.DuyurularDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class DuyurularValidator:AbstractValidator<DuyurularAddDto>
    {
        public DuyurularValidator()
        {
            RuleFor(x => x.Baslik).NotEmpty().WithMessage("Lütfen başlık alanını doldurunuz!");
            RuleFor(x => x.icerik).NotEmpty().WithMessage("Lütfen duyuru içerik alanını doldurunuz!");
            RuleFor(x => x.Baslik).MinimumLength(5).WithMessage("Lütfen en az 5 karakter girişi yapınız!");
        }
    }
}
