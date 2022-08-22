using System;
using System.Collections.Generic;

namespace RestaurantWebApi.Model
{
    public partial class Cliente
    {
        public long IdFam010 { get; set; }
        public string Codemp { get; set; } = null!;
        public string Tipcli { get; set; } = null!;
        public string Codcli { get; set; } = null!;
        public string? Razsoc { get; set; }
        public string? Razcom { get; set; }
        public string? Contac { get; set; }
        public string? Codubi { get; set; }
        public string? Direcc { get; set; }
        public string? Correo { get; set; }
        public string? Nrotel { get; set; }
        public string? Nrocel { get; set; }
        public string? Nrodni { get; set; }
        public string? Codofi { get; set; }
        public string? Estcli { get; set; }
        public string? Codusu { get; set; }
        public DateTime? Fecreg { get; set; }
    }
}
