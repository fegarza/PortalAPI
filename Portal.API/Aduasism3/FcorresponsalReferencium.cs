using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcorresponsal_referencia")]
    public partial class FcorresponsalReferencium
    {
        [Key]
        [Column("consecutivo", TypeName = "numeric(18, 0)")]
        public decimal Consecutivo { get; set; }
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal? IdRectificacion { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Required]
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("referencia_corres")]
        [StringLength(15)]
        public string ReferenciaCorres { get; set; }
        [Column("contacto")]
        [StringLength(50)]
        public string Contacto { get; set; }
        [Column("destino")]
        [StringLength(50)]
        public string Destino { get; set; }
        [Column("corresponsal")]
        [StringLength(50)]
        public string Corresponsal { get; set; }
        [Column("factura")]
        [StringLength(50)]
        public string Factura { get; set; }
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Column("mercancia")]
        [StringLength(50)]
        public string Mercancia { get; set; }
        [Column("linea_barco")]
        [StringLength(20)]
        public string LineaBarco { get; set; }
        [Column("bill_guia")]
        [StringLength(25)]
        public string BillGuia { get; set; }
        [Column("transporte")]
        [StringLength(25)]
        public string Transporte { get; set; }
        [Column("No_contenedor")]
        [StringLength(15)]
        public string NoContenedor { get; set; }
        [Column("fecha_arribo", TypeName = "datetime")]
        public DateTime? FechaArribo { get; set; }
        [Column("importe_ant", TypeName = "decimal(14, 2)")]
        public decimal? ImporteAnt { get; set; }
        [Column("fecha_deposito", TypeName = "datetime")]
        public DateTime? FechaDeposito { get; set; }
        [Column("fecha_despacho", TypeName = "datetime")]
        public DateTime? FechaDespacho { get; set; }
        [Column("fecha_recibo_ctgs", TypeName = "datetime")]
        public DateTime? FechaReciboCtgs { get; set; }
        [Column("comentarios")]
        [StringLength(80)]
        public string Comentarios { get; set; }
        [Column("talon_salida")]
        [StringLength(20)]
        public string TalonSalida { get; set; }
        [Column("linea_salida")]
        [StringLength(20)]
        public string LineaSalida { get; set; }
        [Column("status")]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("patente")]
        [StringLength(4)]
        public string Patente { get; set; }
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column("id_usuario_ult_mod")]
        [StringLength(6)]
        public string IdUsuarioUltMod { get; set; }
        [Column("fecha_ult_mod", TypeName = "datetime")]
        public DateTime? FechaUltMod { get; set; }
    }
}
