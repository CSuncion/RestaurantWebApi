using System;
using System.Collections.Generic;

namespace RestaurantWebApi.Model
{
    public partial class Producto
    {
        public long IdFam020 { get; set; }
        public string Codemp { get; set; } = null!;
        public string Codpro { get; set; } = null!;
        public string Nompro { get; set; } = null!;
        public decimal? Precos { get; set; }
        public decimal? Marcom { get; set; }
        public decimal? Prevta { get; set; }
        public decimal? Prevts { get; set; }
        public string? Estpro { get; set; }
        public string? Codusu { get; set; }
        public DateTime? Fecreg { get; set; }
        public string Unimed { get; set; } = null!;
        public decimal? Salstk { get; set; }
        public string? Codmon { get; set; }
    }
}
