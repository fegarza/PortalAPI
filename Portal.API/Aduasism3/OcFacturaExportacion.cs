using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_factura_exportacion")]
    public partial class OcFacturaExportacion
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_proveedor")]
        [StringLength(10)]
        public string IdProveedor { get; set; }
        [Key]
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Column("fecha_factura", TypeName = "date")]
        public DateTime FechaFactura { get; set; }
        [Required]
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Column("pedimento")]
        [StringLength(18)]
        public string Pedimento { get; set; }
        [Column("remesa")]
        public int? Remesa { get; set; }
        [Column("numero_vehiculo")]
        [StringLength(20)]
        public string NumeroVehiculo { get; set; }
        [Column("importe_factura", TypeName = "decimal(12, 2)")]
        public decimal ImporteFactura { get; set; }
        [Column("cantidad_bultos")]
        public int CantidadBultos { get; set; }
        [Column("peso_kilos", TypeName = "decimal(14, 3)")]
        public decimal? PesoKilos { get; set; }
        [Required]
        [Column("incoterm")]
        [StringLength(4)]
        public string Incoterm { get; set; }
        [Required]
        [Column("proveedor_nombre")]
        [StringLength(120)]
        public string ProveedorNombre { get; set; }
        [Required]
        [Column("proveedor_direccion")]
        [StringLength(170)]
        public string ProveedorDireccion { get; set; }
        [Required]
        [Column("proveedor_ciudad")]
        [StringLength(80)]
        public string ProveedorCiudad { get; set; }
        [Required]
        [Column("proveedor_estado")]
        [StringLength(40)]
        public string ProveedorEstado { get; set; }
        [Required]
        [Column("proveedor_cp")]
        [StringLength(10)]
        public string ProveedorCp { get; set; }
        [Required]
        [Column("proveedor_irs")]
        [StringLength(20)]
        public string ProveedorIrs { get; set; }
        [Required]
        [Column("cliente_nombre")]
        [StringLength(120)]
        public string ClienteNombre { get; set; }
        [Required]
        [Column("cliente_direccion")]
        [StringLength(170)]
        public string ClienteDireccion { get; set; }
        [Required]
        [Column("cliente_colonia")]
        [StringLength(60)]
        public string ClienteColonia { get; set; }
        [Required]
        [Column("cliente_ciudad")]
        [StringLength(80)]
        public string ClienteCiudad { get; set; }
        [Required]
        [Column("cliente_estado")]
        [StringLength(40)]
        public string ClienteEstado { get; set; }
        [Required]
        [Column("cliente_cp")]
        [StringLength(10)]
        public string ClienteCp { get; set; }
        [Required]
        [Column("cliente_rfc")]
        [StringLength(13)]
        public string ClienteRfc { get; set; }
        [Column("cliente_certificado")]
        [StringLength(10)]
        public string ClienteCertificado { get; set; }
        [Column("cliente_immex")]
        [StringLength(10)]
        public string ClienteImmex { get; set; }
        [Column("consignatario_nombre")]
        [StringLength(120)]
        public string ConsignatarioNombre { get; set; }
        [Column("consignatario_direccion")]
        [StringLength(170)]
        public string ConsignatarioDireccion { get; set; }
        [Column("consignatario_ciudad")]
        [StringLength(80)]
        public string ConsignatarioCiudad { get; set; }
        [Column("consignatario_estado")]
        [StringLength(40)]
        public string ConsignatarioEstado { get; set; }
        [Column("consignatario_cp")]
        [StringLength(10)]
        public string ConsignatarioCp { get; set; }
        [Column("cove_numero")]
        [StringLength(13)]
        public string CoveNumero { get; set; }
        [Column("linea_scac")]
        [StringLength(4)]
        public string LineaScac { get; set; }
        [Column("linea_nombre")]
        [StringLength(120)]
        public string LineaNombre { get; set; }
        [Column("linea_direccion")]
        [StringLength(170)]
        public string LineaDireccion { get; set; }
        [Column("linea_ciudad")]
        [StringLength(80)]
        public string LineaCiudad { get; set; }
        [Column("linea_estado")]
        [StringLength(40)]
        public string LineaEstado { get; set; }
        [Column("linea_cp")]
        [StringLength(10)]
        public string LineaCp { get; set; }
        [Required]
        [Column("id_moneda")]
        [StringLength(4)]
        public string IdMoneda { get; set; }
        [Column("tipo_cambio", TypeName = "decimal(18, 6)")]
        public decimal TipoCambio { get; set; }
        [Column("status_factura")]
        public short StatusFactura { get; set; }
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Column("id_recibo")]
        [StringLength(10)]
        public string IdRecibo { get; set; }
        [Required]
        [Column("usuario_ingreso")]
        [StringLength(6)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime FechaIngreso { get; set; }
        [Column("usuario_modifica")]
        [StringLength(6)]
        public string UsuarioModifica { get; set; }
        [Column("fecha_modifica", TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
        [Column("id_destinatario")]
        [StringLength(10)]
        public string IdDestinatario { get; set; }
        [Column("qr_code")]
        [StringLength(100)]
        public string QrCode { get; set; }
        [Column("encontrado")]
        public bool? Encontrado { get; set; }
        [Column("valido")]
        public bool? Valido { get; set; }
        [Column("importe_comercial", TypeName = "decimal(12, 2)")]
        public decimal ImporteComercial { get; set; }
        [Column("folio")]
        [StringLength(50)]
        public string Folio { get; set; }
    }
}
