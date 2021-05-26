using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_cliente_perfil_pago")]
    public partial class FfgClientePerfilPago
    {
        [Key]
        [Column("num_perfil")]
        public byte NumPerfil { get; set; }
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("c_MetodoPago")]
        [StringLength(3)]
        public string CMetodoPago { get; set; }
        [Column("c_FormaPago")]
        [StringLength(3)]
        public string CFormaPago { get; set; }
        [StringLength(1000)]
        public string CondicionesDePago { get; set; }
        [StringLength(13)]
        public string RfcEmisorCtaOrd { get; set; }
        [StringLength(50)]
        public string CtaOrdenante { get; set; }
        [StringLength(300)]
        public string NomBancoOrdExt { get; set; }
        [StringLength(2)]
        public string TipoCadPago { get; set; }
        [Column("perfil_default")]
        public byte? PerfilDefault { get; set; }
    }
}
