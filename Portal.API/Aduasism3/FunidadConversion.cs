using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("funidad_conversion")]
    public partial class FunidadConversion
    {
        [Key]
        [Column("id_unidad")]
        [StringLength(3)]
        public string IdUnidad { get; set; }
        [Required]
        [Column("id_unidad_com")]
        [StringLength(5)]
        public string IdUnidadCom { get; set; }
    }
}
