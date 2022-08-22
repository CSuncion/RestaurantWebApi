namespace RestaurantWebApi.Model.Dtos
{
    public class CartaDto
    {
        public int CodCarta { get; set; }
        public int? CodCategoriaCarta { get; set; }
        public string NombreCarta { get; set; } = null!;
        public decimal PrecioCarta { get; set; }
        public string? NivelCarta { get; set; }
        public bool? EstadoCarta { get; set; }
        public int? CodGrupoCarta { get; set; }
    }
}
