using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_pedimento_consolidado")]
    public partial class OcPedimentoConsolidado
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion")]
        public int IdRectificacion { get; set; }
        [Required]
        [Column("referencia")]
        [StringLength(15)]
        public string Referencia { get; set; }
        [Required]
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Required]
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Required]
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Required]
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Required]
        [Column("id_regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
        [Required]
        [Column("id_tipo_pedimento")]
        [StringLength(2)]
        public string IdTipoPedimento { get; set; }
        [Column("fecha_pago", TypeName = "datetime")]
        public DateTime FechaPago { get; set; }
        [Column("fecha_entrada", TypeName = "datetime")]
        public DateTime FechaEntrada { get; set; }
        [Column("pago_autorizado")]
        public bool PagoAutorizado { get; set; }
        [Column("usuario_autoriza")]
        [StringLength(6)]
        public string UsuarioAutoriza { get; set; }
        [Column("fecha_autorizado", TypeName = "datetime")]
        public DateTime? FechaAutorizado { get; set; }
        [Column("usuario_ingreso")]
        [StringLength(6)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column("usuario_modifica")]
        [StringLength(6)]
        public string UsuarioModifica { get; set; }
        [Column("fecha_modifica", TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
    }
}
