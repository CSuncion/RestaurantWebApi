using System;
using System.Collections.Generic;

namespace RestaurantWebApi.Model
{
    public partial class Empresa
    {
        public string CodigoEmpresa { get; set; } = null!;
        public string? NombreEmpresa { get; set; }
        public string? CorreoEmpresa { get; set; }
        public string? RucEmpresa { get; set; }
        public string? DireccionEmpresa { get; set; }
        public string? TelFijoEmpresa { get; set; }
        public string? TelCelularEmpresa { get; set; }
        public string? NextelEmpresa { get; set; }
        public string? LogoEmpresa { get; set; }
        public string? CestadoEmpresa { get; set; }
        public string? CtipoDocumento { get; set; }
        public string? SerieDocumento { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? ConceptoCuotaOrdinaria { get; set; }
        public string? ConceptoCuotaLuz { get; set; }
        public string? ConceptoCuotaAgua { get; set; }
        public string? ConceptoCuotaMora { get; set; }
        public decimal? PorcentajeMora { get; set; }
        public string? UsuarioAgrega { get; set; }
        public DateTime? FechaAgrega { get; set; }
        public string? UsuarioModifica { get; set; }
        public DateTime? FechaModifica { get; set; }
    }
}
