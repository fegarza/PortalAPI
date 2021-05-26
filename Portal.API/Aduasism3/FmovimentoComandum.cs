using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fmovimento_comanda")]
    [Index(nameof(Rowguid), Name = "index_267147997", IsUnique = true)]
    public partial class FmovimentoComandum
    {
        [Required]
        [Column("id_tipo_concepto")]
        [StringLength(3)]
        public string IdTipoConcepto { get; set; }
        [Column("fecha_comanda", TypeName = "datetime")]
        public DateTime FechaComanda { get; set; }
        [Required]
        [Column("id_comanda")]
        [StringLength(6)]
        public string IdComanda { get; set; }
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_concepto")]
        [StringLength(6)]
        public string IdConcepto { get; set; }
        [Column("fecha_hora", TypeName = "datetime")]
        public DateTime FechaHora { get; set; }
        [Column("cantidad_conceptos", TypeName = "numeric(4, 0)")]
        public decimal CantidadConceptos { get; set; }
        [Column("monto", TypeName = "numeric(10, 2)")]
        public decimal Monto { get; set; }
        [Required]
        [Column("referencias")]
        [StringLength(80)]
        public string Referencias { get; set; }
        [Column("observaciones")]
        [StringLength(160)]
        public string Observaciones { get; set; }
        [Column("cve_facturada")]
        [StringLength(1)]
        public string CveFacturada { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
