using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fconsecped_nout")]
    public partial class FconsecpedNout
    {
        [Key]
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Key]
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Key]
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Key]
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Key]
        [Column("id_anio", TypeName = "numeric(18, 0)")]
        public decimal IdAnio { get; set; }
    }
}
