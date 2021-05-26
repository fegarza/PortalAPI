using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_proveedor")]
    public partial class OcProveedor
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_proveedor")]
        [StringLength(10)]
        public string IdProveedor { get; set; }
        [Required]
        [Column("identificacion_fiscal")]
        [StringLength(20)]
        public string IdentificacionFiscal { get; set; }
        [Required]
        [Column("nombre")]
        [StringLength(120)]
        public string Nombre { get; set; }
        [Required]
        [Column("calle")]
        [StringLength(120)]
        public string Calle { get; set; }
        [Required]
        [Column("numero_exterior")]
        [StringLength(10)]
        public string NumeroExterior { get; set; }
        [Column("numero_interior")]
        [StringLength(10)]
        public string NumeroInterior { get; set; }
        [Required]
        [Column("codigo_postal")]
        [StringLength(10)]
        public string CodigoPostal { get; set; }
        [Column("colonia")]
        [StringLength(80)]
        public string Colonia { get; set; }
        [Required]
        [Column("id_pais")]
        [StringLength(3)]
        public string IdPais { get; set; }
        [Column("id_municipio")]
        [StringLength(4)]
        public string IdMunicipio { get; set; }
        [Column("municipio")]
        [StringLength(80)]
        public string Municipio { get; set; }
        [Column("estado")]
        [StringLength(80)]
        public string Estado { get; set; }
        [Column("entidad_federativa")]
        [StringLength(3)]
        public string EntidadFederativa { get; set; }
        [Required]
        [Column("proveedor_activo")]
        public bool? ProveedorActivo { get; set; }
        [Column("vinculacion")]
        [StringLength(1)]
        public string Vinculacion { get; set; }
        [Column("valoracion")]
        [StringLength(1)]
        public string Valoracion { get; set; }
        [Column("uso_edo_mercancia")]
        [StringLength(1)]
        public string UsoEdoMercancia { get; set; }
        [Column("destinatario")]
        public bool Destinatario { get; set; }
        [Column("id_proveedor_agente")]
        [StringLength(6)]
        public string IdProveedorAgente { get; set; }
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
        [Column("genera_factura")]
        public bool GeneraFactura { get; set; }
        [Column("id_incoterm")]
        [StringLength(4)]
        public string IdIncoterm { get; set; }
        [Column("id_moneda")]
        [StringLength(4)]
        public string IdMoneda { get; set; }
        [Column("id_consignatario")]
        [StringLength(10)]
        public string IdConsignatario { get; set; }
        [Column("id_notify")]
        [StringLength(10)]
        public string IdNotify { get; set; }
        [Column("correo_electronico")]
        [StringLength(50)]
        public string CorreoElectronico { get; set; }
        [Column("previo_recibo")]
        public bool? PrevioRecibo { get; set; }
        [Column("id_tipo_material_proveedor")]
        [StringLength(4)]
        public string IdTipoMaterialProveedor { get; set; }
        [Column("telefono")]
        [StringLength(15)]
        public string Telefono { get; set; }
        [Column("distribucion")]
        public bool Distribucion { get; set; }
    }
}
