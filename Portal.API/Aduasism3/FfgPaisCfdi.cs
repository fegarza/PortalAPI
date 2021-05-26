using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_paisCFDI")]
    public partial class FfgPaisCfdi
    {
        [Key]
        [Column("id_paisCFDI")]
        public byte IdPaisCfdi { get; set; }
        [Column("fecha_captura", TypeName = "datetime")]
        public DateTime FechaCaptura { get; set; }
        [Required]
        [Column("c_Pais")]
        [StringLength(3)]
        public string CPais { get; set; }
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ultmodif", TypeName = "datetime")]
        public DateTime? FechaUltmodif { get; set; }
        [Required]
        [Column("id_usuario_ultmodif")]
        [StringLength(6)]
        public string IdUsuarioUltmodif { get; set; }
    }
}
