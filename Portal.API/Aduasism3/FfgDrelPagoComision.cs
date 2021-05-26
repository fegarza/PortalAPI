using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("ffg_drel_pago_comision")]
    public partial class FfgDrelPagoComision
    {
        [Required]
        [Column("id_rel_pago_comision")]
        [StringLength(10)]
        public string IdRelPagoComision { get; set; }
        [Column("id_num_detalle", TypeName = "numeric(4, 0)")]
        public decimal IdNumDetalle { get; set; }
        [Required]
        [Column("id_factura")]
        [StringLength(10)]
        public string IdFactura { get; set; }
        [Column("numempresa")]
        [StringLength(3)]
        public string Numempresa { get; set; }
        [Column("monto_pagado", TypeName = "numeric(18, 2)")]
        public decimal? MontoPagado { get; set; }
        [Column("comision_factura", TypeName = "numeric(18, 2)")]
        public decimal? ComisionFactura { get; set; }
        [Column("tipo_moneda")]
        [StringLength(1)]
        public string TipoMoneda { get; set; }
    }
}
