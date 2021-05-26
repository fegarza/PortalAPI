using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_compensacion_fpv")]
    [Index(nameof(Rowguid), Name = "index_1598263282", IsUnique = true)]
    public partial class FpedimentoCompensacionFpv
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(18, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("num_secuencial", TypeName = "numeric(18, 0)")]
        public decimal NumSecuencial { get; set; }
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Column("forma_pago", TypeName = "numeric(3, 0)")]
        public decimal? FormaPago { get; set; }
        [Column("nombre_banco")]
        [StringLength(120)]
        public string NombreBanco { get; set; }
        [Column("id_docto")]
        [StringLength(40)]
        public string IdDocto { get; set; }
        [Column("fecha_docto", TypeName = "datetime")]
        public DateTime? FechaDocto { get; set; }
        [Column("importe_total", TypeName = "decimal(14, 2)")]
        public decimal? ImporteTotal { get; set; }
        [Column("Saldo_disponible", TypeName = "decimal(14, 2)")]
        public decimal? SaldoDisponible { get; set; }
        [Column("importe_pagar", TypeName = "decimal(12, 0)")]
        public decimal? ImportePagar { get; set; }
        [Column("rowguid")]
        public Guid? Rowguid { get; set; }
    }
}
