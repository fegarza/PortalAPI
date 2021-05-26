using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ferror")]
    public partial class Ferror
    {
        [Key]
        [Column("cve_error", TypeName = "numeric(10, 0)")]
        public decimal CveError { get; set; }
        [Column("des_titulo")]
        [StringLength(100)]
        public string DesTitulo { get; set; }
        [Column("des_error")]
        [StringLength(100)]
        public string DesError { get; set; }
        [Column("cve_icono", TypeName = "numeric(10, 0)")]
        public decimal? CveIcono { get; set; }
        [Column("cve_boton", TypeName = "numeric(10, 0)")]
        public decimal? CveBoton { get; set; }
        [Column("num_boton_focus", TypeName = "numeric(10, 0)")]
        public decimal? NumBotonFocus { get; set; }
    }
}
