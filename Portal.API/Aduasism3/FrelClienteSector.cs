using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_cliente_sector")]
    public partial class FrelClienteSector
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("cve_tipo_ope")]
        [StringLength(1)]
        public string CveTipoOpe { get; set; }
        [Key]
        [Column("id_sector")]
        [StringLength(3)]
        public string IdSector { get; set; }
    }
}
