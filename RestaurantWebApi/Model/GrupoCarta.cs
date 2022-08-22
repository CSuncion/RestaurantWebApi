using System;
using System.Collections.Generic;

namespace RestaurantWebApi.Model
{
    public partial class GrupoCarta
    {
        public GrupoCarta()
        {
            Carta = new HashSet<Carta>();
        }

        public int CodGrupoCarta { get; set; }
        public int? CodCategoriaCarta { get; set; }
        public string? NombreGrupoCarta { get; set; }
        public string? Imagen { get; set; }

        public virtual CategoriaCarta? CodCategoriaCartaNavigation { get; set; }
        public virtual ICollection<Carta> Carta { get; set; }
    }
}
