using Core.Entities;
using ClosedXML.Excel;

namespace Core.Services;

public class ExcelParserService
{
    public List<Order> ParseExcelFile(Stream excelFileStream)
    {
        using var workbook = new XLWorkbook(excelFileStream);
        var worksheet = workbook.Worksheet(1);

        return worksheet.RowsUsed().Skip(1).Select(row => new Order
        {
            Pedido = int.Parse(row.Cell(1).Value.ToString()),
            NF = row.Cell(2).Value.ToString(),
            Representante = row.Cell(3).Value.ToString(),
            Cliente = row.Cell(4).Value.ToString(),
            Municipio = row.Cell(5).Value.ToString(),
            UF = row.Cell(6).Value.ToString(),
            Valor = decimal.Parse(row.Cell(7).Value.ToString()),
            Desconto = decimal.Parse(row.Cell(8).Value.ToString()),
            PrazoPagamento = row.Cell(9).Value.ToString(),
            Faturado = DateTime.Parse(row.Cell(10).Value.ToString()),
            Transporte = row.Cell(11).Value.ToString(),
            Observacao = row.Cell(12).Value.ToString(),
            ComissaoPercentual = decimal.Parse(row.Cell(13).Value.ToString()),
            ComissaoValor = decimal.Parse(row.Cell(14).Value.ToString())
        }).ToList();
    }
}
