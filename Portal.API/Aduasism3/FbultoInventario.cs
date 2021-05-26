using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fbulto_inventario")]
    [Index(nameof(Rowguid), Name = "index_1962490070", IsUnique = true)]
    public partial class FbultoInventario
    {
        [Key]
        [Column("id_entrada")]
        [StringLength(10)]
        public string IdEntrada { get; set; }
        [Key]
        [Column("no_sec_rep", TypeName = "numeric(3, 0)")]
        public decimal NoSecRep { get; set; }
        [Column("fecha_rep", TypeName = "datetime")]
        public DateTime? FechaRep { get; set; }
        [Column("shipper")]
        [StringLength(10)]
        public string Shipper { get; set; }
        [Column("carrier")]
        [StringLength(60)]
        public string Carrier { get; set; }
        [Column("consignatario")]
        [StringLength(60)]
        public string Consignatario { get; set; }
        [Column("destino")]
        [StringLength(30)]
        public string Destino { get; set; }
        [Column("estado")]
        [StringLength(10)]
        public string Estado { get; set; }
        [Column("pais")]
        [StringLength(30)]
        public string Pais { get; set; }
        [Column("ruta")]
        [StringLength(40)]
        public string Ruta { get; set; }
        [Column("flatcar_ini")]
        [StringLength(20)]
        public string FlatcarIni { get; set; }
        [Column("flatcar_num")]
        [StringLength(8)]
        public string FlatcarNum { get; set; }
        [Column("carrier_deliv")]
        [StringLength(40)]
        public string CarrierDeliv { get; set; }
        [Column("trailer_ini")]
        [StringLength(20)]
        public string TrailerIni { get; set; }
        [Column("trailer_num")]
        [StringLength(8)]
        public string TrailerNum { get; set; }
        [Column("tipo_pago")]
        [StringLength(1)]
        public string TipoPago { get; set; }
        [Column("telefono")]
        [StringLength(20)]
        public string Telefono { get; set; }
        [Column("contacto")]
        [StringLength(20)]
        public string Contacto { get; set; }
        [Column("cuenta")]
        [StringLength(60)]
        public string Cuenta { get; set; }
        [Column("seal_no")]
        [StringLength(40)]
        public string SealNo { get; set; }
        [Column("blo_bra")]
        [StringLength(1)]
        public string BloBra { get; set; }
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
        [Column("observaciones")]
        [StringLength(255)]
        public string Observaciones { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
