using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("flimite_cliente")]
    public partial class FlimiteCliente
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_regimen")]
        [StringLength(3)]
        public string IdRegimen { get; set; }
        [Column("limite_pago_elec", TypeName = "decimal(18, 0)")]
        public decimal? LimitePagoElec { get; set; }
        [Key]
        [Column("cve_tipo_operacion")]
        [StringLength(1)]
        public string CveTipoOperacion { get; set; }
    }
}
