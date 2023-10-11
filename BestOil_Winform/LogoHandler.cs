using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace BestOil_Winform
{
    public class LogoHandler:PdfPageEventHelper
    {
        public override void OnEndPage(PdfWriter writer, Document document)
        {
            base.OnEndPage(writer, document);

            System.Drawing.Image logoImage = Properties.Resources.oil_market_for_pdf; 
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoImage, BaseColor.WHITE);

           
            logo.SetAbsolutePosition(50, 750);
            logo.ScaleAbsolute(100, 100); 

            
            writer.DirectContent.AddImage(logo);
        }

    }
}
