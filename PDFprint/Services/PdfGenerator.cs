using DinkToPdf;
using DinkToPdf.Contracts;

namespace PDFprint.Services
{
    public class PdfGenerator
    {
        private readonly IConverter _converter;
        public PdfGenerator(IConverter converter)
        {
            this._converter = converter;
        }
        public byte[] GeneratorPdf(string htmlContent)
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10, Bottom = 5, Left = 10, Right = 10 },
                DocumentTitle = "Generated PDF"
            };
            var objectSetting = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = htmlContent,
                WebSettings = { DefaultEncoding = "utf-8" },

            };
            var document = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSetting }
            };
            return _converter.Convert(document);
        }
    }
}
