using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fgfactura_elect")]
    public partial class FgfacturaElect
    {
        [Key]
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Key]
        [Column("id_pack_list")]
        [StringLength(15)]
        public string IdPackList { get; set; }
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("cve_tipo_opn")]
        [StringLength(1)]
        public string CveTipoOpn { get; set; }
        [Column("fecha_factura", TypeName = "datetime")]
        public DateTime FechaFactura { get; set; }
        [Key]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Required]
        [Column("id_tipo_factura")]
        [StringLength(4)]
        public string IdTipoFactura { get; set; }
        [Required]
        [Column("id_pais_moneda")]
        [StringLength(4)]
        public string IdPaisMoneda { get; set; }
        [Column("valor_factura", TypeName = "numeric(11, 2)")]
        public decimal ValorFactura { get; set; }
        [Column("peso_kgs", TypeName = "numeric(11, 2)")]
        public decimal PesoKgs { get; set; }
        [Column("peso_lbs", TypeName = "numeric(11, 2)")]
        public decimal PesoLbs { get; set; }
        [Required]
        [Column("observaciones", TypeName = "text")]
        public string Observaciones { get; set; }
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
        [Required]
        [Column("situacion")]
        [StringLength(1)]
        public string Situacion { get; set; }
        [Column("id_entrada_bodega")]
        [StringLength(50)]
        public string IdEntradaBodega { get; set; }
        [Column("numero_caja")]
        [StringLength(20)]
        public string NumeroCaja { get; set; }
        [Column("transportista")]
        [StringLength(40)]
        public string Transportista { get; set; }
    }
}
