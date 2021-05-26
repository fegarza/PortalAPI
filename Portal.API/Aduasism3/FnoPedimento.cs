using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fno_pedimento")]
    public partial class FnoPedimento
    {
        [Key]
        [Column("id_documento")]
        [StringLength(10)]
        public string IdDocumento { get; set; }
        [Column("id_banco")]
        [StringLength(2)]
        public string IdBanco { get; set; }
        [Key]
        [Column("id_folio")]
        [StringLength(15)]
        public string IdFolio { get; set; }
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("clase_docto")]
        [StringLength(2)]
        public string ClaseDocto { get; set; }
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Column("rfc_imp")]
        [StringLength(13)]
        public string RfcImp { get; set; }
        [Column("identificador")]
        [StringLength(5)]
        public string Identificador { get; set; }
        [Column("clave_seg")]
        [StringLength(12)]
        public string ClaveSeg { get; set; }
        [Column("numero_caja")]
        [StringLength(2)]
        public string NumeroCaja { get; set; }
        [Column("numero_opn")]
        [StringLength(10)]
        public string NumeroOpn { get; set; }
        [Column("firma_banco")]
        [StringLength(10)]
        public string FirmaBanco { get; set; }
        [Column("fecha_pago", TypeName = "datetime")]
        public DateTime? FechaPago { get; set; }
        [Column("numero_no_ped")]
        [StringLength(7)]
        public string NumeroNoPed { get; set; }
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column("fecha_docto", TypeName = "datetime")]
        public DateTime? FechaDocto { get; set; }
        [Column("turno")]
        [StringLength(1)]
        public string Turno { get; set; }
        [Column("importe_total", TypeName = "decimal(18, 0)")]
        public decimal? ImporteTotal { get; set; }
        [Column("id_oficina")]
        [StringLength(2)]
        public string IdOficina { get; set; }
    }
}
