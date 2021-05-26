using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fprofepa_prod_cientifico")]
    [Index(nameof(Rowguid), Name = "index_541297038", IsUnique = true)]
    public partial class FprofepaProdCientifico
    {
        [Column("id_clave")]
        [StringLength(34)]
        public string IdClave { get; set; }
        [Column("nombre_cientifico")]
        [StringLength(60)]
        public string NombreCientifico { get; set; }
        [Column("C738NUMCOM")]
        [StringLength(9)]
        public string C738numcom { get; set; }
        [Column("C738ID")]
        [StringLength(5)]
        public string C738id { get; set; }
        [Column("C738FAMILI")]
        [StringLength(20)]
        public string C738famili { get; set; }
        [Column("nombre_comercial")]
        [StringLength(60)]
        public string NombreComercial { get; set; }
        [Column("C738AAANID")]
        public double? C738aaanid { get; set; }
        [Column("C738AAACID")]
        [StringLength(10)]
        public string C738aaacid { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
