using Microsoft.AspNetCore.SignalR;
using SignalRApı.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRApı.Hubs
{
    public class VisitorHubs : Hub
    {
        private readonly VisitorService visitorService;

        public VisitorHubs(VisitorService visitorService)
        {
            this.visitorService = visitorService;
        }
        public async Task GetVisitorTask()
        {
            await Clients.All.SendAsync("CallVisitList","bbb");
        }
    }
}
