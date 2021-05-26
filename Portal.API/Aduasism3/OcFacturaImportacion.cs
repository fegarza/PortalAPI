using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_factura_importacion")]
    public partial class OcFacturaImportacion
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
        [Column("asn_consolidacion")]
        [StringLength(15)]
        public string AsnConsolidacion { get; set; }
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
        [Column("consignatario_colonia")]
        [StringLength(60)]
        public string ConsignatarioColonia { get; set; }
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
        [StringLength(17)]
        public string CoveNumero { get; set; }
        [Column("id_bodega")]
        [StringLength(8)]
        public string IdBodega { get; set; }
        [Column("status_factura")]
        public short StatusFactura { get; set; }
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
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Column("id_recibo")]
        [StringLength(10)]
        public string IdRecibo { get; set; }
        [Column("id_destino")]
        [StringLength(4)]
        public string IdDestino { get; set; }
        [Column("fecha_entrega_programada", TypeName = "datetime")]
        public DateTime? FechaEntregaProgramada { get; set; }
        [Column("fecha_cruce_programada", TypeName = "datetime")]
        public DateTime? FechaCruceProgramada { get; set; }
        [Column("importe_comercial", TypeName = "decimal(12, 2)")]
        public decimal ImporteComercial { get; set; }
        [Column("importe_flete", TypeName = "decimal(12, 2)")]
        public decimal ImporteFlete { get; set; }
        [Column("importe_seguro", TypeName = "decimal(12, 2)")]
        public decimal ImporteSeguro { get; set; }
        [Column("importe_embalaje", TypeName = "decimal(12, 2)")]
        public decimal ImporteEmbalaje { get; set; }
        [Column("importe_otros", TypeName = "decimal(12, 2)")]
        public decimal ImporteOtros { get; set; }
        [Column("orden_compra")]
        [StringLength(15)]
        public string OrdenCompra { get; set; }
        [Required]
        [Column("id_moneda")]
        [StringLength(4)]
        public string IdMoneda { get; set; }
        [Column("numero_guia")]
        [StringLength(35)]
        public string NumeroGuia { get; set; }
        [Column("referencia_cliente")]
        [StringLength(50)]
        public string ReferenciaCliente { get; set; }
        [Column("id_consignatario")]
        [StringLength(10)]
        public string IdConsignatario { get; set; }
        [Column("id_linea_fletera")]
        [StringLength(4)]
        public string IdLineaFletera { get; set; }
        [Column("flete")]
        [StringLength(100)]
        public string Flete { get; set; }
        [Column("termino_pago")]
        [StringLength(100)]
        public string TerminoPago { get; set; }
        [Column("incoterm_descripcion")]
        [StringLength(80)]
        public string IncotermDescripcion { get; set; }
        [Column("firma_autoriza")]
        [StringLength(100)]
        public string FirmaAutoriza { get; set; }
        [Column("vessel_voyage")]
        [StringLength(10)]
        public string VesselVoyage { get; set; }
        [Column("fecha_arribo", TypeName = "datetime")]
        public DateTime? FechaArribo { get; set; }
        [Column("bol_no")]
        [StringLength(10)]
        public string BolNo { get; set; }
        [Column("referencia_banco")]
        [StringLength(20)]
        public string ReferenciaBanco { get; set; }
        [Column("referencia2")]
        [StringLength(50)]
        public string Referencia2 { get; set; }
        [Column("no_eei")]
        [StringLength(15)]
        public string NoEei { get; set; }
        [Column("id_regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
    }
}
