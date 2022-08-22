using System;
using System.Collections.Generic;

namespace RestaurantWebApi.Model
{
    public partial class CategoriaCarta
    {
        public CategoriaCarta()
        {
            Carta = new HashSet<Carta>();
            GrupoCarta = new HashSet<GrupoCarta>();
        }

        public int CodCategoriaCarta { get; set; }
        public int? CodSuperCategoriaCarta { get; set; }
        public string NombreCategoriaCarta { get; set; } = null!;
        public decimal? Descuento { get; set; }
        public string? Imagen { get; set; }

        public virtual SuperCategoriaCarta? CodSuperCategoriaCartaNavigation { get; set; }
        public virtual ICollection<Carta> Carta { get; set; }
        public virtual ICollection<GrupoCarta> GrupoCarta { get; set; }
    }
}
