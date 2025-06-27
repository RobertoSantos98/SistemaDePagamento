using SistemaDePagamento.Domain;
using SistemaDePagamento.Domain.Models;

namespace SistemaDePagamento.Application.Service
{
    public class PagamentoService : IPagamentoService
    {
        public Task<ResponseModel> ProcessarPagamentoAsync(TipoDePagamento tipoDePagamento, decimal valor)
        {
            ResponseModel resposta = new ResponseModel();

            IPagamento pagamento = tipoDePagamento switch
            {
                TipoDePagamento.Cartao => new PagamentoCartao(valor, null),
                TipoDePagamento.Boleto => new PagamentoBoleto(valor),
                TipoDePagamento.Pix => new PagamentoPix(valor, null),
            };

            resposta.TipoDePagamento = tipoDePagamento;
            resposta.Message = pagamento.ProcessarPagamento(valor);
            resposta.Success = true;
            resposta.Valor = valor;


            return Task.FromResult( resposta );

            
        }

    }
}
