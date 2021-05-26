using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fmovimiento_bodega")]
    public partial class FmovimientoBodega
    {
        [Required]
        [Column("id_bodega")]
        [StringLength(8)]
        public string IdBodega { get; set; }
        [Key]
        [Column("numero_movto", TypeName = "numeric(8, 0)")]
        public decimal NumeroMovto { get; set; }
        [Key]
        [Column("id_docto_origen", TypeName = "numeric(10, 0)")]
        public decimal IdDoctoOrigen { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Key]
        [Column("id_tipo_movto")]
        [StringLength(4)]
        public string IdTipoMovto { get; set; }
        [Column("fecha_movto", TypeName = "datetime")]
        public DateTime FechaMovto { get; set; }
        [Column("cantidad", TypeName = "numeric(12, 5)")]
        public decimal Cantidad { get; set; }
        [Required]
        [Column("id_docto_referencia")]
        [StringLength(15)]
        public string IdDoctoReferencia { get; set; }
        [Required]
        [Column("observaciones", TypeName = "text")]
        public string Observaciones { get; set; }
        [Required]
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
    }
}
