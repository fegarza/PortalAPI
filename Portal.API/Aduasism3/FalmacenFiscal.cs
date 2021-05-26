using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("falmacen_fiscal")]
    [Index(nameof(Rowguid), Name = "index_276196034", IsUnique = true)]
    public partial class FalmacenFiscal
    {
        [Key]
        [Column("id_almacen_fiscal")]
        [StringLength(4)]
        public string IdAlmacenFiscal { get; set; }
        [Required]
        [Column("descripcion_alm_fiscal")]
        [StringLength(250)]
        public string DescripcionAlmFiscal { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
