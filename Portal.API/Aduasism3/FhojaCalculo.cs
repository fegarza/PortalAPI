using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fhoja_calculo")]
    public partial class FhojaCalculo
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion")]
        public int IdRectificacion { get; set; }
        [Column("id_contacto")]
        [StringLength(10)]
        public string IdContacto { get; set; }
        [Column("nombre")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Column("apellido_p")]
        [StringLength(50)]
        public string ApellidoP { get; set; }
        [Column("apellido_m")]
        [StringLength(50)]
        public string ApellidoM { get; set; }
        [Column("rfc")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Column("id_usuario_reg")]
        [StringLength(10)]
        public string IdUsuarioReg { get; set; }
        [Column("fecha_reg", TypeName = "datetime")]
        public DateTime? FechaReg { get; set; }
        [Column("id_usuario_utl_mod")]
        [StringLength(10)]
        public string IdUsuarioUtlMod { get; set; }
        [Column("fecha_ult_mod", TypeName = "datetime")]
        public DateTime? FechaUltMod { get; set; }
        [Column("compra_venta")]
        [StringLength(1)]
        public string CompraVenta { get; set; }
        [Column("unica_vincu")]
        [StringLength(1)]
        public string UnicaVincu { get; set; }
        [Column("restricciones")]
        [StringLength(1)]
        public string Restricciones { get; set; }
        [Column("contraprestaciones")]
        [StringLength(1)]
        public string Contraprestaciones { get; set; }
        [Column("reversiones_regalias")]
        [StringLength(1)]
        public string ReversionesRegalias { get; set; }
        [Column("comisiones", TypeName = "decimal(12, 2)")]
        public decimal? Comisiones { get; set; }
        [Column("fletes", TypeName = "decimal(12, 2)")]
        public decimal? Fletes { get; set; }
        [Column("seguros", TypeName = "decimal(12, 2)")]
        public decimal? Seguros { get; set; }
        [Column("carga_descarga", TypeName = "decimal(12, 2)")]
        public decimal? CargaDescarga { get; set; }
        [Column("materiales", TypeName = "decimal(12, 2)")]
        public decimal? Materiales { get; set; }
        [Column("tecnologia", TypeName = "decimal(12, 2)")]
        public decimal? Tecnologia { get; set; }
        [Column("regalias", TypeName = "decimal(12, 2)")]
        public decimal? Regalias { get; set; }
        [Column("reversiones", TypeName = "decimal(12, 2)")]
        public decimal? Reversiones { get; set; }
    }
}
