using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using SignalRApı.Dal;
using SignalRApı.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRApı.Model
{
    public class VisitorService 
    {
        private readonly Context context;
        private readonly IHubContext<VisitorHubs> hubContext;

        public VisitorService(Context context, IHubContext<VisitorHubs> hubContext)
        {
            this.context = context;
            this.hubContext = hubContext;
        }
        public IQueryable<Visitor> GetList()
        {
            return context.Visitors.AsQueryable();
        }
        public async Task SaveVisitor(Visitor visitor)
        {
            await context.Visitors.AddAsync(visitor);
            await context.SaveChangesAsync();
            await hubContext.Clients.All.SendAsync("CallVisitorList", "aaa");

        }
        public List<VisitorChart> GetVisitorChartList()
        {
            List<VisitorChart> visitorCharts = new List<VisitorChart>();
            using(var commend = context.Database.GetDbConnection().CreateCommand())
            {
                commend.CommandText = "select * from CrossTab( 'select VisitDate,City,CityVisitCount from Visitors order by 1,2') as ct(VisitDate timestamp,City1 int, City2 int, City3 int, City4 int, City5 int);";
                commend.CommandType = System.Data.CommandType.Text;
                context.Database.OpenConnection();
                using (var reader = commend.ExecuteReader())
                {
                    while
                        (reader.Read()){
                            VisitorChart visitorChart = new VisitorChart();
                        visitorChart.VisitDate = reader.GetDateTime(0).ToShortDateString();
                        Enumerable.Range(1, 5).ToList().ForEach(x =>
                        {
                            visitorChart.Counts.Add(reader.GetInt32(x));
                        });

                        visitorCharts.Add(visitorChart);
                        }
                    }
                context.Database.CloseConnection();
                return visitorCharts;
                }
            }
        }
    }

