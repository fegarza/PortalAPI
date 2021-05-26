using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_bodega_agente")]
    public partial class OcBodegaAgente
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_bodega")]
        [StringLength(4)]
        public string IdBodega { get; set; }
        [Required]
        [Column("id_bodega_agente")]
        [StringLength(8)]
        public string IdBodegaAgente { get; set; }
    }
}
