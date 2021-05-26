using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fplanta_tiff")]
    [Index(nameof(Rowguid), Name = "index_1831729628", IsUnique = true)]
    public partial class FplantaTiff
    {
        [Key]
        [Column("cve_planta")]
        [StringLength(10)]
        public string CvePlanta { get; set; }
        [Column("nombre")]
        [StringLength(250)]
        public string Nombre { get; set; }
        [Column("direccion")]
        [StringLength(250)]
        public string Direccion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
