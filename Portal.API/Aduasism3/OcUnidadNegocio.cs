using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_unidad_negocio")]
    public partial class OcUnidadNegocio
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("unidad_negocio")]
        [StringLength(4)]
        public string UnidadNegocio { get; set; }
        [Required]
        [Column("unidad_negocio_activa")]
        public bool? UnidadNegocioActiva { get; set; }
    }
}
