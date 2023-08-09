using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using SignalRApiForSql.DAL;
using SignalRApiForSql.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRApiForSql.Models
{
    public class VisitorServices
    {
        private readonly Context context;
        private readonly IHubContext<VisitorHubs> hubContext;

        public VisitorServices(Context context, IHubContext<VisitorHubs> hubContext)
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
            await hubContext.Clients.All.SendAsync("CallVisitorList", GetVisitorChartList());

        }
        public List<VisitorChart> GetVisitorChartList()
        {
            List<VisitorChart> visitorCharts = new List<VisitorChart>();
            using (var commend = context.Database.GetDbConnection().CreateCommand())
            {
                commend.CommandText = " select tarih,[1],[2],[3] ,[4] ,[5]  from (select [City],CityVisitCount,CAST([VisitDate] as Date) as tarih from Visitors) as visitTable Pivot (sum(CityVisitCount) for City in ([1], [2], [3], [4], [5])) as pivottable order by tarih asc";
                commend.CommandType = System.Data.CommandType.Text;
                context.Database.OpenConnection();
                using (var reader = commend.ExecuteReader())
                {
                    while
                        (reader.Read())
                    {
                        VisitorChart visitorChart = new VisitorChart();
                        visitorChart.VisitDate = reader.GetDateTime(0).ToShortDateString();
                        Enumerable.Range(1, 5).ToList().ForEach(x =>
                        {
                            if (DBNull.Value.Equals(reader[x]))
                            {
                                visitorChart.Counts.Add(0);
                            }
                            else
                            {
                                visitorChart.Counts.Add(reader.GetInt32(x));
                            }
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
