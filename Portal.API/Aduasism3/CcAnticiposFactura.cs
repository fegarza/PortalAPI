using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cc_anticipos_facturas")]
    public partial class CcAnticiposFactura
    {
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Column("fecha_contable", TypeName = "datetime")]
        public DateTime FechaContable { get; set; }
        [Column("status_contable", TypeName = "decimal(1, 0)")]
        public decimal StatusContable { get; set; }
        [Key]
        [Column("id_factura")]
        [StringLength(10)]
        public string IdFactura { get; set; }
        [Column("total_comprobados", TypeName = "numeric(16, 4)")]
        public decimal TotalComprobados { get; set; }
        [Column("total_complementarios", TypeName = "numeric(16, 4)")]
        public decimal TotalComplementarios { get; set; }
        [Column("importe_anticipo", TypeName = "numeric(16, 4)")]
        public decimal ImporteAnticipo { get; set; }
        [Column("factor_conversion", TypeName = "numeric(9, 6)")]
        public decimal FactorConversion { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Key]
        [Column("cliente")]
        [StringLength(6)]
        public string Cliente { get; set; }
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Key]
        [Column("mex_ame")]
        [StringLength(1)]
        public string MexAme { get; set; }
    }
}
