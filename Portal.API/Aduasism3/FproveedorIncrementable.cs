using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fproveedor_incrementables")]
    public partial class FproveedorIncrementable
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Column("proveedor_fletes")]
        [StringLength(120)]
        public string ProveedorFletes { get; set; }
        [Column("proveedor_seguros")]
        [StringLength(120)]
        public string ProveedorSeguros { get; set; }
        [Column("proveedor_otros")]
        [StringLength(120)]
        public string ProveedorOtros { get; set; }
        [Column("proveedor_embalaje")]
        [StringLength(120)]
        public string ProveedorEmbalaje { get; set; }
        [Column("documento_fletes")]
        [StringLength(50)]
        public string DocumentoFletes { get; set; }
        [Column("documento_seguros")]
        [StringLength(50)]
        public string DocumentoSeguros { get; set; }
        [Column("documentos_otros")]
        [StringLength(50)]
        public string DocumentosOtros { get; set; }
        [Column("documentos_embalaje")]
        [StringLength(50)]
        public string DocumentosEmbalaje { get; set; }
    }
}
