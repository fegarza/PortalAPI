using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fconsec_x_adupat")]
    public partial class FconsecXAdupat
    {
        [Key]
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Key]
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("id_prefijo")]
        [StringLength(3)]
        public string IdPrefijo { get; set; }
        [Column("consecutivo", TypeName = "numeric(18, 0)")]
        public decimal? Consecutivo { get; set; }
    }
}
