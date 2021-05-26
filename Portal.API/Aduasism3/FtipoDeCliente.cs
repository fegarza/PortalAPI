using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftipo_de_cliente")]
    public partial class FtipoDeCliente
    {
        [Key]
        [Column("id_tipo_cliente")]
        [StringLength(3)]
        public string IdTipoCliente { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(40)]
        public string Descripcion { get; set; }
        [Required]
        [Column("cve_tipo_cliente")]
        [StringLength(1)]
        public string CveTipoCliente { get; set; }
    }
}
