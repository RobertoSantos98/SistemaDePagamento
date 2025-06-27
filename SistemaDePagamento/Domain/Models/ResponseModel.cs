namespace SistemaDePagamento.Domain.Models
{
    public class ResponseModel
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public TipoDePagamento TipoDePagamento { get; set; }
        public decimal Valor { get; set; }
    }
}
