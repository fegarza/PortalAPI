using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_tipo_material")]
    public partial class OcTipoMaterial
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("tipo_material")]
        [StringLength(1)]
        public string TipoMaterial { get; set; }
        [Column("clase_material")]
        public short ClaseMaterial { get; set; }
    }
}
