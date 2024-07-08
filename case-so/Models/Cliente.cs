using System;
using System.Collections.Generic;

namespace case_so.Models;

public partial class Cliente
{
    public int ClienteId { get; set; }

    public string Nome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
