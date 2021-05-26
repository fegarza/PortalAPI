using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftipo_cambio")]
    [Index(nameof(Rowguid), Name = "index_546100986", IsUnique = true)]
    public partial class FtipoCambio
    {
        [Key]
        [Column("id_fecha", TypeName = "datetime")]
        public DateTime IdFecha { get; set; }
        [Key]
        [Column("cve_tipo_dolar")]
        [StringLength(1)]
        public string CveTipoDolar { get; set; }
        [Column("tipo_cambio", TypeName = "decimal(9, 6)")]
        public decimal TipoCambio { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("numempresa")]
        public int? Numempresa { get; set; }
    }
}
