using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffolio_no_utilizado")]
    public partial class FfolioNoUtilizado
    {
        [Key]
        [Column("id_fecha", TypeName = "datetime")]
        public DateTime IdFecha { get; set; }
        [Key]
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Key]
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Key]
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("consecutivo", TypeName = "numeric(7, 0)")]
        public decimal Consecutivo { get; set; }
    }
}
