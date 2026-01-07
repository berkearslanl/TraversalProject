using DTOLayer.Dtos.AppUserDtos;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Ad).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(x => x.Soyad).NotEmpty().WithMessage("Soyad alanı boş geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez");
            RuleFor(x => x.KullaniciAdi).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez");
            RuleFor(x => x.Sifre).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
            RuleFor(x => x.SifreTekrar).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez");
            RuleFor(x => x.Sifre).Equal(y => y.SifreTekrar).WithMessage("Şifreler eşleşmiyor!");
        }
    }
}
