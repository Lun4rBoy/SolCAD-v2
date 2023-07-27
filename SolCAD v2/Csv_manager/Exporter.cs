using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using SolCAD_v2.Models;
using Document = iText.Layout.Document;

namespace SolCAD_v2.Csv_manager
{
    public class Exporter
    {
        public static string pdfFolder = Path.Combine(Inicio.rootDirectory, "Pdf files");
        public static void ExportToPDF(string c1,string c2, string c3, string c4)
        {
            if (!Directory.Exists(pdfFolder))
            {
                Directory.CreateDirectory(pdfFolder);
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de proyecto Solcad (*.pdf)|*.pdf";

            saveFileDialog.InitialDirectory = pdfFolder;
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            try
            {
                var filePath = saveFileDialog.FileName;
                PdfWriter writer = new PdfWriter(filePath);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);
                document.SetMargins(36, 45, 36, 45);
                Paragraph header = new Paragraph("INFORME SolCAD")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(20);
                document.Add(header);
                Paragraph subheader = new Paragraph("Reporte de diseño sistema fotovoltaico")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(15);
                document.Add(subheader);
                LineSeparator ls = new LineSeparator(new SolidLine());
                document.Add(ls);
                Paragraph subheader2 = new Paragraph("Colector Solar")
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontSize(15);
                document.Add(subheader2);
                Paragraph colectorParagraph = new Paragraph(c1).SetFontSize(11);
                document.Add(colectorParagraph);
                document.Add(ls);

                Paragraph subheader3 = new Paragraph("Almacenamiento de energia")
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontSize(15);
                document.Add(subheader3);
                Paragraph almacenamientoParagraph = new Paragraph(c2).SetFontSize(11);
                document.Add(almacenamientoParagraph);
                document.Add(ls);
                Paragraph subheader4 = new Paragraph("Conversor de energia")
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontSize(15);
                document.Add(subheader4);
                Paragraph conversorParagraph = new Paragraph(c3).SetFontSize(11);
                document.Add(conversorParagraph);
                document.Add(ls);
                document.Add(new AreaBreak());
                Paragraph subheader5 = new Paragraph("Otros materiales")
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontSize(15);
                document.Add(subheader5);
                Paragraph otrosParagraph = new Paragraph(c4).SetFontSize(11);
                document.Add(otrosParagraph);
                document.Add(ls);

                document.Close();

                MessageBox.Show("El informe se ha guardado correctamente.", "Guardar archivo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }
    }
}
