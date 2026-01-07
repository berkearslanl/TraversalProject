using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRApi.Dal;
using SignalRApi.Model;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        private readonly VisitorService _visitorService;

        public VisitorController(VisitorService visitorService)
        {
            _visitorService = visitorService;
        }
        //[HttpGet]
        //public IActionResult CreateVisitor()
        //{
        //    Random rnd = new Random();
        //    Enumerable.Range(1, 10).ToList().ForEach(x =>
        //    {
        //        foreach (Ecity item in Enum.GetValues(typeof(Ecity)))
        //        {
        //            var newVisitor = new Visitor
        //            {
        //                City = item,
        //                CityVisitCount = rnd.Next(100, 2000),
        //                VisitDate = DateTime.Now.AddDays(x)
        //            };
        //            _visitorService.SaveVisitor(newVisitor).Wait();
        //            System.Threading.Thread.Sleep(1000);
        //        }
        //    });
        //    return Ok("Ziyaretçiler başarılı bir şekilde eklendi!");
        //}
        [HttpGet]
        public async Task<IActionResult> CreateVisitor() // async ve Task ekledik
        {
            Random rnd = new Random();
            // ForEach içinde await kullanabilmek için normal bir döngü daha sağlıklıdır
            for (int x = 1; x <= 10; x++)
            {
                foreach (Ecity item in Enum.GetValues(typeof(Ecity)))
                {
                    var newVisitor = new Visitor
                    {
                        City = item,
                        CityVisitCount = rnd.Next(100, 2000),
                        VisitDate = DateTime.Now.AddDays(x)
                    };

                    // .Wait() yerine await kullanıyoruz
                    await _visitorService.SaveVisitor(newVisitor);

                    System.Threading.Thread.Sleep(1000); // Test amaçlıysa kalabilir
                }
            }
            return Ok();
        }
    }
}
