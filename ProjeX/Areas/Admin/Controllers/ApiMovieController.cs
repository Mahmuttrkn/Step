using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;
using ProjeX.Areas.Admin.Models;
using Newtonsoft.Json;

namespace ProjeX.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ApiMovieController : Controller
    {
        public async Task<IActionResult> Index()
        {
			List<ApiMovieViewModel> apiMovieViewModels = new List<ApiMovieViewModel>();
			
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://imdb-top-100-movies1.p.rapidapi.com/"),
				Headers =
	{
		{ "X-RapidAPI-Key", "108b4f3832msh5d04dad9da09cb8p15b0dfjsn3ce21d010cf4" },
		{ "X-RapidAPI-Host", "imdb-top-100-movies1.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				apiMovieViewModels = JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);
				//Console.WriteLine(body);
				return View(apiMovieViewModels);
			}
		}
    }
}
