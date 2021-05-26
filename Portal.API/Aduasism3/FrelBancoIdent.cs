using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_banco_ident")]
    [Index(nameof(Rowguid), Name = "index_391724498", IsUnique = true)]
    public partial class FrelBancoIdent
    {
        [Key]
        [Column("id_banco")]
        [StringLength(4)]
        public string IdBanco { get; set; }
        [Key]
        [Column("identificador")]
        [StringLength(5)]
        public string Identificador { get; set; }
        [Key]
        [Column("cuenta")]
        [StringLength(30)]
        public string Cuenta { get; set; }
        [Column("rfc")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Column("quitar_ident")]
        [StringLength(1)]
        public string QuitarIdent { get; set; }
        [Column("id_usuario_ultmodif")]
        [StringLength(6)]
        public string IdUsuarioUltmodif { get; set; }
        [Column("fecha_ultmodif", TypeName = "datetime")]
        public DateTime? FechaUltmodif { get; set; }
        [Column("rfc_servicios")]
        [StringLength(13)]
        public string RfcServicios { get; set; }
        [Key]
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Key]
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("cuenta_activa")]
        [StringLength(1)]
        public string CuentaActiva { get; set; }
        [Column("tipo_cuenta")]
        [StringLength(1)]
        public string TipoCuenta { get; set; }
    }
}
