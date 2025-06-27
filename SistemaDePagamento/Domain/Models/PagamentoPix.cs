namespace SistemaDePagamento.Domain.Models
{
    sealed class PagamentoPix : Pagamento
    {

        public string ChavePix { get; set; } // Adicionando propriedade para chave Pix

        public PagamentoPix(decimal valor, string chavePix) : base()
        {
            Valor = valor;
            ChavePix = chavePix;
        }
        public override string ProcessarPagamento(decimal valor)
        {
            return ($"Processando pagamento via Pix no valor de R${valor}");
        }
    }
}
