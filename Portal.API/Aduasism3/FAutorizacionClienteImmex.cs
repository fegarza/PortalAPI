using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("f_autorizacion_cliente_immex")]
    public partial class FAutorizacionClienteImmex
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("no_autorizacion")]
        [StringLength(50)]
        public string NoAutorizacion { get; set; }
        [Column("id_regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
        [Column("id_fraccion_mex")]
        [StringLength(8)]
        public string IdFraccionMex { get; set; }
        [Column("fecha_inicial_vigencia", TypeName = "datetime")]
        public DateTime? FechaInicialVigencia { get; set; }
        [Column("fecha_final_vigencia", TypeName = "datetime")]
        public DateTime? FechaFinalVigencia { get; set; }
        [Column("cantidad_inicial", TypeName = "decimal(16, 2)")]
        public decimal? CantidadInicial { get; set; }
        [Column("cantidad_disponible", TypeName = "decimal(16, 2)")]
        public decimal? CantidadDisponible { get; set; }
        [Column("unidad_medida")]
        [StringLength(5)]
        public string UnidadMedida { get; set; }
    }
}
