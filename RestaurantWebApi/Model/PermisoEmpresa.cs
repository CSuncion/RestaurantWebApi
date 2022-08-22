using System;
using System.Collections.Generic;

namespace RestaurantWebApi.Model
{
    public partial class PermisoEmpresa
    {
        public string ClavePermisoEmpresa { get; set; } = null!;
        public string? CodigoEmpresa { get; set; }
        public string? CodigoUsuario { get; set; }
        public string? Cpermitir { get; set; }
        public string? UsuarioAgrega { get; set; }
        public DateTime? FechaAgrega { get; set; }
        public string? UsuarioModifica { get; set; }
        public DateTime? FechaModifica { get; set; }
    }
}
