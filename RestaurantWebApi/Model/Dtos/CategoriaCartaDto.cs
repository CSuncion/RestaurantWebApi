namespace RestaurantWebApi.Model.Dtos
{
    public class CategoriaCartaDto
    {
        public int CodCategoriaCarta { get; set; }
        public int? CodSuperCategoriaCarta { get; set; }
        public string NombreCategoriaCarta { get; set; } = null!;
        public decimal? Descuento { get; set; }
        public string? Imagen { get; set; }
    }
}
