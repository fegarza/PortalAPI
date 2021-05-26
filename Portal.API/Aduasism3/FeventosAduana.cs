using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("feventos_aduana")]
    public partial class FeventosAduana
    {
        [Required]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Key]
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Key]
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Key]
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Key]
        [Column("cve_tipo_operacion")]
        [StringLength(1)]
        public string CveTipoOperacion { get; set; }
        [Required]
        [Column("rfc_cliente")]
        [StringLength(13)]
        public string RfcCliente { get; set; }
        [Required]
        [Column("id_regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
        [Key]
        [Column("estado")]
        [StringLength(1)]
        public string Estado { get; set; }
        [Key]
        [Column("sub_estado")]
        [StringLength(3)]
        public string SubEstado { get; set; }
        [Key]
        [Column("consecutivo_remesa_ped", TypeName = "numeric(5, 0)")]
        public decimal ConsecutivoRemesaPed { get; set; }
        [Column("consecutivo_remesa_adu", TypeName = "numeric(5, 0)")]
        public decimal? ConsecutivoRemesaAdu { get; set; }
        [Column("valor_comercial", TypeName = "decimal(12, 2)")]
        public decimal? ValorComercial { get; set; }
        [Column("cantidad_comercial", TypeName = "decimal(14, 2)")]
        public decimal? CantidadComercial { get; set; }
        [Column("fechahora_evento", TypeName = "datetime")]
        public DateTime FechahoraEvento { get; set; }
        [Column("id_ori")]
        [StringLength(4)]
        public string IdOri { get; set; }
        [Required]
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_ult_modif")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
        [Column("fecha_ult_modif", TypeName = "datetime")]
        public DateTime FechaUltModif { get; set; }
        [Column("id_patenteF4")]
        [StringLength(4)]
        public string IdPatenteF4 { get; set; }
        [Column("pedimentoF4")]
        [StringLength(7)]
        public string PedimentoF4 { get; set; }
        [Column("id_aduanaF4")]
        [StringLength(2)]
        public string IdAduanaF4 { get; set; }
        [Column("seccionF4")]
        [StringLength(1)]
        public string SeccionF4 { get; set; }
        [Required]
        [Column("notificado")]
        [StringLength(1)]
        public string Notificado { get; set; }
    }
}
