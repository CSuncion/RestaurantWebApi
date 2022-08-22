namespace RestaurantWebApi.Model.Dtos
{
    public class UsuarioDto
    {
        public string CodigoUsuario { get; set; } = string.Empty;
        public string ClaveUsuario { get; set; } = string.Empty;


    }
    public class Jwt
    {
        public string key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string Subject { get; set; }
    }
}
