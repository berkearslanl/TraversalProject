using BusinessLayer.Abstract;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using DocumentFormat.OpenXml.Wordprocessing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class Raporlar : Controller
    {
        private readonly IExcelService _excelService;

        public Raporlar(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public IActionResult Index()
        {
            return View();
        }
        //Excel İşlemleri
        public List<TurRotalariModel> turRotalariList()
        {
            List<TurRotalariModel> turRotalariModels = new List<TurRotalariModel>();
            using (var c = new Context())
            {
                turRotalariModels = c.VarisNoktalaris.Select(x => new TurRotalariModel
                {
                    Sehir = x.Sehir,
                    GeceGunduz = x.GeceGunduz,
                    Fiyat = x.Fiyat,
                    Kapasite = x.Kapasite
                }).ToList();
            }
            return turRotalariModels;
        }

        public IActionResult StatikExcelRapor()
        {
            //"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "StatikExcel.xlsx"

            return File(_excelService.ExcelList(turRotalariList()), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "YeniExcel1.xlsx");

        }

        public IActionResult turRotalariExcel()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Tur Listesi");
                workSheet.Cell(1, 1).Value = "Şehir";
                workSheet.Cell(1, 2).Value = "Konaklama Süresi";
                workSheet.Cell(1, 3).Value = "Fiyat";
                workSheet.Cell(1, 4).Value = "Kapasite";

                int rowCount = 2;
                foreach (var x in turRotalariList())
                {
                    workSheet.Cell(rowCount, 1).Value = x.Sehir;
                    workSheet.Cell(rowCount, 2).Value = x.GeceGunduz;
                    workSheet.Cell(rowCount, 3).Value = x.Fiyat;
                    workSheet.Cell(rowCount, 4).Value = x.Kapasite;
                    rowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "TurRotalari.xlsx");
                }
            }
        }

        //Pdf İşlemleri

        public IActionResult StatikPdfRapor()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfRaporlari/" + "PdfDosyasi.pdf");

            var stream = new FileStream(path, FileMode.Create);

            iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);

            PdfWriter.GetInstance(document, stream);

            document.Open();
            iTextSharp.text.Paragraph paragraph = new iTextSharp.text.Paragraph("Traversal Rezervasyon Pdf Raporu");
            document.Add(paragraph);
            document.Close();
            return File("/PdfRaporlari/PdfDosyasi.pdf","application/pdf", "statikpdf.pdf");
        }

        public IActionResult StatikMüsteriRapor()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfRaporlari/" + "PdfDosyasi2.pdf");

            var stream = new FileStream(path, FileMode.Create);

            iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);

            PdfWriter.GetInstance(document, stream);

            document.Open();
            PdfPTable pdfPTable = new PdfPTable(3);
            pdfPTable.AddCell("Misafir Ad");
            pdfPTable.AddCell("Misafir Soyad");
            pdfPTable.AddCell("Misafir Tc");

            pdfPTable.AddCell("Eylül");
            pdfPTable.AddCell("Yüccedağ");
            pdfPTable.AddCell("11111111110");

            pdfPTable.AddCell("Kemal");
            pdfPTable.AddCell("Yıldırım");
            pdfPTable.AddCell("22222222220");

            pdfPTable.AddCell("Mehmet");
            pdfPTable.AddCell("Yüccedağ");
            pdfPTable.AddCell("33333333336");

            document.Add(pdfPTable);
            document.Close();
            return File("/PdfRaporlari/PdfDosyasi2.pdf", "application/pdf", "statikpdf2.pdf");
        }




    }
}
