using System;
using System.Collections.Generic;

namespace case_so.Models;

public partial class Pedido
{
    public int PedidoId { get; set; }

    public int ClienteId { get; set; }

    public DateTime DataPedido { get; set; }

    public decimal ValorTotal { get; set; }

    public virtual Cliente? Cliente { get; set; }
}
