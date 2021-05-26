using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fgorden_compra")]
    [Index(nameof(Rowguid), Name = "index_11147085", IsUnique = true)]
    public partial class FgordenCompra
    {
        [Key]
        [Column("id_orden_compra")]
        [StringLength(15)]
        public string IdOrdenCompra { get; set; }
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Required]
        [Column("id_pais_moneda")]
        [StringLength(4)]
        public string IdPaisMoneda { get; set; }
        [Column("fecha_hora_odec", TypeName = "datetime")]
        public DateTime FechaHoraOdec { get; set; }
        [Required]
        [Column("elaborada_por")]
        [StringLength(40)]
        public string ElaboradaPor { get; set; }
        [Required]
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_ult_modificacion")]
        [StringLength(6)]
        public string IdUsuarioUltModificacion { get; set; }
        [Column("fecha_ult_modificacion", TypeName = "datetime")]
        public DateTime FechaUltModificacion { get; set; }
        [Required]
        [Column("observaciones", TypeName = "text")]
        public string Observaciones { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
