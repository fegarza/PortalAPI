using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcalculo_gen_fer")]
    [Index(nameof(Rowguid), Name = "index_1695345104", IsUnique = true)]
    public partial class FcalculoGenFer
    {
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("cve_tipo_operacion")]
        [StringLength(1)]
        public string CveTipoOperacion { get; set; }
        [Required]
        [Column("id_regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
        [Column("tipo_cambio_aduana", TypeName = "numeric(7, 5)")]
        public decimal TipoCambioAduana { get; set; }
        [Column("cuentas", TypeName = "numeric(1, 0)")]
        public decimal Cuentas { get; set; }
        [Column("tipo_cambio_bancario", TypeName = "numeric(7, 5)")]
        public decimal? TipoCambioBancario { get; set; }
        [Column("id_tipo_iva")]
        [StringLength(10)]
        public string IdTipoIva { get; set; }
        [Column("gastos_comprobados", TypeName = "numeric(11, 2)")]
        public decimal? GastosComprobados { get; set; }
        [Column("gastos_servicio", TypeName = "numeric(11, 2)")]
        public decimal? GastosServicio { get; set; }
        [Column("honorarios", TypeName = "numeric(11, 2)")]
        public decimal? Honorarios { get; set; }
        [Column("iva_servicio_honorarios", TypeName = "numeric(11, 2)")]
        public decimal? IvaServicioHonorarios { get; set; }
        [Column("importe_cuenta_americana", TypeName = "numeric(11, 2)")]
        public decimal? ImporteCuentaAmericana { get; set; }
        [Column("factor_ajuste", TypeName = "decimal(8, 6)")]
        public decimal? FactorAjuste { get; set; }
        [Column("id_contacto")]
        [StringLength(6)]
        public string IdContacto { get; set; }
        [Column("observaciones", TypeName = "text")]
        public string Observaciones { get; set; }
        [Required]
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Column("fecha_reg", TypeName = "datetime")]
        public DateTime FechaReg { get; set; }
        [Required]
        [Column("id_usuario_ultmodif")]
        [StringLength(6)]
        public string IdUsuarioUltmodif { get; set; }
        [Column("fecha_ultmodif", TypeName = "datetime")]
        public DateTime FechaUltmodif { get; set; }
        [Column("porc_hon", TypeName = "numeric(6, 4)")]
        public decimal? PorcHon { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
