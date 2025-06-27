namespace SistemaDePagamento.Domain.Models
{
    public class Pagamento : IPagamento
    {
        public decimal Valor { get; set; }


        public virtual string ProcessarPagamento(decimal pagamento)
        {
            return ($"Processando pagamento de R${pagamento}");
        }

    }
}
