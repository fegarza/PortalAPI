using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cm_tipoproveedor")]
    public partial class CmTipoproveedor
    {
        [Key]
        [Column("tipo_proveedor", TypeName = "decimal(3, 0)")]
        public decimal TipoProveedor { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(255)]
        public string Descripcion { get; set; }
    }
}
