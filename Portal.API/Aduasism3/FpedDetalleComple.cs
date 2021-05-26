using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fped_detalle_comple")]
    [Index(nameof(Rowguid), Name = "index_267200052", IsUnique = true)]
    public partial class FpedDetalleComple
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Required]
        [Column("id_fraccion")]
        [StringLength(8)]
        public string IdFraccion { get; set; }
        [Key]
        [Column("numero_secuencial", TypeName = "numeric(5, 0)")]
        public decimal NumeroSecuencial { get; set; }
        [Column("partida_exportacion", TypeName = "numeric(5, 0)")]
        public decimal PartidaExportacion { get; set; }
        [Column("valor_comercial", TypeName = "numeric(12, 0)")]
        public decimal ValorComercial { get; set; }
        [Column("monto_igi", TypeName = "numeric(12, 0)")]
        public decimal MontoIgi { get; set; }
        [Column("total_arancel_ec", TypeName = "numeric(12, 0)")]
        public decimal? TotalArancelEc { get; set; }
        [Column("id_moneda")]
        [StringLength(4)]
        public string IdMoneda { get; set; }
        [Column("monto_exento", TypeName = "numeric(12, 0)")]
        public decimal? MontoExento { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
