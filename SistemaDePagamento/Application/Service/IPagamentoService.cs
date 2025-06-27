using SistemaDePagamento.Domain;
using SistemaDePagamento.Domain.Models;

namespace SistemaDePagamento.Application.Service
{
    public interface IPagamentoService
    {
        Task<ResponseModel> ProcessarPagamentoAsync(TipoDePagamento tipoDePagamento, decimal valor);
    }
}
