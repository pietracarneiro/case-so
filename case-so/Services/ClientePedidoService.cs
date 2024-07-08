using case_so.Models;
using case_so.Services.Interfaces;

namespace case_so.Services
{
    public class ClientePedidoService : IClientePedidoServices
    {
        private readonly MasterContext _context;

        public ClientePedidoService(MasterContext context)
        {
            _context = context;
        }

        public async Task InserirClienteEPedidoAsync(Cliente cliente, Pedido pedido)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                _context.Clientes.Add(cliente);
                await _context.SaveChangesAsync();

                pedido.ClienteId = cliente.ClienteId;
                _context.Pedidos.Add(pedido);
                await _context.SaveChangesAsync();

                await transaction.CommitAsync();
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }
    }
}
