using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_pedimento_corresponsal")]
    public partial class OcPedimentoCorresponsal
    {
        [Key]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("fecha_pedimento", TypeName = "datetime")]
        public DateTime FechaPedimento { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Required]
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Required]
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Required]
        [Column("seccion_aduana")]
        [StringLength(1)]
        public string SeccionAduana { get; set; }
        [Required]
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Required]
        [Column("id_regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
        [Column("remesa")]
        public bool Remesa { get; set; }
        [Column("fecha_pago", TypeName = "datetime")]
        public DateTime FechaPago { get; set; }
        [Column("expediente_completo")]
        public bool ExpedienteCompleto { get; set; }
        [Column("observaciones")]
        public string Observaciones { get; set; }
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
