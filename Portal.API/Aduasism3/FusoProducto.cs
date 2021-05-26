using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fuso_producto")]
    [Index(nameof(Rowguid), Name = "index_1860317462", IsUnique = true)]
    public partial class FusoProducto
    {
        [Key]
        [Column("clave")]
        [StringLength(2)]
        public string Clave { get; set; }
        [Required]
        [Column("descrpcion")]
        [StringLength(50)]
        public string Descrpcion { get; set; }
        [Required]
        [Column("clasificaccion")]
        [StringLength(1)]
        public string Clasificaccion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
