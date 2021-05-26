using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("wdigitalizacion_referencia")]
    public partial class WdigitalizacionReferencium
    {
        [Key]
        [Column("id_aplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_referencia")]
        [StringLength(20)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_modulo")]
        public short IdModulo { get; set; }
        [Key]
        [Column("documento")]
        public int Documento { get; set; }
        [Key]
        [Column("numero")]
        [StringLength(50)]
        public string Numero { get; set; }
        [Required]
        [Column("archivoWeb")]
        [StringLength(250)]
        public string ArchivoWeb { get; set; }
        [Column("usuario_ingreso")]
        [StringLength(6)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
    }
}
