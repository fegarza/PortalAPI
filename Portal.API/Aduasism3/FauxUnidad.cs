using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("faux_unidad")]
    public partial class FauxUnidad
    {
        [Key]
        [Column("id_unidad")]
        [StringLength(10)]
        public string IdUnidad { get; set; }
        [Required]
        [Column("id_unidad_com")]
        [StringLength(5)]
        public string IdUnidadCom { get; set; }
        [Key]
        [Column("cve_cliente")]
        [StringLength(10)]
        public string CveCliente { get; set; }
    }
}
