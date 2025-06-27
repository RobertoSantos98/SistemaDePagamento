namespace SistemaDePagamento.Domain.Models
{
    public class PagamentoBoleto : Pagamento
    {
        public PagamentoBoleto(decimal valor) : base()
        {
            Valor = valor;
        }

        public override void ProcessarPagamento(decimal valor)
        {
            Console.WriteLine($"Processando pagamento de boleto no valor de R${valor}");
            Console.WriteLine("Boleto gerado com sucesso!");
        }

    }
}
