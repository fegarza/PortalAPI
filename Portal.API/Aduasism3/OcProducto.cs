using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_producto")]
    public partial class OcProducto
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
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Required]
        [Column("id_unidad_medida")]
        [StringLength(4)]
        public string IdUnidadMedida { get; set; }
        [Column("descripcion_ERP")]
        [StringLength(250)]
        public string DescripcionErp { get; set; }
        [Column("descripcion_clasificacion")]
        [StringLength(250)]
        public string DescripcionClasificacion { get; set; }
        [Column("descripcion_certificado")]
        [StringLength(250)]
        public string DescripcionCertificado { get; set; }
        [Column("fraccion_cliente")]
        [StringLength(8)]
        public string FraccionCliente { get; set; }
        [Column("fecha_cliente", TypeName = "datetime")]
        public DateTime? FechaCliente { get; set; }
        [Column("usuario_cliente")]
        [StringLength(6)]
        public string UsuarioCliente { get; set; }
        [Column("fraccion_agente")]
        [StringLength(8)]
        public string FraccionAgente { get; set; }
        [Column("fecha_agente", TypeName = "datetime")]
        public DateTime? FechaAgente { get; set; }
        [Column("usuario_agente")]
        [StringLength(6)]
        public string UsuarioAgente { get; set; }
        [Column("status_producto")]
        public short StatusProducto { get; set; }
        [Required]
        [Column("producto_activo")]
        public bool? ProductoActivo { get; set; }
        [Column("observaciones")]
        [StringLength(1500)]
        public string Observaciones { get; set; }
        [Column("sku")]
        [StringLength(50)]
        public string Sku { get; set; }
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
        [Column("id_regimen")]
        [StringLength(4)]
        public string IdRegimen { get; set; }
        [Column("fraccion_americana")]
        [StringLength(10)]
        public string FraccionAmericana { get; set; }
        [Column("urgente")]
        public bool? Urgente { get; set; }
        [Column("fraccion_nico_cliente")]
        [StringLength(8)]
        public string FraccionNicoCliente { get; set; }
        [Column("id_nico_cliente")]
        [StringLength(2)]
        public string IdNicoCliente { get; set; }
        [Column("fraccion_nico_agente")]
        [StringLength(8)]
        public string FraccionNicoAgente { get; set; }
        [Column("id_nico_agente")]
        [StringLength(2)]
        public string IdNicoAgente { get; set; }
        [Column("fraccion_cliente_historico")]
        [StringLength(8)]
        public string FraccionClienteHistorico { get; set; }
        [Column("fraccion_agente_historico")]
        [StringLength(8)]
        public string FraccionAgenteHistorico { get; set; }
        [Column("precio_unitario", TypeName = "decimal(16, 7)")]
        public decimal? PrecioUnitario { get; set; }
        [Column("id_moneda")]
        [StringLength(4)]
        public string IdMoneda { get; set; }
        [Column("id_pais_origen")]
        [StringLength(3)]
        public string IdPaisOrigen { get; set; }
        [Column("peso_libras", TypeName = "decimal(14, 5)")]
        public decimal? PesoLibras { get; set; }
        [Column("peso_kilos", TypeName = "decimal(14, 5)")]
        public decimal? PesoKilos { get; set; }
    }
}
