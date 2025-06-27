namespace SistemaDePagamento.Domain
{
    public interface IPagamento
    {
        public void ProcessarPagamento(decimal valor);
    }
}
