using HotChocolate;
using HotChocolate.AspNetCore.Authorization;
using HotChocolate.Data;
using Portal.API.Context;
using Portal.API.Models;
using Portal.API.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Portal.API.GraphQL.Queries
{
    [Display(Name = "WebUsuairo", Description = "Todo lo referente a los usuarios del sistema")]
    public class WebUsuarioQuery
    {
        [UseProjection]
        [Authorize(Roles = new [] {"A"})]
        [Display(Description = "Obtener todos los usuarios")]
        public IEnumerable<WebUsuario> GetAllWebUsuarios([Service] AduasisContext _contexto)
        {
            return _contexto.WebUsuarios;
        }

        [UseProjection]
        [Display(Description = "Loguear por nombre de usuario y clave")]
        public WebUsuario Login([Service] AduasisContext contexto, String usuario, String password) 
        {
            
            WebUsuario usuarioEncontrado = contexto.WebUsuarios.Where(w => w.IdAplicacion == 1 && w.Usuario == usuario && w.Password == PasswordEncoder.Encriptar(password, usuario)).FirstOrDefault();
           
            /*
            string ROL = "A";
            var claims = new[]
            {
                                new Claim(ClaimTypes.Role, ROL),
                                new Claim("rol",  ROL),
                                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                            };
            //var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("wW7pPV7ngghwWxpNLc7N8SQPhjXcPQEMtHwpfiknpJqkr5aX1kSDsNnndqWLXWkx"));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiration = DateTime.UtcNow.AddHours(5);
            JwtSecurityToken token = new JwtSecurityToken(
                issuer: "dominio.com",
                audience: "dominio.com",
                claims: claims,
                expires: expiration,
                signingCredentials: credentials
            );

            var tokenS = new JwtSecurityTokenHandler().WriteToken(token);*/
            return usuarioEncontrado;
        }

    }
}
