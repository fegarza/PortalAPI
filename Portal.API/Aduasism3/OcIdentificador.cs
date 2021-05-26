using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_identificador")]
    public partial class OcIdentificador
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_identificador")]
        [StringLength(2)]
        public string IdIdentificador { get; set; }
        [Required]
        [Column("descripcion_identificador")]
        [StringLength(250)]
        public string DescripcionIdentificador { get; set; }
    }
}
