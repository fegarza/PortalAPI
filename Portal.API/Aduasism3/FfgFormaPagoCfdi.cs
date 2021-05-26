using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_formaPagoCFDI")]
    public partial class FfgFormaPagoCfdi
    {
        [Key]
        [Column("id_formaPagoCFDI")]
        public byte IdFormaPagoCfdi { get; set; }
        [Column("fecha_captura", TypeName = "datetime")]
        public DateTime FechaCaptura { get; set; }
        [Required]
        [Column("c_FormaPago")]
        [StringLength(3)]
        public string CFormaPago { get; set; }
        [StringLength(50)]
        public string Descripcion { get; set; }
        [StringLength(1)]
        public string Bancarizado { get; set; }
        [Column("numeroOperacion")]
        [StringLength(1)]
        public string NumeroOperacion { get; set; }
        [Column("RFCEmisorCtaOrdena")]
        [StringLength(1)]
        public string RfcemisorCtaOrdena { get; set; }
        [StringLength(1)]
        public string CuentaOrdenenate { get; set; }
        [Column("RFCEmisorCtaBenef")]
        [StringLength(1)]
        public string RfcemisorCtaBenef { get; set; }
        [StringLength(1)]
        public string CuentaBeneficiario { get; set; }
        [StringLength(1)]
        public string TipoCadenaPago { get; set; }
        [StringLength(1)]
        public string NomBancoEmisorExt { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ultmodif", TypeName = "datetime")]
        public DateTime? FechaUltmodif { get; set; }
        [Required]
        [Column("id_usuario_ultmodif")]
        [StringLength(6)]
        public string IdUsuarioUltmodif { get; set; }
    }
}
