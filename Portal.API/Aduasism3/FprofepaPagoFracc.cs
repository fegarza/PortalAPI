using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fprofepa_pago_fracc")]
    [Index(nameof(Rowguid), Name = "index_525296981", IsUnique = true)]
    public partial class FprofepaPagoFracc
    {
        [Column("fra_pago_der")]
        [StringLength(3)]
        public string FraPagoDer { get; set; }
        [Column("monto_pago_der", TypeName = "decimal(15, 2)")]
        public decimal? MontoPagoDer { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
