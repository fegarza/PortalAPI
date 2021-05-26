using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fentrada_master")]
    public partial class FentradaMaster
    {
        [Key]
        [Column("id_entrada_master")]
        [StringLength(10)]
        public string IdEntradaMaster { get; set; }
        [Key]
        [Column("id_entrada")]
        [StringLength(10)]
        public string IdEntrada { get; set; }
        [Required]
        [Column("situacion")]
        [StringLength(1)]
        public string Situacion { get; set; }
    }
}
