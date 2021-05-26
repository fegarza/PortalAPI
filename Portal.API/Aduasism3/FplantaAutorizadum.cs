using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fplanta_autorizada")]
    [Index(nameof(Rowguid), Name = "index_1799729514", IsUnique = true)]
    public partial class FplantaAutorizadum
    {
        [Key]
        [Column("cve_unica")]
        [StringLength(10)]
        public string CveUnica { get; set; }
        [Key]
        [Column("cve_planta")]
        [StringLength(30)]
        public string CvePlanta { get; set; }
        [Required]
        [Column("cve_pais")]
        [StringLength(34)]
        public string CvePais { get; set; }
        [Column("nombre")]
        [StringLength(250)]
        public string Nombre { get; set; }
        [Column("direccion")]
        [StringLength(250)]
        public string Direccion { get; set; }
        [Column("tipo")]
        [StringLength(250)]
        public string Tipo { get; set; }
        [Column("especie")]
        [StringLength(250)]
        public string Especie { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
