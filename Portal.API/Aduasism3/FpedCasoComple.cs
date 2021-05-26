using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fped_caso_comple")]
    [Index(nameof(Rowguid), Name = "index_187199767", IsUnique = true)]
    public partial class FpedCasoComple
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("secuencial", TypeName = "numeric(3, 0)")]
        public decimal Secuencial { get; set; }
        [Required]
        [Column("tipo_caso")]
        [StringLength(3)]
        public string TipoCaso { get; set; }
        [Column("iden_caso")]
        [StringLength(20)]
        public string IdenCaso { get; set; }
        [Column("complemento2")]
        [StringLength(30)]
        public string Complemento2 { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("complemento3")]
        [StringLength(30)]
        public string Complemento3 { get; set; }
    }
}
