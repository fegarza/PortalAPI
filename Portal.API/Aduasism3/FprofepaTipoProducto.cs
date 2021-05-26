using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fprofepa_tipo_producto")]
    [Index(nameof(Rowguid), Name = "index_589297209", IsUnique = true)]
    public partial class FprofepaTipoProducto
    {
        [Column("cve_tipo_producto")]
        [StringLength(2)]
        public string CveTipoProducto { get; set; }
        [Column("descripcion")]
        [StringLength(80)]
        public string Descripcion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
