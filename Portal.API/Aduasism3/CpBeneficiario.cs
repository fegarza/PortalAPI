using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cp_beneficiario")]
    public partial class CpBeneficiario
    {
        [Key]
        [Column("num_beneficiario", TypeName = "numeric(6, 0)")]
        public decimal NumBeneficiario { get; set; }
        [Key]
        [Column("tipo_beneficiario", TypeName = "numeric(3, 0)")]
        public decimal TipoBeneficiario { get; set; }
        [Required]
        [Column("rfc")]
        [StringLength(16)]
        public string Rfc { get; set; }
        [Column("direccion")]
        [StringLength(65)]
        public string Direccion { get; set; }
        [Column("ciudad")]
        [StringLength(60)]
        public string Ciudad { get; set; }
        [Column("cp", TypeName = "numeric(7, 0)")]
        public decimal? Cp { get; set; }
        [Required]
        [Column("nombre_beneficiario")]
        [StringLength(50)]
        public string NombreBeneficiario { get; set; }
        [Column("monto_maximo_permitido", TypeName = "numeric(16, 4)")]
        public decimal? MontoMaximoPermitido { get; set; }
        [Column("saldo_por_comprobar", TypeName = "numeric(16, 4)")]
        public decimal? SaldoPorComprobar { get; set; }
        [Column("representante")]
        [StringLength(50)]
        public string Representante { get; set; }
        [Column("banco")]
        [StringLength(20)]
        public string Banco { get; set; }
        [Column("sucursal")]
        [StringLength(20)]
        public string Sucursal { get; set; }
        [Column("cuenta")]
        [StringLength(20)]
        public string Cuenta { get; set; }
        [Column("observaciones")]
        [StringLength(255)]
        public string Observaciones { get; set; }
        [Column("telefono")]
        [StringLength(16)]
        public string Telefono { get; set; }
        [Column("fax")]
        [StringLength(16)]
        public string Fax { get; set; }
        [Column("e_mail")]
        [StringLength(50)]
        public string EMail { get; set; }
        [Column("curp")]
        [StringLength(18)]
        public string Curp { get; set; }
        [Column("dias_limite_pago")]
        public int? DiasLimitePago { get; set; }
        [Column("num_benef_tmsf")]
        [StringLength(50)]
        public string NumBenefTmsf { get; set; }
        [Column("clave_banco_SAT_destino")]
        [StringLength(3)]
        public string ClaveBancoSatDestino { get; set; }
        [Column("cuenta_destino")]
        [StringLength(20)]
        public string CuentaDestino { get; set; }
        [Column("codigo_postal")]
        [StringLength(5)]
        public string CodigoPostal { get; set; }
        [Column("clave_pago_gastos")]
        [StringLength(2)]
        public string ClavePagoGastos { get; set; }
        [Column("status")]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("estado_civil")]
        [StringLength(1)]
        public string EstadoCivil { get; set; }
        [Column("dependientes")]
        public int? Dependientes { get; set; }
        [Column("seguro_social")]
        [StringLength(15)]
        public string SeguroSocial { get; set; }
        [Column("valor_x_hora", TypeName = "decimal(16, 2)")]
        public decimal? ValorXHora { get; set; }
        [Column("dias_pago", TypeName = "numeric(5, 0)")]
        public decimal? DiasPago { get; set; }
        [Column("aplica_financia")]
        [StringLength(1)]
        public string AplicaFinancia { get; set; }
        [Column("num_cuenta", TypeName = "decimal(4, 0)")]
        public decimal? NumCuenta { get; set; }
        [Column("sub_cuenta", TypeName = "decimal(4, 0)")]
        public decimal? SubCuenta { get; set; }
        [Column("sub_subcuenta", TypeName = "decimal(4, 0)")]
        public decimal? SubSubcuenta { get; set; }
        [Column("dias_vencimiento", TypeName = "numeric(5, 0)")]
        public decimal? DiasVencimiento { get; set; }
        [Column("tipo_tercero")]
        [StringLength(2)]
        public string TipoTercero { get; set; }
        [Column("tipo_operacion_servicio")]
        [StringLength(2)]
        public string TipoOperacionServicio { get; set; }
        [Column("id_fiscal")]
        [StringLength(40)]
        public string IdFiscal { get; set; }
        [Column("pais")]
        [StringLength(2)]
        public string Pais { get; set; }
        [Column("nacionalidad")]
        [StringLength(40)]
        public string Nacionalidad { get; set; }
        [Column("tipo_contable")]
        [StringLength(1)]
        public string TipoContable { get; set; }
        [Column("scac")]
        [StringLength(15)]
        public string Scac { get; set; }
    }
}
