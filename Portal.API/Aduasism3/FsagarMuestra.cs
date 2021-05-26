using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fsagar_muestra")]
    [Index(nameof(Rowguid), Name = "index_1895729856", IsUnique = true)]
    public partial class FsagarMuestra
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("secuencial", TypeName = "decimal(4, 0)")]
        public decimal Secuencial { get; set; }
        [Key]
        [Column("consecutivo", TypeName = "decimal(4, 0)")]
        public decimal Consecutivo { get; set; }
        [Column("operacion", TypeName = "numeric(5, 0)")]
        public decimal? Operacion { get; set; }
        [Column("fecha_operacion", TypeName = "datetime")]
        public DateTime? FechaOperacion { get; set; }
        [Column("tipo_lab")]
        [StringLength(3)]
        public string TipoLab { get; set; }
        [Column("nombre_lab")]
        [StringLength(80)]
        public string NombreLab { get; set; }
        [Column("clave_lab")]
        [StringLength(2)]
        public string ClaveLab { get; set; }
        [Column("descripcion")]
        [StringLength(80)]
        public string Descripcion { get; set; }
        [Column("uso")]
        [StringLength(50)]
        public string Uso { get; set; }
        [Column("variedad")]
        [StringLength(50)]
        public string Variedad { get; set; }
        [Column("cantidad", TypeName = "decimal(6, 0)")]
        public decimal? Cantidad { get; set; }
        [Column("req_factura")]
        [StringLength(3)]
        public string ReqFactura { get; set; }
        [Column("fecha_pago", TypeName = "datetime")]
        public DateTime? FechaPago { get; set; }
        [Column("monto_pagado", TypeName = "decimal(14, 2)")]
        public decimal? MontoPagado { get; set; }
        [Column("cie")]
        [StringLength(20)]
        public string Cie { get; set; }
        [Column("razon_social")]
        [StringLength(50)]
        public string RazonSocial { get; set; }
        [Column("rfc")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Column("calle")]
        [StringLength(25)]
        public string Calle { get; set; }
        [Column("numero")]
        [StringLength(5)]
        public string Numero { get; set; }
        [Column("colonia")]
        [StringLength(60)]
        public string Colonia { get; set; }
        [Column("cp")]
        [StringLength(5)]
        public string Cp { get; set; }
        [Column("estado")]
        [StringLength(3)]
        public string Estado { get; set; }
        [Column("municipio")]
        [StringLength(25)]
        public string Municipio { get; set; }
        [Column("telefono")]
        [StringLength(20)]
        public string Telefono { get; set; }
        [Column("numero_cuenta")]
        [StringLength(20)]
        public string NumeroCuenta { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("ID_MUNICIPIO")]
        [StringLength(4)]
        public string IdMunicipio { get; set; }
        [Column("NUMERO_INTERIOR")]
        [StringLength(15)]
        public string NumeroInterior { get; set; }
        [Column("analisis")]
        [StringLength(40)]
        public string Analisis { get; set; }
    }
}
