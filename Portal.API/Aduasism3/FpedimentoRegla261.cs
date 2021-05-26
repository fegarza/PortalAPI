using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_regla_261")]
    public partial class FpedimentoRegla261
    {
        [Key]
        [Column("aduana")]
        [StringLength(2)]
        public string Aduana { get; set; }
        [Key]
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Column("facturas")]
        [StringLength(250)]
        public string Facturas { get; set; }
        [StringLength(1500)]
        public string Observaciones { get; set; }
        [StringLength(250)]
        public string Cliente { get; set; }
        [StringLength(250)]
        public string Proveedor { get; set; }
        [Column("Agente_Aduanal")]
        [StringLength(250)]
        public string AgenteAduanal { get; set; }
        [Column("RFC_AA")]
        [StringLength(20)]
        public string RfcAa { get; set; }
        [StringLength(250)]
        public string Apoderado { get; set; }
        [Column("RFC_Apo")]
        [StringLength(20)]
        public string RfcApo { get; set; }
        [Column("lugar")]
        [StringLength(250)]
        public string Lugar { get; set; }
        [Column("rs_aduana")]
        [StringLength(250)]
        public string RsAduana { get; set; }
        [Column("asunto")]
        [StringLength(250)]
        public string Asunto { get; set; }
        [StringLength(999)]
        public string Observaciones2 { get; set; }
        [Column("patente")]
        [StringLength(4)]
        public string Patente { get; set; }
    }
}
