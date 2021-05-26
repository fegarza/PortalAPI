using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cm_detorden")]
    public partial class CmDetorden
    {
        [Key]
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Key]
        [Column("numorden", TypeName = "decimal(6, 0)")]
        public decimal Numorden { get; set; }
        [Key]
        [Column("cveinsumo")]
        [StringLength(20)]
        public string Cveinsumo { get; set; }
        [Required]
        [Column("nombre")]
        [StringLength(255)]
        public string Nombre { get; set; }
        [Column("numrequisicion", TypeName = "decimal(6, 0)")]
        public decimal? Numrequisicion { get; set; }
        [Column("partida", TypeName = "decimal(3, 0)")]
        public decimal? Partida { get; set; }
        [Column("unidad")]
        [StringLength(5)]
        public string Unidad { get; set; }
        [Column("cantidad", TypeName = "decimal(14, 4)")]
        public decimal? Cantidad { get; set; }
        [Column("precio", TypeName = "decimal(14, 4)")]
        public decimal? Precio { get; set; }
        [Column("descuento", TypeName = "decimal(8, 4)")]
        public decimal? Descuento { get; set; }
        [Column("moneda")]
        [StringLength(5)]
        public string Moneda { get; set; }
        [Column("tipo_cambio", TypeName = "decimal(12, 4)")]
        public decimal? TipoCambio { get; set; }
        [Column("fecha_entrega", TypeName = "datetime")]
        public DateTime? FechaEntrega { get; set; }
        [Column("cantidad_recibida", TypeName = "decimal(14, 4)")]
        public decimal? CantidadRecibida { get; set; }
        [Column("status", TypeName = "decimal(1, 0)")]
        public decimal? Status { get; set; }
        [Column("notas_tecnicas", TypeName = "text")]
        public string NotasTecnicas { get; set; }
        [Column("notas_comprador", TypeName = "text")]
        public string NotasComprador { get; set; }
    }
}
