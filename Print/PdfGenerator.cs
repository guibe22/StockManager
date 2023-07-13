using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Image;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Drawing.Printing;

public class PdfGenerator
{
    string logoPath = "wwwroot\\logo.png";
    static DbContextOptions<Contexto> options = new DbContextOptionsBuilder<Contexto>()
   .UseSqlite("Data Source=Data\\StockManager.db")
   .Options;
    static Contexto contexto = new Contexto(options);
    ClientesBLL clientesBLL = new ClientesBLL(contexto);
    ProductosBLL productosBLL = new ProductosBLL(contexto);
    public void GeneratePdf(Ventas venta, string filePath)
    {
        using (PdfWriter writer = new PdfWriter(filePath))
        {
            using (PdfDocument pdf = new PdfDocument(writer))
            {
                using (Document document = new Document(pdf))
                {
                    Image logo = new Image(ImageDataFactory.Create(logoPath));
                    logo.SetHeight(100);
                    logo.SetWidth(100);
                    logo.SetHorizontalAlignment(HorizontalAlignment.CENTER);
                    document.Add(logo);


                    document.Add(new Paragraph($"Venta ID: {venta.VentaId}").SetTextAlignment(TextAlignment.CENTER));
                    document.Add(new Paragraph($"Cliente : {clientesBLL.Buscar(venta.ClienteId)?.Nombre} {clientesBLL.Buscar(venta.ClienteId)?.Apellido}").SetTextAlignment(TextAlignment.CENTER));
                    document.Add(new Paragraph($"Tipo: {venta.Tipo}").SetTextAlignment(TextAlignment.CENTER));
                    document.Add(new Paragraph($"Total: {venta.Total}").SetTextAlignment(TextAlignment.CENTER));
                    document.Add(new Paragraph($"Fecha: {venta.Fecha}").SetTextAlignment(TextAlignment.CENTER));
                    document.Add(new Paragraph("Detalles:").SetTextAlignment(TextAlignment.CENTER));

                    Table table = new Table(4);
                    table.SetWidth(UnitValue.CreatePercentValue(100));

                    table.AddHeaderCell("Producto ID").SetTextAlignment(TextAlignment.CENTER);
                    table.AddHeaderCell("Cantidad").SetTextAlignment(TextAlignment.CENTER);
                    table.AddHeaderCell("Subtotal").SetTextAlignment(TextAlignment.CENTER);
                    table.AddHeaderCell("Precio").SetTextAlignment(TextAlignment.CENTER);

                    foreach (DetallesVenta detalle in venta.detallesVentas)
                    {
                        table.AddCell(new Paragraph(productosBLL.Buscar(detalle.ProductoId)?.Nombre));
                        table.AddCell(new Paragraph(detalle.Cantidad.ToString()));
                        table.AddCell(new Paragraph(detalle.Precio.ToString()));
                        table.AddCell(new Paragraph(detalle.SubTotal.ToString()));
                    }

                    document.Add(table);
                    document.Add(new Paragraph("--------------------------------------------------"));
                }
            }
        }
        System.Diagnostics.Process.Start(new ProcessStartInfo
        {
            FileName = filePath,
            UseShellExecute = true
        });
    }
}
