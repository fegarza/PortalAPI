using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_inbond")]
    [Index(nameof(Rowguid), Name = "index_942678456", IsUnique = true)]
    public partial class FpedimentoInbond
    {
        [Key]
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Key]
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Key]
        [Column("patente")]
        [StringLength(4)]
        public string Patente { get; set; }
        [Key]
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Column("firma")]
        [StringLength(8)]
        public string Firma { get; set; }
        [Column("fecha_firma", TypeName = "datetime")]
        public DateTime? FechaFirma { get; set; }
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal? IdRectificacion { get; set; }
        [Column("id_usuario_reg")]
        [StringLength(6)]
        public string IdUsuarioReg { get; set; }
        [Column("fecha_reg", TypeName = "datetime")]
        public DateTime? FechaReg { get; set; }
        [Column("id_usuario_ult_modif")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
        [Column("fecha_ult_modif", TypeName = "datetime")]
        public DateTime? FechaUltModif { get; set; }
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
