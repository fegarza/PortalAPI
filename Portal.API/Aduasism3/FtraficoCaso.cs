using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftrafico_caso")]
    [Index(nameof(Rowguid), Name = "index_1370487961", IsUnique = true)]
    public partial class FtraficoCaso
    {
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
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
