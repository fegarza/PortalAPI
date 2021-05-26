using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdespacho_pedimento_v")]
    public partial class FdespachoPedimentoV
    {
        [Key]
        [Column("num_control")]
        [StringLength(30)]
        public string NumControl { get; set; }
        [Key]
        [Column("numero_bl")]
        [StringLength(25)]
        public string NumeroBl { get; set; }
        [Key]
        [Column("consecutivo", TypeName = "numeric(9, 0)")]
        public decimal Consecutivo { get; set; }
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion")]
        public int IdRectificacion { get; set; }
        [Key]
        [Column("secuencial", TypeName = "numeric(9, 0)")]
        public decimal Secuencial { get; set; }
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Column("cove")]
        [StringLength(13)]
        public string Cove { get; set; }
        [Column("partes_ii", TypeName = "numeric(3, 0)")]
        public decimal? PartesIi { get; set; }
        [Column("requiere_inspeccion")]
        [StringLength(1)]
        public string RequiereInspeccion { get; set; }
        [Column("cantidad_mercancias", TypeName = "numeric(12, 3)")]
        public decimal? CantidadMercancias { get; set; }
        [Column("valor_usd", TypeName = "numeric(12, 3)")]
        public decimal? ValorUsd { get; set; }
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("id_tipo_pedimento")]
        [StringLength(2)]
        public string IdTipoPedimento { get; set; }
    }
}
