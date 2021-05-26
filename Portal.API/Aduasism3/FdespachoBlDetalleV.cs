using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdespacho_bl_detalle_v")]
    public partial class FdespachoBlDetalleV
    {
        [Key]
        [Column("num_control")]
        [StringLength(30)]
        public string NumControl { get; set; }
        [Key]
        [Column("consecutivo", TypeName = "numeric(9, 0)")]
        public decimal Consecutivo { get; set; }
        [Key]
        [Column("numero_bl")]
        [StringLength(25)]
        public string NumeroBl { get; set; }
        [Key]
        [Column("numero_equipo")]
        [StringLength(19)]
        public string NumeroEquipo { get; set; }
        [Key]
        [Column("sello")]
        [StringLength(36)]
        public string Sello { get; set; }
    }
}
