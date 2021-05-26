using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_pais")]
    public partial class OcPai
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_pais")]
        [StringLength(4)]
        public string IdPais { get; set; }
        [Column("id_pais_oficial")]
        [StringLength(4)]
        public string IdPaisOficial { get; set; }
        [Required]
        [Column("activo")]
        public bool? Activo { get; set; }
    }
}
