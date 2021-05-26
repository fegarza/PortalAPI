using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_documento_pago")]
    public partial class TpDocumentoPago
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("id_documento")]
        public short IdDocumento { get; set; }
        [Column("forma_pago")]
        public int? FormaPago { get; set; }
        [Column("institucion_emisora")]
        [StringLength(120)]
        public string InstitucionEmisora { get; set; }
        [Required]
        [Column("numero_documento")]
        [StringLength(40)]
        public string NumeroDocumento { get; set; }
        [Column("fecha_emision", TypeName = "datetime")]
        public DateTime? FechaEmision { get; set; }
        [Column("importe_total", TypeName = "decimal(12, 2)")]
        public decimal? ImporteTotal { get; set; }
        [Column("saldo_disponible", TypeName = "decimal(12, 2)")]
        public decimal? SaldoDisponible { get; set; }
        [Column("importe_pedimento", TypeName = "decimal(12, 0)")]
        public decimal? ImportePedimento { get; set; }
    }
}
