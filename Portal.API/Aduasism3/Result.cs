using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    public partial class Result
    {
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Column("cve_periodo", TypeName = "decimal(6, 0)")]
        public decimal CvePeriodo { get; set; }
        [Column("cve_poliza", TypeName = "decimal(4, 0)")]
        public decimal CvePoliza { get; set; }
        [Column("numero_movto", TypeName = "decimal(6, 0)")]
        public decimal NumeroMovto { get; set; }
        [Column("consec_aplicacion", TypeName = "decimal(4, 0)")]
        public decimal ConsecAplicacion { get; set; }
        [Required]
        [Column("tipo_poliza")]
        [StringLength(1)]
        public string TipoPoliza { get; set; }
        [Column("consec_poliza", TypeName = "decimal(6, 0)")]
        public decimal ConsecPoliza { get; set; }
        [Required]
        [Column("debito_credito")]
        [StringLength(1)]
        public string DebitoCredito { get; set; }
        [Column("num_cuenta", TypeName = "decimal(4, 0)")]
        public decimal NumCuenta { get; set; }
        [Column("sub_cuenta", TypeName = "decimal(4, 0)")]
        public decimal SubCuenta { get; set; }
        [Column("sub_subcuenta", TypeName = "decimal(4, 0)")]
        public decimal SubSubcuenta { get; set; }
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Column("importe_movto", TypeName = "decimal(16, 2)")]
        public decimal? ImporteMovto { get; set; }
        [Column("num_beneficiario", TypeName = "decimal(6, 0)")]
        public decimal? NumBeneficiario { get; set; }
        [Column("referencia")]
        [StringLength(60)]
        public string Referencia { get; set; }
        [Column("dia_movto", TypeName = "decimal(2, 0)")]
        public decimal? DiaMovto { get; set; }
        [Column("tipo_beneficiario", TypeName = "decimal(3, 0)")]
        public decimal? TipoBeneficiario { get; set; }
        [Column("referencia_origen")]
        [StringLength(255)]
        public string ReferenciaOrigen { get; set; }
    }
}
