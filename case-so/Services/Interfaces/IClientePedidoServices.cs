using case_so.Models;

namespace case_so.Services.Interfaces
{
    public interface IClientePedidoServices
    {
        Task InserirClienteEPedidoAsync(Cliente cliente, Pedido pedido);
    }
}
