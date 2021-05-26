using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fultimate_consignee_type")]
    public partial class FultimateConsigneeType
    {
        [Key]
        [Column("ultimate_consignee_type")]
        [StringLength(1)]
        public string UltimateConsigneeType { get; set; }
        [Column("descripcion")]
        [StringLength(30)]
        public string Descripcion { get; set; }
    }
}
