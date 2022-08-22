namespace RestaurantWebApi.Model.Dtos
{
    public class SistemaDto
    {
        public int IdFat001 { get; set; }
        public string Codemp { get; set; } = null!;
        public string NroTab { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string? Descri { get; set; }
        public string? Descrv { get; set; }
        public string? Descr1 { get; set; }
        public string? Descr2 { get; set; }
        public string? Estreg { get; set; }
        public string? Codusu { get; set; }
        public DateTime? Fecreg { get; set; }
    }
}
