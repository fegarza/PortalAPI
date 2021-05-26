using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cp_tipo_beneficiario")]
    public partial class CpTipoBeneficiario
    {
        [Key]
        [Column("tipo_beneficiario", TypeName = "numeric(3, 0)")]
        public decimal TipoBeneficiario { get; set; }
        [Column("descripcion")]
        [StringLength(60)]
        public string Descripcion { get; set; }
    }
}
