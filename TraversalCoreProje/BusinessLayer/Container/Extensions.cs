using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DTOLayer.Dtos.DuyurularDtos;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IYorumlarService, YorumlarManager>();
            services.AddScoped<IYorumlarDal, EfYorumlarDal>();

            services.AddScoped<IVarisNoktalariService, VarisNoktalariManager>();
            services.AddScoped<IVarisNoktalariDal, EfVarisNoktalariDal>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();

            services.AddScoped<IRezervasyonService, RezervasyonManager>();
            services.AddScoped<IRezervasyonDal, EfRezervasyonDal>();

            services.AddScoped<IRehberlerService, RehberlerManager>();
            services.AddScoped<IRehberDal, EfRehberlerDal>();

            services.AddScoped<IAltHakkimizdaService, AltHakkimizdaManager>();
            services.AddScoped<IAltHakkimizdaDal, EfAltHakkimizdaDal>();

            services.AddScoped<IBizeUlasinService, BizeUlasinManager>();
            services.AddScoped<IBizeUlasDal, EfBizeUlasinDal>();

            services.AddScoped<IHaberBulteniService, HaberBulteniManager>();
            services.AddScoped<IHaberBulteniDal, EfHaberBulteniDal>();

            services.AddScoped<IHakkimizdaService, HakkimizdaManager>();
            services.AddScoped<IHakkimizdaDal, EfHakkimizdaDal>();

            services.AddScoped<IHakkimizda2Service, Hakkimizda2Manager>();
            services.AddScoped<IHakkimizda2Dal, EFHakkimizda2Dal>();

            services.AddScoped<IiletisimService, iletisimManager>();
            services.AddScoped<IiletisimDal, EfiletisimDal>();

            services.AddScoped<IOneCikanlarService, OneCikanlarManager>();
            services.AddScoped<IOneCikanlarDal, EfOneCikanlarDal>();

            services.AddScoped<IOneCikanlar2Service, OneCikanlar2Manager>();
            services.AddScoped<IOneCikanlar2Dal, EfOneCikanlar2Dal>();

            services.AddScoped<IReferanslarService, ReferanslarManager>();
            services.AddScoped<IReferanslarDal, EfReferanslarDal>();

            services.AddScoped<IRehberlerService, RehberlerManager>();
            services.AddScoped<IRehberDal, EfRehberlerDal>();

            services.AddScoped<IDuyurularService, DuyurularManager>();
            services.AddScoped<IDuyurularDal, EfDuyurularDal>();

            services.AddScoped<IExcelService, ExcelManager>();
            services.AddScoped<IPdfService, PdfManager>();
        }

        public static void CustomerValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<DuyurularAddDto>, DuyurularValidator>();
        }
    }
}
