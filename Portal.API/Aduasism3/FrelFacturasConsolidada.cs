using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_facturas_consolidadas")]
    [Index(nameof(Rowguid), Name = "index_734677715", IsUnique = true)]
    public partial class FrelFacturasConsolidada
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Column("vehiculo")]
        [StringLength(100)]
        public string Vehiculo { get; set; }
        [Column("fecha_factura", TypeName = "datetime")]
        public DateTime? FechaFactura { get; set; }
        [Column("cantidad_comercial", TypeName = "decimal(15, 3)")]
        public decimal? CantidadComercial { get; set; }
        [Column("secuencial", TypeName = "numeric(4, 0)")]
        public decimal? Secuencial { get; set; }
        [Column("consecutivo_shcp")]
        [StringLength(4)]
        public string ConsecutivoShcp { get; set; }
        [Column("valor_dolares", TypeName = "numeric(14, 2)")]
        public decimal? ValorDolares { get; set; }
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("granel")]
        [StringLength(1)]
        public string Granel { get; set; }
        [Column("peso", TypeName = "numeric(12, 3)")]
        public decimal? Peso { get; set; }
        [Column("numero_vehiculo")]
        [StringLength(20)]
        public string NumeroVehiculo { get; set; }
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column("id_usuario_ult_modif")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
        [Column("fecha_ult_modif", TypeName = "datetime")]
        public DateTime? FechaUltModif { get; set; }
        [Column("usuario_autoriza")]
        [StringLength(10)]
        public string UsuarioAutoriza { get; set; }
    }
}
