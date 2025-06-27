namespace SistemaDePagamento.Domain
{
    public interface IPagamento
    {
        public string ProcessarPagamento(decimal valor);
    }
}
