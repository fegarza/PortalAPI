using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("f_rfc_servicios")]
    public partial class FRfcServicio
    {
        [Key]
        [Column("rfc")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Required]
        [Column("razon_social")]
        [StringLength(120)]
        public string RazonSocial { get; set; }
    }
}
