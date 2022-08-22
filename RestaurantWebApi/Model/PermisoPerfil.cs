using System;
using System.Collections.Generic;

namespace RestaurantWebApi.Model
{
    public partial class PermisoPerfil
    {
        public string ClavePermisoPerfil { get; set; } = null!;
        public string? CodigoVentana { get; set; }
        public string? CodigoBoton { get; set; }
        public string? CodigoPerfil { get; set; }
        public string? Cpermitir { get; set; }
    }
}
