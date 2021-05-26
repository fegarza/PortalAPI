using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cm_ordencompra")]
    public partial class CmOrdencompra
    {
        [Key]
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Key]
        [Column("numorden", TypeName = "decimal(6, 0)")]
        public decimal Numorden { get; set; }
        [Column("cveproveedor", TypeName = "decimal(10, 0)")]
        public decimal? Cveproveedor { get; set; }
        [Column("numrequisicion", TypeName = "decimal(6, 0)")]
        public decimal? Numrequisicion { get; set; }
        [Column("fechaorden", TypeName = "datetime")]
        public DateTime? Fechaorden { get; set; }
        [Column("fechaent", TypeName = "datetime")]
        public DateTime? Fechaent { get; set; }
        [Column("empresa", TypeName = "decimal(6, 0)")]
        public decimal? Empresa { get; set; }
        [Column("cvelab", TypeName = "decimal(3, 0)")]
        public decimal? Cvelab { get; set; }
        [Column("cveviaembarque", TypeName = "decimal(3, 0)")]
        public decimal? Cveviaembarque { get; set; }
        [Column("cveembarque", TypeName = "decimal(3, 0)")]
        public decimal? Cveembarque { get; set; }
        [Column("cvetipopago", TypeName = "decimal(3, 0)")]
        public decimal? Cvetipopago { get; set; }
        [Column("moneda")]
        [StringLength(5)]
        public string Moneda { get; set; }
        [Column("tipo_cambio", TypeName = "decimal(8, 4)")]
        public decimal? TipoCambio { get; set; }
        [Column("cveautorizacion")]
        [StringLength(20)]
        public string Cveautorizacion { get; set; }
        [Column("cvecomprador")]
        [StringLength(20)]
        public string Cvecomprador { get; set; }
        [Column("iva", TypeName = "decimal(5, 2)")]
        public decimal? Iva { get; set; }
        [Column("desc_global", TypeName = "decimal(6, 2)")]
        public decimal? DescGlobal { get; set; }
        [Column("imptotal", TypeName = "decimal(14, 2)")]
        public decimal? Imptotal { get; set; }
        [Column("status", TypeName = "decimal(1, 0)")]
        public decimal? Status { get; set; }
        [Column("usuario")]
        [StringLength(8)]
        public string Usuario { get; set; }
        [Column("notas", TypeName = "text")]
        public string Notas { get; set; }
    }
}
