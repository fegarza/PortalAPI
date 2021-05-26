using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftlcan_regimen")]
    [Index(nameof(Rowguid), Name = "index_930102354", IsUnique = true)]
    public partial class FtlcanRegiman
    {
        [Key]
        [Column("id_regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
        [Key]
        [Column("cve_tipo_operacion")]
        [StringLength(1)]
        public string CveTipoOperacion { get; set; }
        [Column("fecha_vigor", TypeName = "datetime")]
        public DateTime? FechaVigor { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
