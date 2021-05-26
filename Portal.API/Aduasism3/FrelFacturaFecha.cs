using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_factura_fecha")]
    [Index(nameof(Rowguid), Name = "index_1762157373", IsUnique = true)]
    public partial class FrelFacturaFecha
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Key]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Column("fecha_modificacion", TypeName = "datetime")]
        public DateTime? FechaModificacion { get; set; }
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Key]
        [Column("fecha_factura", TypeName = "datetime")]
        public DateTime FechaFactura { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
