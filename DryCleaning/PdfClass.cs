using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryCleaning
{
    class PdfClass
    {
        public void ExportWordToPdf(string path)
        {
            try
            {
                Application word = new Application();
                Document file = word.Documents.Open(path);
                file.ExportAsFixedFormat(path + "info_pdf.pdf", WdExportFormat.wdExportFormatPDF);
            }
            catch
            {

            }

        }
    }
}
