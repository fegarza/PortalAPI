using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fconceptos_no_pedimento")]
    public partial class FconceptosNoPedimento
    {
        [Key]
        [Column("id_concepto")]
        [StringLength(6)]
        public string IdConcepto { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(250)]
        public string Descripcion { get; set; }
    }
}
