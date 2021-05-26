using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("E_PEDIMENTO")]
    public partial class EPedimento
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(12)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(18, 0)")]
        public decimal IdRectificacion { get; set; }
        [Column("referencia_CFIT")]
        [StringLength(12)]
        public string ReferenciaCfit { get; set; }
        [Column("pedimento_in", TypeName = "datetime")]
        public DateTime? PedimentoIn { get; set; }
        [Column("validacion_generated", TypeName = "datetime")]
        public DateTime? ValidacionGenerated { get; set; }
        [Column("pedimento_validated", TypeName = "datetime")]
        public DateTime? PedimentoValidated { get; set; }
        [Column("pedimento_paid", TypeName = "datetime")]
        public DateTime? PedimentoPaid { get; set; }
        [Column("date_log", TypeName = "datetime")]
        public DateTime? DateLog { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
