using System;
using System.Collections.Generic;

namespace RestaurantWebApi.Model
{
    public partial class CabeceraFactura
    {
        public long IdFad200 { get; set; }
        public string Codemp { get; set; } = null!;
        public string Tipdoc { get; set; } = null!;
        public int Nroser { get; set; }
        public int Nrodoc { get; set; }
        public DateTime? Fecdoc { get; set; }
        public string? Tipcli { get; set; }
        public string? Codcli { get; set; }
        public string? Modvta { get; set; }
        public string? Forpag { get; set; }
        public string? Tipdpa { get; set; }
        public string? Nrodpa { get; set; }
        public DateTime? Fecdpa { get; set; }
        public decimal? Mondpa { get; set; }
        public string? Codmon { get; set; }
        public decimal? Tipcam { get; set; }
        public decimal? Monbru { get; set; }
        public decimal? Impdsc { get; set; }
        public decimal? Impigv { get; set; }
        public decimal? Monnet { get; set; }
        public int? Cuocre { get; set; }
        public string? Estdoc { get; set; }
        public string? Codusu { get; set; }
        public DateTime? Fecreg { get; set; }
    }
}
