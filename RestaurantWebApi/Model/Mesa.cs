using System;
using System.Collections.Generic;

namespace RestaurantWebApi.Model
{
    public partial class Mesa
    {
        public int CodMesa { get; set; }
        public string? NombreMesa { get; set; }
        public string? TipoMesa { get; set; }
        public bool? EstadoMesa { get; set; }
    }
}
