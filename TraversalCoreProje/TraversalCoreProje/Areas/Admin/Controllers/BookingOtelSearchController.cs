using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class BookingOtelSearchController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/search?adults_number=2&children_number=2&units=metric&page_number=0&checkin_date=2026-01-31&checkout_date=2026-02-01&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&children_ages=5%2C0&dest_type=city&dest_id=-1456928&order_by=popularity&include_adjacency=true&room_number=1&filter_by_currency=TRY&locale=en-gb"),
                Headers =
    {
        { "x-rapidapi-key", "712dc1f945msh52e24f64c3f962bp126685jsn686cd0552e57" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var bodyReplace = body.Replace(".", "");
                var values = JsonConvert.DeserializeObject<BookingOtelSearchViewModel>(bodyReplace);
                return View(values.result);
            }
        }
        [HttpGet]
        public IActionResult GetCityDestId()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GetCityDestId(string p)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/search?adults_number=2&children_number=2&units=metric&page_number=0&checkin_date=2026-01-31&checkout_date=2026-02-01&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&children_ages=5%2C0&dest_type=city&dest_id=-1456928&order_by=popularity&include_adjacency=true&room_number=1&filter_by_currency=TRY&locale=en-gb&name={p}"),
                Headers =
    {
        { "x-rapidapi-key", "712dc1f945msh52e24f64c3f962bp126685jsn686cd0552e57" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                return View();
            }
        }
    }
}
