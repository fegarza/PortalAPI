using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("ffg_drelacion_envio_ame")]
    public partial class FfgDrelacionEnvioAme
    {
        [Required]
        [Column("id_relacion")]
        [StringLength(10)]
        public string IdRelacion { get; set; }
        [Column("id_num_detalle", TypeName = "numeric(4, 0)")]
        public decimal IdNumDetalle { get; set; }
        [Required]
        [Column("id_factura_ame")]
        [StringLength(10)]
        public string IdFacturaAme { get; set; }
    }
}
