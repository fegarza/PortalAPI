using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_factura_expo_detalle_serie")]
    public partial class OcFacturaExpoDetalleSerie
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_proveedor")]
        [StringLength(10)]
        public string IdProveedor { get; set; }
        [Key]
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Key]
        [Column("secuencial_factura")]
        public int SecuencialFactura { get; set; }
        [Key]
        [Column("secuencial_serie")]
        public int SecuencialSerie { get; set; }
        [Column("marca")]
        [StringLength(100)]
        public string Marca { get; set; }
        [Column("modelo")]
        [StringLength(50)]
        public string Modelo { get; set; }
        [Column("sub_modelo")]
        [StringLength(50)]
        public string SubModelo { get; set; }
        [Column("numero_serie")]
        [StringLength(25)]
        public string NumeroSerie { get; set; }
        [Column("usuario_ingreso")]
        [StringLength(6)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column("usuario_modifica")]
        [StringLength(6)]
        public string UsuarioModifica { get; set; }
        [Column("fecha_modifica", TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
    }
}
