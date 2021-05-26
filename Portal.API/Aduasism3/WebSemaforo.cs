using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("webSemaforo")]
    public partial class WebSemaforo
    {
        [Key]
        [Column("semaforo")]
        [StringLength(1)]
        public string Semaforo { get; set; }
        [Required]
        [Column("descripcionEs")]
        [StringLength(20)]
        public string DescripcionEs { get; set; }
        [Required]
        [Column("descripcionEn")]
        [StringLength(20)]
        public string DescripcionEn { get; set; }
    }
}
