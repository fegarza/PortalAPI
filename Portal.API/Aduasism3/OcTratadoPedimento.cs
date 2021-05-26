using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_tratado_pedimento")]
    public partial class OcTratadoPedimento
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_tipo_advalorem")]
        [StringLength(3)]
        public string IdTipoAdvalorem { get; set; }
        [Required]
        [Column("id_tratado_cliente")]
        [StringLength(3)]
        public string IdTratadoCliente { get; set; }
    }
}
