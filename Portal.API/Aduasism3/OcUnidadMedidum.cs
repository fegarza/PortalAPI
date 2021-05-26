using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_unidad_medida")]
    public partial class OcUnidadMedidum
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_unidad_medida")]
        [StringLength(4)]
        public string IdUnidadMedida { get; set; }
        [Column("descripcion")]
        [StringLength(40)]
        public string Descripcion { get; set; }
        [Column("id_unidad_agente")]
        [StringLength(5)]
        public string IdUnidadAgente { get; set; }
        [Required]
        [Column("unidad_activa")]
        public bool? UnidadActiva { get; set; }
    }
}
