using case_so.Models.NovaPasta;
using case_so.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace case_so.Controllers
{
    [ApiController]
    [Route("api/clientespedidos")]
    public class ClientesPedidosController : ControllerBase
    {
        private readonly IClientePedidoServices _clientesPedidoService;

        public ClientesPedidosController(IClientePedidoServices clientesPedidoService)
        {
            _clientesPedidoService = clientesPedidoService;
        }

        [HttpPost]
        public async Task<IActionResult> PostPedido([FromBody] ClientePedidoDTO clientePedidoDTO)
        {
            try
            {
                await _clientesPedidoService.InserirClienteEPedidoAsync(clientePedidoDTO.Cliente, clientePedidoDTO.Pedido);
                return Ok("Pedido inserido com sucesso.");
            }
            catch (Exception)
            {
                return BadRequest("Falha ao inserir o pedido.");
            }
        }
    }
}
