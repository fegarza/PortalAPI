using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("faux_cliente")]
    public partial class FauxCliente
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(10)]
        public string IdCliente { get; set; }
        [Required]
        [Column("id_cliente_sis")]
        [StringLength(6)]
        public string IdClienteSis { get; set; }
        [Key]
        [Column("cve_cliente")]
        [StringLength(10)]
        public string CveCliente { get; set; }
    }
}
