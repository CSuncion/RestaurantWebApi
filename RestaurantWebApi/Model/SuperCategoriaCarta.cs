using System;
using System.Collections.Generic;

namespace RestaurantWebApi.Model
{
    public partial class SuperCategoriaCarta
    {
        public SuperCategoriaCarta()
        {
            CategoriaCarta = new HashSet<CategoriaCarta>();
        }

        public int CodSuperCategoriaCarta { get; set; }
        public string? NombreSuperCategoriaCarta { get; set; }

        public virtual ICollection<CategoriaCarta> CategoriaCarta { get; set; }
    }
}
