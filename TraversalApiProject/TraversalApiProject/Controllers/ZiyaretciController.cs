using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TraversalApiProject.DAL.Context;
using TraversalApiProject.DAL.Entities;

namespace TraversalApiProject.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class ZiyaretciController : ControllerBase
    {
        [HttpGet]
        public IActionResult ziyaretciListesi()
        {
            using (var context = new ZiyaretciContext())
            {
                var values = context.ziyaretcis.ToList();
                return Ok(values);
            }
        }
        [HttpPost]
        public IActionResult ziyaretciEkle(Ziyaretci p)
        {
            using (var context = new ZiyaretciContext())
            {
                context.ziyaretcis.Add(p);
                context.SaveChanges();
                return Ok();
            }
        }
        [HttpGet("{id}")]
        public IActionResult ziyaretciGetir(int id)
        {
            using (var context = new ZiyaretciContext())
            {
                var values = context.ziyaretcis.Find(id);
                if (values==null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(values);
                }
            }
        }
        [HttpDelete("{id}")]
        public IActionResult ziyaretciSil(int id)
        {
            using (var context = new ZiyaretciContext())
            {
                var values = context.ziyaretcis.Find(id);
                if (values == null)
                {
                    return NotFound();
                }
                else
                {
                    context.Remove(values);
                    context.SaveChanges();
                    return Ok();
                }
            }
        }
        [HttpPut]
        public IActionResult ziyaretciGuncelle(Ziyaretci p)
        {
            using (var context = new ZiyaretciContext())
            {
                var values = context.ziyaretcis.Find(p.ZiyaretciID);
                if (values == null)
                {
                    return NotFound();
                }
                else
                {
                    values.Sehir = p.Sehir;
                    values.Ad = p.Ad;
                    values.Soyad = p.Soyad;
                    values.Ülke = p.Ülke;
                    values.Mail = p.Mail;
                    context.Update(values);
                    context.SaveChanges();
                    return Ok();
                }
            }
        }
    }
}
