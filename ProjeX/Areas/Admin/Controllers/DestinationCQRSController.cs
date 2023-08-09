using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjeX.CQRS.Commands.DestinationCommands;
using ProjeX.CQRS.Heandlers;
using ProjeX.CQRS.Heandlers.DestinationHeandler;
using ProjeX.CQRS.Queries.DestinationQueries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class DestinationCQRSController : Controller
    {
        private readonly GetAllDestinationQueryHeandler getAllDestinationQueryHeandler;
        private readonly GetDestinationByIDHeandler getDestinationByIDHeandler;
        private readonly CreateDestinationHeandler createDestinationHeandler;
        private readonly RemoveDestinationCommandHeandler removeDestinationCommandHeandler;
        private readonly UpdateDestinationHeandler updateDestinationHeandler;

        public DestinationCQRSController(GetAllDestinationQueryHeandler getAllDestinationQueryHeandler, GetDestinationByIDHeandler getDestinationByIDHeandler, CreateDestinationHeandler createDestinationHeandler, RemoveDestinationCommandHeandler removeDestinationCommandHeandler, UpdateDestinationHeandler updateDestinationHeandler)
        {
            this.getAllDestinationQueryHeandler = getAllDestinationQueryHeandler;
            this.getDestinationByIDHeandler = getDestinationByIDHeandler;
            this.createDestinationHeandler = createDestinationHeandler;
            this.removeDestinationCommandHeandler = removeDestinationCommandHeandler;
            this.updateDestinationHeandler = updateDestinationHeandler;
        }

        public IActionResult Index()
        {
            var values = getAllDestinationQueryHeandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult GetDestination(int id)
        {
            var values = getDestinationByIDHeandler.Handle(new GetDestinationByIDQuery(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult GetDestination(UpdateDestinationCommand p)
        {
            updateDestinationHeandler.Handle(p);
            return Redirect("https://localhost:44302/Admin/DestinationCQRS/Index");
        }
        [HttpGet]
        public IActionResult NewDestination()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewDestination(CreateDestinationCommand command)
        {
            createDestinationHeandler.Handle(command);
            return Redirect("https://localhost:44302/Admin/DestinationCQRS/Index");
        }
        public IActionResult DeleteDestination(int id)
        {
            removeDestinationCommandHeandler.Handle(new RemoveDestination(id));
            return Redirect("https://localhost:44302/Admin/DestinationCQRS/Index");
        }
    }
}
