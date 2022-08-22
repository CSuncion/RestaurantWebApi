using System;
using System.Collections.Generic;

namespace RestaurantWebApi.Model
{
    public partial class PermisoUsuario
    {
        public string ClavePermisoUsuario { get; set; } = null!;
        public string? CodigoVentana { get; set; }
        public string? CodigoBoton { get; set; }
        public string? CodigoUsuario { get; set; }
        public string? Cpermitir { get; set; }
    }
}
