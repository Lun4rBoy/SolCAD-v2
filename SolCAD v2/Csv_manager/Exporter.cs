using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using iText.IO.Image;
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
        public static void ExportToPDF(string c1,
            string c2, 
            string c3, 
            string c4, 
            string c5, 
            List<Consumo>? listcom,
            Table? ahorro,
            bool chk,
            Chart? chrAhorro,
            Chart chrBaterias,
            TabPage mimico
        )
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
                var writer = new PdfWriter(filePath);
                var pdf = new PdfDocument(writer);
                Document document = new Document(pdf);
                document.SetMargins(36, 45, 36, 45);
                Paragraph whiteSpace = new Paragraph(" ").SetFontSize(11);
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
                ///////////////////////////////////////////////////////////////////

                Paragraph subheader6 = new Paragraph("Ubicacion")
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontSize(15);
                document.Add(subheader6);
                Paragraph ubicacionParagraph = new Paragraph(c5).SetFontSize(11);
                document.Add(ubicacionParagraph);
                document.Add(ls);

                Paragraph subheader2 = new Paragraph("Colector Solar")
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontSize(15);
                document.Add(subheader2);
                Paragraph colectorParagraph = new Paragraph(c1).SetFontSize(11);
                document.Add(colectorParagraph);
                document.Add(ls);
                //document.Add(new AreaBreak());

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
                
                Paragraph subheader5 = new Paragraph("Otros materiales")
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontSize(15);
                document.Add(subheader5);
                Paragraph otrosParagraph = new Paragraph(c4).SetFontSize(11);
                document.Add(otrosParagraph);
                //document.Add(ls);
                document.Add(new AreaBreak());
                Table table = new Table(8);
                table.SetTextAlignment(TextAlignment.RIGHT);
                table.SetFontSize(10);
                table.AddCell("Qty");
                table.AddCell("Nombre");
                table.AddCell("PotenciaA");
                table.AddCell("PorcentajeA");
                table.AddCell("PotenciaB");
                table.AddCell("PorcentajeB");
                table.AddCell("Promedio");
                table.AddCell("SubTotal");

                foreach (var consumo in listcom)
                {
                    table.AddCell(consumo.Qty.ToString());
                    table.AddCell(consumo.Nombre);
                    table.AddCell(consumo.PotenciaA.ToString());
                    table.AddCell((consumo.PorcentajeA * 100)+"%");
                    table.AddCell(consumo.PotenciaB.ToString());
                    table.AddCell((consumo.PorcentajeB * 100)+"%");
                    table.AddCell(consumo.Promedio.ToString());
                    table.AddCell(consumo.SubTotal.ToString());
                }

                Paragraph subheader7 = new Paragraph("Listado de consumo")
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontSize(15);
                document.Add(subheader7);
                document.Add(table);

                if (chk)
                {
                    document.Add(whiteSpace);
                    document.Add(ls);
                    Paragraph subheader8 = new Paragraph("Tabla de Ahorro")
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(15);
                    document.Add(subheader8);
                    document.Add(ahorro);
                    document.Add(whiteSpace);
                    document.Add(whiteSpace);

                    using (MemoryStream ms = new MemoryStream())
                    {
                        chrAhorro.SaveImage(ms, ImageFormat.Png);
                        iText.Layout.Element.Image imageAhorro = new iText.Layout.Element.Image(ImageDataFactory.Create(ms.ToArray()));
                        imageAhorro.ScaleToFit(500, 450);
                        document.Add(imageAhorro);
                        document.Add(whiteSpace);
                        document.Add(whiteSpace);
                    }
                }

                document.Add(new AreaBreak());
                Paragraph subheader9 = new Paragraph("Comportamiento de baterias")
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(15);
                document.Add(subheader9);

                using (MemoryStream ms = new MemoryStream())
                {
                    chrBaterias.SaveImage(ms, ImageFormat.Png);
                    iText.Layout.Element.Image imageBateria = new iText.Layout.Element.Image(ImageDataFactory.Create(ms.ToArray()));
                    imageBateria.ScaleToFit(500, 450);
                    document.Add(imageBateria);
                }

                Bitmap screenshot = new Bitmap(mimico.Width, mimico.Height);

                using (Graphics graphics = Graphics.FromImage(screenshot))
                {
                    Point controlLocation = mimico.PointToScreen(Point.Empty);
                    graphics.CopyFromScreen(controlLocation, Point.Empty, mimico.Size);
                }

                document.Add(new AreaBreak());
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    screenshot.Save(memoryStream, ImageFormat.Png);
                    byte[] imageBytes = memoryStream.ToArray();

                    iText.Layout.Element.Image image = new iText.Layout.Element.Image(ImageDataFactory.Create(imageBytes));

                    image.SetRotationAngle(Math.PI/2);
                    float maxWidth = document.GetPdfDocument().GetDefaultPageSize().GetWidth() - document.GetLeftMargin() - document.GetRightMargin();
                    image.SetAutoScale(true);
                    image.SetMaxWidth(UnitValue.CreatePointValue(maxWidth));
                    document.Add(image);
                }

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
