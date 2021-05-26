using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_prod_frac")]
    [Index(nameof(Rowguid), Name = "index_129435535", IsUnique = true)]
    public partial class FrelProdFrac
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Key]
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Required]
        [Column("id_fraccion_mex")]
        [StringLength(8)]
        public string IdFraccionMex { get; set; }
        [Key]
        [Column("cve_tipo_opn")]
        [StringLength(1)]
        public string CveTipoOpn { get; set; }
        [Required]
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Column("fecha_reg", TypeName = "datetime")]
        public DateTime FechaReg { get; set; }
        [Required]
        [Column("id_usuario_clasifica")]
        [StringLength(6)]
        public string IdUsuarioClasifica { get; set; }
        [Required]
        [Column("id_usuario_ultmodif")]
        [StringLength(6)]
        public string IdUsuarioUltmodif { get; set; }
        [Column("fecha_ultmodif", TypeName = "datetime")]
        public DateTime FechaUltmodif { get; set; }
        [Column("clasificado")]
        [StringLength(1)]
        public string Clasificado { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("id_fraccion_historico")]
        [StringLength(8)]
        public string IdFraccionHistorico { get; set; }
        [Column("id_fraccion_ame")]
        [StringLength(12)]
        public string IdFraccionAme { get; set; }
        [Column("fraccion_regla8va")]
        [StringLength(8)]
        public string FraccionRegla8va { get; set; }

        [ForeignKey(nameof(IdUsuarioClasifica))]
        [InverseProperty(nameof(Fusuario.FrelProdFracIdUsuarioClasificaNavigations))]
        public virtual Fusuario IdUsuarioClasificaNavigation { get; set; }
        [ForeignKey(nameof(IdUsuarioUltmodif))]
        [InverseProperty(nameof(Fusuario.FrelProdFracIdUsuarioUltmodifNavigations))]
        public virtual Fusuario IdUsuarioUltmodifNavigation { get; set; }
    }
}
