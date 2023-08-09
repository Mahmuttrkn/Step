using SignalRApiForSql.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRApiForSql.Hubs
{
    public class VisitorHubs : Hub
    {
        private readonly VisitorServices visitorService;

        public VisitorHubs(VisitorServices visitorService)
        {
            this.visitorService = visitorService;
        }
        public async Task GetVisitorTask()
        {
            await Clients.All.SendAsync("CallVisitList", visitorService.GetVisitorChartList());
        }
    }
}

