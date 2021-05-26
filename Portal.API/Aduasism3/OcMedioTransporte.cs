using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_medio_transporte")]
    public partial class OcMedioTransporte
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("tipo_transporte")]
        [StringLength(2)]
        public string TipoTransporte { get; set; }
        [Required]
        [Column("cve_transporte_agente")]
        [StringLength(2)]
        public string CveTransporteAgente { get; set; }
    }
}
