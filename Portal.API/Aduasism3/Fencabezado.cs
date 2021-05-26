using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fencabezado")]
    public partial class Fencabezado
    {
        [Key]
        [Column("factura")]
        [StringLength(15)]
        public string Factura { get; set; }
        [Column("incoterm")]
        [StringLength(15)]
        public string Incoterm { get; set; }
        [Key]
        [Column("fecha", TypeName = "datetime")]
        public DateTime Fecha { get; set; }
        [Column("tipo_cambio", TypeName = "decimal(9, 4)")]
        public decimal? TipoCambio { get; set; }
        [Column("patente")]
        [StringLength(4)]
        public string Patente { get; set; }
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Column("clave_ped")]
        [StringLength(2)]
        public string ClavePed { get; set; }
        [Key]
        [Column("proveedor")]
        [StringLength(10)]
        public string Proveedor { get; set; }
        [Column("tax_id")]
        [StringLength(20)]
        public string TaxId { get; set; }
        [Key]
        [Column("cliente")]
        [StringLength(10)]
        public string Cliente { get; set; }
        [Key]
        [Column("valor_dlls", TypeName = "decimal(12, 2)")]
        public decimal ValorDlls { get; set; }
        [Key]
        [Column("valor_comercial", TypeName = "decimal(12, 2)")]
        public decimal ValorComercial { get; set; }
        [Column("incrementables", TypeName = "decimal(12, 2)")]
        public decimal? Incrementables { get; set; }
        [Key]
        [Column("valor_aduana", TypeName = "decimal(12, 2)")]
        public decimal ValorAduana { get; set; }
        [Column("factor", TypeName = "decimal(12, 2)")]
        public decimal? Factor { get; set; }
        [Column("fletes", TypeName = "decimal(12, 2)")]
        public decimal? Fletes { get; set; }
        [Column("seguros", TypeName = "decimal(12, 2)")]
        public decimal? Seguros { get; set; }
        [Column("embalajes", TypeName = "decimal(12, 2)")]
        public decimal? Embalajes { get; set; }
        [Column("otros", TypeName = "decimal(12, 2)")]
        public decimal? Otros { get; set; }
        [Column("deducibles", TypeName = "decimal(12, 2)")]
        public decimal? Deducibles { get; set; }
        [Column("dta", TypeName = "decimal(12, 2)")]
        public decimal? Dta { get; set; }
        [Column("advalorem", TypeName = "decimal(12, 2)")]
        public decimal? Advalorem { get; set; }
        [Column("iva", TypeName = "decimal(12, 2)")]
        public decimal? Iva { get; set; }
        [Column("aduana")]
        [StringLength(4)]
        public string Aduana { get; set; }
        [Column("firma_elec")]
        [StringLength(25)]
        public string FirmaElec { get; set; }
        [Column("trans_a")]
        [StringLength(1)]
        public string TransA { get; set; }
        [Column("trans_e")]
        [StringLength(1)]
        public string TransE { get; set; }
        [Column("trans_s")]
        [StringLength(1)]
        public string TransS { get; set; }
        [Column("caja")]
        [StringLength(50)]
        public string Caja { get; set; }
        [Column("placas")]
        [StringLength(50)]
        public string Placas { get; set; }
    }
}
