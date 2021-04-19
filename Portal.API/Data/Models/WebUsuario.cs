using HotChocolate.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portal.API.Models
{
    [Table("WebUsuario")]
    public partial class WebUsuario
    {
        [Key, Column(Order = 0)]
        public short IdAplicacion { get; set; }
        [Key, Column(Order = 1)]
        public string Usuario { get; set; }

        [Column("correo_electronico")]
        public string CorreoElectronico { get; set; }

        [IsProjected(false)]
        [Column("password")]
        public string Password { get; set; }
    }
}
