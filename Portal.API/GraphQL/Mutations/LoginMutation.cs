using HotChocolate;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Portal.API.Context;
using Portal.API.Models;
using Portal.API.Settings;
using Portal.API.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Portal.API.GraphQL.Mutations
{
    public class LoginMutation
    {
        [Display(Description = "Loguear por nombre de usuario y clave")]
        public string Login([Service] AduasisContext contexto, [Service] IOptions<TokenSettings> tokenSettings,  [Required]String usuario, [Required] String password)
        {
            WebUsuario usuarioEncontrado = contexto.WebUsuarios.Where(w => w.IdAplicacion == 1 && w.Usuario == usuario && w.Password == PasswordEncoder.Encriptar(password, usuario)).FirstOrDefault();

            if (usuarioEncontrado != null)
            {
                var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenSettings.Value.Key));
                var credentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

                var claims = new[]
                           {
                                new Claim(ClaimTypes.Role, "A"),
                                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                            };


                var jwtToken = new JwtSecurityToken(
                    issuer: tokenSettings.Value.Issuer,
                    audience: tokenSettings.Value.Audience,
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(200),
                    signingCredentials: credentials
                );

                string token = new JwtSecurityTokenHandler().WriteToken(jwtToken);
                return token;
            }
            return string.Empty;
            // return usuarioEncontrado;
        }

    }
}
