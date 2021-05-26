using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_copia_simple_detalle")]
    public partial class FpedimentoCopiaSimpleDetalle
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("consecutivo", TypeName = "numeric(5, 0)")]
        public decimal Consecutivo { get; set; }
        [Key]
        [Column("partida", TypeName = "numeric(3, 0)")]
        public decimal Partida { get; set; }
        [Required]
        [Column("unidad_tarifa")]
        [StringLength(3)]
        public string UnidadTarifa { get; set; }
        [Column("cantidad_tarifa", TypeName = "numeric(15, 3)")]
        public decimal CantidadTarifa { get; set; }
        [Required]
        [Column("unidad_comercial")]
        [StringLength(3)]
        public string UnidadComercial { get; set; }
        [Column("cantidad_comercial", TypeName = "numeric(15, 3)")]
        public decimal CantidadComercial { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(250)]
        public string Descripcion { get; set; }
    }
}
