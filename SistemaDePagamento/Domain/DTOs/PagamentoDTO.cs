namespace SistemaDePagamento.Domain.DTOs
{
    public class PagamentoDTO
    {
        public decimal valor { get; set; }
        public TipoDePagamento tipoDePagamento { get; set; }
    }
}
