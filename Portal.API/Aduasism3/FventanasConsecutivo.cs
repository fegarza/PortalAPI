using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fventanas_consecutivos")]
    public partial class FventanasConsecutivo
    {
        [Column("consecutivo", TypeName = "numeric(6, 0)")]
        public decimal Consecutivo { get; set; }
        [Key]
        [Column("ventana")]
        [StringLength(180)]
        public string Ventana { get; set; }
    }
}
