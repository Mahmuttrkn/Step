
using BusinessLayer.Abstract;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using ProjeX.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.Controllers
{
    public class ExcelController : Controller
    {
        private readonly IExcelServices excelServices;

        public ExcelController(IExcelServices excelServices)
        {
            this.excelServices = excelServices;
        }

        public IActionResult Index()
        {
            return View();
        }
        public List<DestinationModel> DestinationList()
        {
            List<DestinationModel> destinationModels = new List<DestinationModel>();
            using (var c = new Context())
            {
                destinationModels = c.Destinations.Select(x => new DestinationModel
                {
                    City = x.City,
                    DayNight = x.DayNight,
                    Price = x.Price,
                    Capacity = x.Capacity
                }).ToList();
            }
            return destinationModels;
        }
        public IActionResult StaticExcelReport()
        {
            return File(excelServices.ExcelList(DestinationList()), "application/vnd.openxlmformats-officedocuments.spreadsheetml.sheet", "NewExcel.xlsx");
            //application/vnd.openxlmformats-officedocuments.spreadsheetml.sheet

        }

        public IActionResult DestinationExcelReport()
        {
            using (var workbook=new XLWorkbook())
            {
                var workSheet = workbook.Worksheets.Add("Tur Listesi");
                workSheet.Cell(1, 1).Value = "Şehir";
                workSheet.Cell(1, 2).Value = "Konaklama Süresi";
                workSheet.Cell(1, 3).Value = "Fiyat";
                workSheet.Cell(1, 4).Value = "Kapasite";

                int rowcount = 2;
                foreach (var item in DestinationList())
                {
                    workSheet.Cell(rowcount, 1).Value = item.City;
                    workSheet.Cell(rowcount, 2).Value = item.DayNight;
                    workSheet.Cell(rowcount, 3).Value = item.Price;
                    workSheet.Cell(rowcount, 4).Value = item.Capacity;
                    rowcount++;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxlmformats-officedocuments.spreadsheetml", "newbook.xls");
                }
            }
        }
    }
}
