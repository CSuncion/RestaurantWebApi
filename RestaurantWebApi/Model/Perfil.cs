using System;
using System.Collections.Generic;

namespace RestaurantWebApi.Model
{
    public partial class Perfil
    {
        public string CodigoPerfil { get; set; } = null!;
        public string? NombrePerfil { get; set; }
        public string? DescripcionPerfil { get; set; }
        public string? CestadoPerfil { get; set; }
        public string? EliminablePerfil { get; set; }
        public string? UsuarioAgrega { get; set; }
        public DateTime? FechaAgrega { get; set; }
        public string? UsuarioModifica { get; set; }
        public DateTime? FechaModifica { get; set; }
    }
}
