using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjeX.CQRS.Commands.GuideCommands;
using ProjeX.CQRS.Queries.GuideQueries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class GuideMediatRController : Controller
    {
        private readonly IMediator mediator;

        public GuideMediatRController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await mediator.Send(new GetAllGuideQuery());
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> GetGuides(int id)
        {
            var values = await mediator.Send(new GetGuideByIDQuery(id));
            return View(values);
        }
       [HttpGet]
       public IActionResult AddGuide()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddGuide(CreateGuideCommmand p)
        {
            await mediator.Send(p);
            return Redirect("https://localhost:44302/Admin/GuideMediatR/Index");
        }

    }
}
