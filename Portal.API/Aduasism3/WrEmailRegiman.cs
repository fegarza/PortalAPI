using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("wr_email_regimen")]
    public partial class WrEmailRegiman
    {
        [Column("id_aplicacion")]
        public short IdAplicacion { get; set; }
        [Column("id_email")]
        public int IdEmail { get; set; }
        [Required]
        [Column("id_regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
        [Column("cve_tipo_operacion")]
        [StringLength(1)]
        public string CveTipoOperacion { get; set; }
    }
}
