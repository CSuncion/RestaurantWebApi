using System;
using System.Collections.Generic;

namespace RestaurantWebApi.Model
{
    public partial class Carta
    {
        public int CodCarta { get; set; }
        public int? CodCategoriaCarta { get; set; }
        public string NombreCarta { get; set; } = null!;
        public decimal PrecioCarta { get; set; }
        public string? NivelCarta { get; set; }
        public bool? EstadoCarta { get; set; }
        public int? CodGrupoCarta { get; set; }

        public virtual CategoriaCarta? CodCategoriaCartaNavigation { get; set; }
        public virtual GrupoCarta? CodGrupoCartaNavigation { get; set; }
    }
}
