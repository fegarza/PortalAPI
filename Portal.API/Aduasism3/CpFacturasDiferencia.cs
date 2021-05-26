using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("cp_facturas_diferencias")]
    public partial class CpFacturasDiferencia
    {
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Column("num_beneficiario", TypeName = "numeric(10, 0)")]
        public decimal NumBeneficiario { get; set; }
        [Column("num_documento", TypeName = "numeric(6, 0)")]
        public decimal NumDocumento { get; set; }
        [Column("valor_bruto", TypeName = "numeric(16, 4)")]
        public decimal ValorBruto { get; set; }
        [Column("importe_iva", TypeName = "numeric(14, 4)")]
        public decimal ImporteIva { get; set; }
        [Column("valor_descuento", TypeName = "numeric(16, 4)")]
        public decimal? ValorDescuento { get; set; }
        [Column("valor_cxp", TypeName = "numeric(16, 4)")]
        public decimal? ValorCxp { get; set; }
        [Column("importe_amortizacion", TypeName = "numeric(14, 4)")]
        public decimal? ImporteAmortizacion { get; set; }
        [Column("importe_fondo_garantia", TypeName = "numeric(14, 4)")]
        public decimal? ImporteFondoGarantia { get; set; }
    }
}
