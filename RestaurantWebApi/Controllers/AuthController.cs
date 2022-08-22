using RestaurantWebApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Comun;
using RestaurantWebApi.Repository.IRepository;
using RestaurantWebApi.Model.Dtos;
using AutoMapper;
using Microsoft.Extensions.Options;
using RestaurantWebApi.Helpers;
using System.Text;

namespace RestaurantWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        private readonly AppSettings _appSettings;
        public AuthController(IConfiguration configuration,
            IUsuarioRepository usuarioRepository,
            IMapper mapper,
            IOptions<AppSettings> appSettings)
        {
            _configuration = configuration;
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }

        //[HttpPost("register")]
        //public async Task<ActionResult<Usuario>> Register(Usuario usr)
        //{
        //    CreatePasswordHash(usr.ClaveUsuario, out byte[] passwordHash, out byte[] passwordSalt);

        //    usuario.NombreUsuario = usr.CodigoUsuario;
        //    usuario.PasswordHash = passwordHash;
        //    usuario.PasswordSalt = passwordSalt;

        //    _context.Usuario.Add(usr);
        //    _context.SaveChanges();

        //    return Ok(usuario);
        //}

        [HttpPost]
        public async Task<IActionResult> Post(UsuarioDto usr)
        {
            UsuarioDto userData = await GetUser(usr.CodigoUsuario);
            if (userData == null) return BadRequest("Usuario incorrecto");
            if (userData.CodigoUsuario != usr.CodigoUsuario) { return BadRequest("Usuario incorrecto"); }

            usr.ClaveUsuario = Encriptacion.Encriptar(usr.ClaveUsuario);

            if (userData.ClaveUsuario != usr.ClaveUsuario) { return BadRequest("Contraseña incorrecta"); }

            var jwt = _configuration.GetSection("Jwt").Get<Jwt>();

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, jwt.Subject),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                new Claim("Id", usr.CodigoUsuario.ToString()),
                new Claim("Password", usr.ClaveUsuario.ToString()),
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_appSettings.Secret));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                jwt.Issuer,
                jwt.Audience,
                claims,
                expires: DateTime.Now.AddMinutes(20),
                signingCredentials: signIn
                );

            return Ok(new
            {
                token = tokenHandler.WriteToken(token)
            });
        }

        [HttpGet]
        public async Task<UsuarioDto> GetUser(string usrname)
        {
            return _mapper.Map<UsuarioDto>(await _usuarioRepository.BuscarUsuarioXCodigo(usrname));
        }

        [HttpGet("Renew")]
        public async Task<IActionResult> Renew()
        {
            if (!HttpContext.Request.Headers.TryGetValue("x-token", out var headerValues))
                return Ok(false);

            UsuarioDto iUsuario = new UsuarioDto();
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            tokenHandler.ValidateToken(headerValues, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
                // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                ClockSkew = TimeSpan.Zero
            }, out SecurityToken validatedToken);
            var jwtToken = (JwtSecurityToken)validatedToken;

            var userId = jwtToken.Claims.First(x => x.Type == "Id").Value.ToString();
            iUsuario.CodigoUsuario = userId.ToString();
            // attach user to context on successful jwt validation
            if (_usuarioRepository.BuscarUsuarioXCodigo(iUsuario.CodigoUsuario) != null)
                return Ok(false);

            return Ok(true);
        }
    }

}
