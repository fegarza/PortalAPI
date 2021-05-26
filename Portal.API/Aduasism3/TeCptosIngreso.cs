using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("te_cptos_ingreso")]
    public partial class TeCptosIngreso
    {
        [Key]
        [Column("cve_cpto_ingreso", TypeName = "numeric(3, 0)")]
        public decimal CveCptoIngreso { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(255)]
        public string Descripcion { get; set; }
    }
}
