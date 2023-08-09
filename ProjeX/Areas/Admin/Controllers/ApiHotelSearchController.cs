using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json;
using ProjeX.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http.Headers;

namespace ProjeX.Areas.Admin.Controllers
{
	[Area("Admin")]
	[AllowAnonymous]
    public class ApiHotelSearchController : Controller
    {
		List<ApiHotelSerchViewModel> apiHotelSerchViewModels = new List<ApiHotelSerchViewModel>();
        public async Task<IActionResult> Index()
        {
			
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?order_by=popularity&adults_number=2&checkin_date=2023-09-27&filter_by_currency=EUR&dest_id=-1746443&locale=en-gb&checkout_date=2023-10-28&units=metric&room_number=1&dest_type=city&include_adjacency=true&children_number=2&page_number=0&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1"),
				Headers =
	{
		{ "X-RapidAPI-Key", "108b4f3832msh5d04dad9da09cb8p15b0dfjsn3ce21d010cf4" },
		{ "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<ApiHotelSerchViewModel>(body);
				//Console.WriteLine(body);
				return View(values.results);
			}
		}
		[HttpGet]
		public IActionResult GetCityID()
        {
			return View();
        }
		[HttpPost]
		public async Task<IActionResult> GetCityID(string p)
        {
			
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name=(p)&locale=en-gb"),
				Headers =
	{
		{ "X-RapidAPI-Key", "108b4f3832msh5d04dad9da09cb8p15b0dfjsn3ce21d010cf4" },
		{ "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
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
