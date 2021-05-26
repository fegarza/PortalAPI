using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_unidad_pedimento")]
    public partial class OcUnidadPedimento
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_unidad_oficial")]
        [StringLength(2)]
        public string IdUnidadOficial { get; set; }
        [Required]
        [Column("id_unidad_cliente")]
        [StringLength(3)]
        public string IdUnidadCliente { get; set; }
    }
}
