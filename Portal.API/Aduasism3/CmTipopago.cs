using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cm_tipopago")]
    public partial class CmTipopago
    {
        [Key]
        [Column("cvetipopago", TypeName = "decimal(3, 0)")]
        public decimal Cvetipopago { get; set; }
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Column("ptje_anticipo", TypeName = "decimal(9, 4)")]
        public decimal? PtjeAnticipo { get; set; }
        [Column("dias_pago")]
        public int? DiasPago { get; set; }
    }
}
