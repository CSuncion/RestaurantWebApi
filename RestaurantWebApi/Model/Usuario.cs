using System;
using System.Collections.Generic;

namespace RestaurantWebApi.Model
{
    public partial class Usuario
    {
        public string CodigoUsuario { get; set; } = null!;
        public string? ClaveUsuario { get; set; }
        public string? CodigoPerfil { get; set; }
        public string? NombreUsuario { get; set; }
        public string? DireccionUsuario { get; set; }
        public string? CorreoUsuario { get; set; }
        public string? TelFijoUsuario { get; set; }
        public string? TelCelularUsuario { get; set; }
        public string? FotoUsuario { get; set; }
        public string? CodigoPersonal { get; set; }
        public string? CestadoUsuario { get; set; }
        public string? UsuarioAgrega { get; set; }
        public DateTime? FechaAgrega { get; set; }
        public string? UsuarioModifica { get; set; }
        public DateTime? FechaModifica { get; set; }
    }
}
