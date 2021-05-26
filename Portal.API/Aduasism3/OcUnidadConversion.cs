using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_unidad_conversion")]
    public partial class OcUnidadConversion
    {
        [Key]
        [Column("id_unidad")]
        [StringLength(5)]
        public string IdUnidad { get; set; }
        [Key]
        [Column("id_unidad_conversion")]
        [StringLength(5)]
        public string IdUnidadConversion { get; set; }
        [Column("factor_conversion", TypeName = "decimal(18, 5)")]
        public decimal FactorConversion { get; set; }
        [Column("usuario_ingreso")]
        [StringLength(6)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column("usuario_modifica")]
        [StringLength(6)]
        public string UsuarioModifica { get; set; }
        [Column("fecha_modifica", TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
    }
}
