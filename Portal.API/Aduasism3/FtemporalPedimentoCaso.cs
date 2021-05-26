using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftemporal_pedimento_caso")]
    public partial class FtemporalPedimentoCaso
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
    }
}
