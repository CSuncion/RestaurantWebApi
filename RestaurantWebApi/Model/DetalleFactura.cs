using System;
using System.Collections.Generic;

namespace RestaurantWebApi.Model
{
    public partial class DetalleFactura
    {
        public long IdFad210 { get; set; }
        public string Codemp { get; set; } = null!;
        public string Tipdoc { get; set; } = null!;
        public int Nroser { get; set; }
        public int Nrodoc { get; set; }
        public int Nroite { get; set; }
        public string? Codpro { get; set; }
        public decimal? Impcos { get; set; }
        public int? Cantid { get; set; }
        public decimal? Impvta { get; set; }
        public string? Estpro { get; set; }
        public string? Codusu { get; set; }
        public DateTime? Fecreg { get; set; }
    }
}
