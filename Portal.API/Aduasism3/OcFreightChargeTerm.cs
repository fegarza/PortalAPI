using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_freight_charge_terms")]
    public partial class OcFreightChargeTerm
    {
        [Key]
        [Column("id_term")]
        public short IdTerm { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(15)]
        public string Descripcion { get; set; }
    }
}
