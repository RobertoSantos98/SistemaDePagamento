namespace SistemaDePagamento.Domain.Models
{
    public class PagamentoCartao : Pagamento
    {
        public string NumeroCartao { get; set; }

        public PagamentoCartao(decimal valor, string numeroCartao) : base()
        {
            Valor = valor;
            NumeroCartao = numeroCartao;
        }
        public override string ProcessarPagamento(decimal valor)
        {
            return $"Processando pagamento com cartão no valor de R${valor}";
        }
    }
}
