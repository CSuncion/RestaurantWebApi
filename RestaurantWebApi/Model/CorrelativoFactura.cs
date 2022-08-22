using System;
using System.Collections.Generic;

namespace RestaurantWebApi.Model
{
    public partial class CorrelativoFactura
    {
        public long IdFat002 { get; set; }
        public string Codemp { get; set; } = null!;
        public string Tipdoc { get; set; } = null!;
        public int? Nroser { get; set; }
        public int? Ultdoc { get; set; }
        public string? Estreg { get; set; }
        public string? Codusu { get; set; }
        public DateTime? Fecreg { get; set; }
    }
}
