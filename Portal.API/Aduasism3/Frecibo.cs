using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frecibo")]
    public partial class Frecibo
    {
        [Required]
        [Column("id_bodega")]
        [StringLength(8)]
        public string IdBodega { get; set; }
        [Key]
        [Column("id_entrada")]
        [StringLength(10)]
        public string IdEntrada { get; set; }
        [Column("fecha_entrada", TypeName = "datetime")]
        public DateTime FechaEntrada { get; set; }
        [Required]
        [Column("id_usuario_recibe")]
        [StringLength(6)]
        public string IdUsuarioRecibe { get; set; }
        [Required]
        [Column("marca_mcia")]
        [StringLength(20)]
        public string MarcaMcia { get; set; }
        [Required]
        [Column("cve_tipo_opn")]
        [StringLength(1)]
        public string CveTipoOpn { get; set; }
        [Required]
        [Column("guia_flete")]
        [StringLength(20)]
        public string GuiaFlete { get; set; }
        [Column("fecha_guia", TypeName = "datetime")]
        public DateTime FechaGuia { get; set; }
        [Required]
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Required]
        [Column("num_vehiculo")]
        [StringLength(20)]
        public string NumVehiculo { get; set; }
        [Column("cve_flete_pagado", TypeName = "numeric(1, 0)")]
        public decimal CveFletePagado { get; set; }
        [Column("importe_flete", TypeName = "numeric(10, 2)")]
        public decimal ImporteFlete { get; set; }
        [Required]
        [Column("id_linea_fletera")]
        [StringLength(4)]
        public string IdLineaFletera { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ultmodif", TypeName = "datetime")]
        public DateTime FechaUltmodif { get; set; }
        [Required]
        [Column("id_usuario_ult_modif")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
        [Required]
        [Column("situacion")]
        [StringLength(1)]
        public string Situacion { get; set; }
        [Column("observaciones", TypeName = "text")]
        public string Observaciones { get; set; }
        [Column("directa")]
        [StringLength(1)]
        public string Directa { get; set; }
        [Column("peso_kgs", TypeName = "numeric(14, 3)")]
        public decimal? PesoKgs { get; set; }
        [Column("peso_libras", TypeName = "numeric(14, 3)")]
        public decimal? PesoLibras { get; set; }
        [Column("cantidad_bultos", TypeName = "numeric(18, 0)")]
        public decimal? CantidadBultos { get; set; }
        [Column("sello", TypeName = "text")]
        public string Sello { get; set; }
        [Column("osd")]
        [StringLength(1)]
        public string Osd { get; set; }
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("tipo_osd")]
        [StringLength(1)]
        public string TipoOsd { get; set; }
        [Column("observ_osd", TypeName = "text")]
        public string ObservOsd { get; set; }
        [Column("fecha_aprox_arribo", TypeName = "datetime")]
        public DateTime? FechaAproxArribo { get; set; }
    }
}
