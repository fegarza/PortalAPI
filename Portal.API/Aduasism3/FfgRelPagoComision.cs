using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_rel_pago_comision")]
    public partial class FfgRelPagoComision
    {
        [Key]
        [Column("id_rel_pago_comision", TypeName = "numeric(18, 0)")]
        public decimal IdRelPagoComision { get; set; }
        [Column("fecha_pago", TypeName = "datetime")]
        public DateTime FechaPago { get; set; }
        [Required]
        [Column("id_corresponsal")]
        [StringLength(6)]
        public string IdCorresponsal { get; set; }
        [Column("tipo_corresponsal_contable")]
        [StringLength(2)]
        public string TipoCorresponsalContable { get; set; }
        [Column("num_documento", TypeName = "numeric(6, 0)")]
        public decimal? NumDocumento { get; set; }
        [Column("num_docto_pago", TypeName = "numeric(10, 0)")]
        public decimal? NumDoctoPago { get; set; }
        [Column("monto_pagado", TypeName = "numeric(16, 2)")]
        public decimal? MontoPagado { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ultmodif", TypeName = "datetime")]
        public DateTime? FechaUltmodif { get; set; }
        [Required]
        [Column("id_usuario_ultmodif")]
        [StringLength(6)]
        public string IdUsuarioUltmodif { get; set; }
        [Column("observaciones", TypeName = "text")]
        public string Observaciones { get; set; }
        [Column("atencion")]
        [StringLength(50)]
        public string Atencion { get; set; }
        [Column("recepcion")]
        [StringLength(80)]
        public string Recepcion { get; set; }
        [Column("coment_interno")]
        [StringLength(50)]
        public string ComentInterno { get; set; }
        [Column("status_pago")]
        [StringLength(1)]
        public string StatusPago { get; set; }
        [Column("numempresa")]
        [StringLength(4)]
        public string Numempresa { get; set; }
        [Column("porcentaje", TypeName = "decimal(3, 0)")]
        public decimal? Porcentaje { get; set; }
        [Column("comision_de_factura", TypeName = "numeric(16, 2)")]
        public decimal? ComisionDeFactura { get; set; }
    }
}
