using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fgenerales_rutas")]
    public partial class FgeneralesRuta
    {
        [Key]
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Key]
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Key]
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("shcp_validacion")]
        [StringLength(150)]
        public string ShcpValidacion { get; set; }
        [Column("shcp_error")]
        [StringLength(150)]
        public string ShcpError { get; set; }
        [Column("banco_validacion")]
        [StringLength(150)]
        public string BancoValidacion { get; set; }
        [Column("banco_error")]
        [StringLength(150)]
        public string BancoError { get; set; }
        [Column("sagar_validacion")]
        [StringLength(150)]
        public string SagarValidacion { get; set; }
        [Column("sagar_error")]
        [StringLength(150)]
        public string SagarError { get; set; }
        [Column("prevalidacion_error")]
        [StringLength(150)]
        public string PrevalidacionError { get; set; }
    }
}
