using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcalculo_gastos")]
    [Index(nameof(Rowguid), Name = "index_231723928", IsUnique = true)]
    public partial class FcalculoGasto
    {
        [Key]
        [Column("id_calculo")]
        [StringLength(6)]
        public string IdCalculo { get; set; }
        [Key]
        [Column("gasto")]
        [StringLength(255)]
        public string Gasto { get; set; }
        [Key]
        [Column("comprobado")]
        [StringLength(1)]
        public string Comprobado { get; set; }
        [Column("valor", TypeName = "numeric(11, 2)")]
        public decimal Valor { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("ID_CONCEPTO")]
        [StringLength(6)]
        public string IdConcepto { get; set; }
    }
}
