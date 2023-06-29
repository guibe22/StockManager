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
                    logo.SetHeight(50);
                    logo.SetWidth(200); 
                    document.Add(logo);

                    document.Add(new Paragraph($"Venta ID: {venta.VentaId}"));
                    document.Add(new Paragraph($"Cliente ID: {clientesBLL.Buscar(venta.ClienteId)?.Nombre}"));
                    document.Add(new Paragraph($"Tipo: {venta.Tipo}"));
                    document.Add(new Paragraph($"Total: {venta.Total}"));
                    document.Add(new Paragraph($"Fecha: {venta.Fecha}"));
                    document.Add(new Paragraph("Detalles:"));

                    Table table = new Table(4);
                    table.AddHeaderCell("Producto ID");
                    table.AddHeaderCell("Cantidad");
                    table.AddHeaderCell("Subtotal");
                    table.AddHeaderCell("Precio");

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
