using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftipo_inbond")]
    public partial class FtipoInbond
    {
        [Key]
        [Column("tipo_inbond")]
        [StringLength(2)]
        public string TipoInbond { get; set; }
    }
}
