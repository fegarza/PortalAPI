using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cm_detrecepcion")]
    public partial class CmDetrecepcion
    {
        [Key]
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Key]
        [Column("numorden", TypeName = "decimal(6, 0)")]
        public decimal Numorden { get; set; }
        [Key]
        [Column("numrecep", TypeName = "decimal(6, 0)")]
        public decimal Numrecep { get; set; }
        [Key]
        [Column("numrequisicion", TypeName = "decimal(6, 0)")]
        public decimal Numrequisicion { get; set; }
        [Column("partida", TypeName = "decimal(3, 0)")]
        public decimal? Partida { get; set; }
        [Key]
        [Column("cveinsumo")]
        [StringLength(20)]
        public string Cveinsumo { get; set; }
        [Required]
        [Column("unidad")]
        [StringLength(5)]
        public string Unidad { get; set; }
        [Column("cantidad", TypeName = "decimal(14, 4)")]
        public decimal? Cantidad { get; set; }
        [Column("precio_pedido", TypeName = "decimal(14, 4)")]
        public decimal? PrecioPedido { get; set; }
        [Column("precio_recepcion", TypeName = "decimal(14, 4)")]
        public decimal? PrecioRecepcion { get; set; }
        [Column("moneda")]
        [StringLength(5)]
        public string Moneda { get; set; }
        [Column("tipo_cambio", TypeName = "decimal(14, 4)")]
        public decimal? TipoCambio { get; set; }
        [Column("importe", TypeName = "decimal(14, 4)")]
        public decimal? Importe { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("notas")]
        [StringLength(255)]
        public string Notas { get; set; }
        [Column("tipo_recepcion")]
        public int? TipoRecepcion { get; set; }
        [Column("num_almacen")]
        [StringLength(8)]
        public string NumAlmacen { get; set; }
        [Column("localizacion_fisica")]
        [StringLength(60)]
        public string LocalizacionFisica { get; set; }
        [Column("cveembarque", TypeName = "decimal(3, 0)")]
        public decimal? Cveembarque { get; set; }
    }
}
