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
                    document.Add(new Paragraph("FACTURA FINAL PARA CONSUMIDOR").SetTextAlignment(TextAlignment.LEFT));
                    document.Add(new Paragraph("--------------------------------------------------"));
/*---------------------------------------------------------*/
                    document.Add(new Paragraph("StockManager")
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetBold());
                    document.Add(new Paragraph("Dirección: Calle Principal No. 123")
                        .SetTextAlignment(TextAlignment.LEFT));
                    document.Add(new Paragraph("Teléfono: (809)-809-809")
                        .SetTextAlignment(TextAlignment.LEFT));
                    document.Add(new Paragraph("RNC: 123456789")
                        .SetTextAlignment(TextAlignment.LEFT));
                    document.Add(new Paragraph("Email: StockManager@empresa.com")
                        .SetTextAlignment(TextAlignment.LEFT));
                    document.Add(new Paragraph("--------------------------------------------------"));
/*---------------------------------------------------------*/
                    document.Add(new Paragraph("Cliente:")
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetBold());
                    document.Add(new Paragraph($"Cliente : {clientesBLL.Buscar(venta.ClienteId)?.Nombre} {clientesBLL.Buscar(venta.ClienteId)?.Apellido}").SetTextAlignment(TextAlignment.LEFT));
                    document.Add(new Paragraph($"Dirección: {clientesBLL.Buscar(venta.ClienteId)?.Direccion}").SetTextAlignment(TextAlignment.LEFT));
                    document.Add(new Paragraph($"Telefono: {clientesBLL.Buscar(venta.ClienteId)?.Telefono}").SetTextAlignment(TextAlignment.LEFT));
/*---------------------------------------------------------*/
                    Table table = new Table(4);
                    table.SetWidth(UnitValue.CreatePercentValue(100));

                    table.AddHeaderCell("Producto ID").SetTextAlignment(TextAlignment.LEFT);
                    table.AddHeaderCell("Cantidad").SetTextAlignment(TextAlignment.LEFT);
                    table.AddHeaderCell("Subtotal").SetTextAlignment(TextAlignment.LEFT);
                    table.AddHeaderCell("Precio").SetTextAlignment(TextAlignment.LEFT);

                    foreach (DetallesVenta detalle in venta.detallesVentas)
                    {
                        table.AddCell(new Paragraph(productosBLL.Buscar(detalle.ProductoId)?.Nombre));
                        table.AddCell(new Paragraph(detalle.Cantidad.ToString()));
                        table.AddCell(new Paragraph(detalle.Precio.ToString()));
                        table.AddCell(new Paragraph(detalle.SubTotal.ToString()));
                    }
                    document.Add(new Paragraph("--------------------------------------------------"));
                    /*---------------------------------------------------------*/
                    document.Add(new Paragraph("Detalle:")
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetBold());
                        document.Add(table);
                    document.Add(new Paragraph($"Venta ID: {venta.VentaId}").SetTextAlignment(TextAlignment.LEFT));
                    document.Add(new Paragraph($"Tipo: {venta.Tipo}").SetTextAlignment(TextAlignment.LEFT));
                    document.Add(new Paragraph($"Total: {venta.Total}")
                        .SetTextAlignment(TextAlignment.LEFT));
                    document.Add(new Paragraph($"Fecha: {venta.Fecha}").SetTextAlignment(TextAlignment.LEFT));
                    document.Add(new Paragraph("--------------------------------------------------"));
/*---------------------------------------------------------*/
                    document.Add(new Paragraph("Términos y condiciones:")
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetBold());
                    document.Add(new Paragraph("Pago realizado en efectivo.")
                        .SetTextAlignment(TextAlignment.LEFT));
                    document.Add(new Paragraph("No se aceptan devoluciones de mercancia sin su factura, ni el producto en mal estado.")
                        .SetTextAlignment(TextAlignment.LEFT));
                    document.Add(new Paragraph("--------------------------------------------------"));
                    document.Add(new Paragraph("DevStockManager V1.0")
                        .SetTextAlignment(TextAlignment.RIGHT));
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
