using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("funidades_facturacion")]
    public partial class FunidadesFacturacion
    {
        [Key]
        [Column("id_unidad_facturacion")]
        [StringLength(4)]
        public string IdUnidadFacturacion { get; set; }
        [Required]
        [Column("descripcion_larga")]
        [StringLength(50)]
        public string DescripcionLarga { get; set; }
        [Required]
        [Column("desc_corta")]
        [StringLength(10)]
        public string DescCorta { get; set; }
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
        [Column("c_ClaveUnidad")]
        [StringLength(3)]
        public string CClaveUnidad { get; set; }
        [Column("NombreSAT")]
        [StringLength(100)]
        public string NombreSat { get; set; }
    }
}
