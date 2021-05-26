using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fregla_octava")]
    public partial class FreglaOctava
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Key]
        [Column("fraccion_r8")]
        [StringLength(8)]
        public string FraccionR8 { get; set; }
        [Key]
        [Column("id_pais_origen")]
        [StringLength(4)]
        public string IdPaisOrigen { get; set; }
        [Key]
        [Column("id_regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
        [Column("descripcion_generica")]
        [StringLength(250)]
        public string DescripcionGenerica { get; set; }
        [Key]
        [Column("id_permiso")]
        [StringLength(2)]
        public string IdPermiso { get; set; }
        [Key]
        [Column("numero_permiso")]
        [StringLength(30)]
        public string NumeroPermiso { get; set; }
        [Column("fecha_aplicacion", TypeName = "datetime")]
        public DateTime FechaAplicacion { get; set; }
        [Column("fecha_vigencia", TypeName = "datetime")]
        public DateTime FechaVigencia { get; set; }
        [Required]
        [Column("cve_unidad_comercial")]
        [StringLength(2)]
        public string CveUnidadComercial { get; set; }
        [Column("iden_caso")]
        [StringLength(20)]
        public string IdenCaso { get; set; }
    }
}
