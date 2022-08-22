using System;
using System.Collections.Generic;

namespace RestaurantWebApi.Model
{
    public partial class TipoCambio
    {
        public int IdFam015 { get; set; }
        public string Codemp { get; set; } = null!;
        public string Tipcam { get; set; } = null!;
        public DateTime Feccam { get; set; }
        public decimal? Impcom { get; set; }
        public decimal? Impvta { get; set; }
        public string? EstReg { get; set; }
        public string? CodUsu { get; set; }
        public DateTime? FecReg { get; set; }
    }
}
