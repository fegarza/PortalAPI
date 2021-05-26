using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("dig_archivo")]
    [Index(nameof(IdAplicacion), nameof(IdModulo), nameof(IdDocumento), nameof(IdReferencia), Name = "NCL_REFERENCIA")]
    public partial class DigArchivo
    {
        [Key]
        [Column("id_aplicacion")]
        [StringLength(10)]
        public string IdAplicacion { get; set; }
        [Key]
        [Column("id_modulo")]
        [StringLength(20)]
        public string IdModulo { get; set; }
        [Key]
        [Column("id_documento")]
        public short IdDocumento { get; set; }
        [Key]
        [Column("id_referencia")]
        [StringLength(100)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("secuencial")]
        public short Secuencial { get; set; }
        [Required]
        [Column("referencia")]
        [StringLength(50)]
        public string Referencia { get; set; }
        [Column("direccion")]
        [StringLength(250)]
        public string Direccion { get; set; }
        [Column("nombre_archivo")]
        [StringLength(250)]
        public string NombreArchivo { get; set; }
        [Column("extension")]
        [StringLength(4)]
        public string Extension { get; set; }
        [Column("interno")]
        public bool Interno { get; set; }
        [Column("usuario_ingreso")]
        [StringLength(6)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column("observaciones")]
        public string Observaciones { get; set; }
        [Column("compactado")]
        public bool? Compactado { get; set; }
        [Column("tipo")]
        public byte? Tipo { get; set; }
    }
}
