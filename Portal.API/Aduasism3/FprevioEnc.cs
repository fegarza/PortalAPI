using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fprevio_enc")]
    public partial class FprevioEnc
    {
        [Key]
        [Column("id_previo")]
        [StringLength(15)]
        public string IdPrevio { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("fecha_previo", TypeName = "datetime")]
        public DateTime FechaPrevio { get; set; }
        [Column("id_entrada_bodega")]
        [StringLength(10)]
        public string IdEntradaBodega { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Column("id_tipo_factura")]
        [StringLength(4)]
        public string IdTipoFactura { get; set; }
        [Column("id_pais_moneda")]
        [StringLength(4)]
        public string IdPaisMoneda { get; set; }
        [Column("factor_comercial", TypeName = "numeric(10, 8)")]
        public decimal? FactorComercial { get; set; }
        [Column("valor_previo", TypeName = "numeric(11, 2)")]
        public decimal? ValorPrevio { get; set; }
        [Column("peso_kgs", TypeName = "numeric(11, 2)")]
        public decimal? PesoKgs { get; set; }
        [Column("peso_lbs", TypeName = "numeric(11, 2)")]
        public decimal? PesoLbs { get; set; }
        [Column("observaciones", TypeName = "text")]
        public string Observaciones { get; set; }
        [Required]
        [Column("situacion")]
        [StringLength(1)]
        public string Situacion { get; set; }
        [Column("id_bodega")]
        [StringLength(8)]
        public string IdBodega { get; set; }
        [Column("numero_caja")]
        [StringLength(20)]
        public string NumeroCaja { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ult_modif", TypeName = "datetime")]
        public DateTime FechaUltModif { get; set; }
        [Required]
        [Column("id_usuario_ult_modif")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
    }
}
