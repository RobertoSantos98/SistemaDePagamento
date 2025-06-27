namespace SistemaDePagamento.Domain.Models
{
    public class Pagamento : IPagamento
    {
        public decimal Valor { get; set; }


        public virtual void ProcessarPagamento(decimal pagamento)
        {
            Console.WriteLine($"Processando pagamento de R${pagamento}");
        }

    }
}
