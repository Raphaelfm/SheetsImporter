using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Order
{
    [Key]
    public int Id { get; set; }
    public int? Pedido { get; set; }
    public string? NF { get; set; }
    public string? Representante { get; set; }
    public string? Cliente { get; set; }
    public string? Municipio { get; set; }
    public string? UF { get; set; }
    public decimal? Valor { get; set; }
    public decimal? Desconto { get; set; }
    public string? PrazoPagamento { get; set; }
    public DateTime? Faturado { get; set; }
    public string? Transporte { get; set; }
    public string? Observacao { get; set; }
    public decimal? ComissaoPercentual { get; set; }
    public decimal? ComissaoValor { get; set; }
}
