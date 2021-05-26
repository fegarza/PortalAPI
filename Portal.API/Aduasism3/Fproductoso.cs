using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fproductosos")]
    public partial class Fproductoso
    {
        [Column("id_cliente")]
        [StringLength(255)]
        public string IdCliente { get; set; }
        [Column("id_proveedor")]
        [StringLength(255)]
        public string IdProveedor { get; set; }
        [Column("id_producto")]
        [StringLength(255)]
        public string IdProducto { get; set; }
        [Column("descripcion")]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Column("desc_abreviado")]
        [StringLength(255)]
        public string DescAbreviado { get; set; }
        [Column("descripcion_clas")]
        [StringLength(255)]
        public string DescripcionClas { get; set; }
        [Column("grs_azucar_x_kg")]
        public double? GrsAzucarXKg { get; set; }
        [Column("peso_neto_kgs")]
        public double? PesoNetoKgs { get; set; }
        [Column("peso_bruto_kgs")]
        public double? PesoBrutoKgs { get; set; }
        [Column("precio_unitario")]
        public double? PrecioUnitario { get; set; }
        [Column("id_unidad")]
        [StringLength(255)]
        public string IdUnidad { get; set; }
        [Column("id_pais_origen")]
        [StringLength(255)]
        public string IdPaisOrigen { get; set; }
        [Column("cve_cert_origen")]
        [StringLength(255)]
        public string CveCertOrigen { get; set; }
        [Column("cve_carta_juram")]
        [StringLength(255)]
        public string CveCartaJuram { get; set; }
        [Column("cve_series")]
        [StringLength(255)]
        public string CveSeries { get; set; }
        [Column("cve_tlc")]
        [StringLength(255)]
        public string CveTlc { get; set; }
        [Column("criterio")]
        [StringLength(255)]
        public string Criterio { get; set; }
        [Column("costo_neto")]
        [StringLength(255)]
        public string CostoNeto { get; set; }
        [Column("origen_mercancia")]
        [StringLength(255)]
        public string OrigenMercancia { get; set; }
        [Column("fabricante")]
        [StringLength(255)]
        public string Fabricante { get; set; }
        [Column("observaciones")]
        [StringLength(255)]
        public string Observaciones { get; set; }
        [Column("clasificado")]
        [StringLength(255)]
        public string Clasificado { get; set; }
        [Column("fecha_registro", TypeName = "smalldatetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column("id_usuario_registro")]
        [StringLength(255)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ult_modificacion", TypeName = "smalldatetime")]
        public DateTime? FechaUltModificacion { get; set; }
        [Column("id_usuario_ult_modificacion")]
        [StringLength(255)]
        public string IdUsuarioUltModificacion { get; set; }
    }
}
