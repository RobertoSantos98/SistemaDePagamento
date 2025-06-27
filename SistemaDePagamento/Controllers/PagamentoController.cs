using Microsoft.AspNetCore.Mvc;
using SistemaDePagamento.Application.Service;
using SistemaDePagamento.Domain.DTOs;
using SistemaDePagamento.Domain.Models;

namespace SistemaDePagamento.Controllers
{
    [ApiController]
    [Route("api/v1/pagamentos")]
    public class PagamentoController : ControllerBase
    {
        private readonly IPagamentoService _pagamentoService;

        public PagamentoController(IPagamentoService service)
        {
            _pagamentoService = service;
        }

        [HttpPost]
        public async Task<IActionResult> EfetuarPagamento([FromBody] PagamentoDTO pagamento)
        {
            var response = await _pagamentoService.ProcessarPagamentoAsync(pagamento.tipoDePagamento, pagamento.valor);

            return Ok(response);
        }
    }
}
