using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("te_tmp_anticipos")]
    public partial class TeTmpAnticipo
    {
        [Key]
        [Column("no_beneficiario", TypeName = "numeric(6, 0)")]
        public decimal NoBeneficiario { get; set; }
        [Key]
        [Column("trafico", TypeName = "numeric(6, 0)")]
        public decimal Trafico { get; set; }
        [Column("mto_trafico", TypeName = "decimal(20, 8)")]
        public decimal MtoTrafico { get; set; }
        [Column("saldo_cxc", TypeName = "decimal(20, 8)")]
        public decimal? SaldoCxc { get; set; }
        [Column("status_ct")]
        public int? StatusCt { get; set; }
        [Column("num_empresa")]
        public int? NumEmpresa { get; set; }
        [Column("status_cxc")]
        public int? StatusCxc { get; set; }
        [Column("moneda")]
        [StringLength(5)]
        public string Moneda { get; set; }
    }
}
