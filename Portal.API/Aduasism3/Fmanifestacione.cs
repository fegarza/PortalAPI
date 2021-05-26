using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fmanifestaciones")]
    public partial class Fmanifestacione
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion")]
        public int IdRectificacion { get; set; }
        [Column("id_contacto")]
        [StringLength(10)]
        public string IdContacto { get; set; }
        [Column("nombre")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Column("apellido_p")]
        [StringLength(50)]
        public string ApellidoP { get; set; }
        [Column("apellido_m")]
        [StringLength(50)]
        public string ApellidoM { get; set; }
        [Column("puesto")]
        [StringLength(50)]
        public string Puesto { get; set; }
        [Column("rfc")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Column("unica")]
        [StringLength(50)]
        public string Unica { get; set; }
        [Column("metodo")]
        [StringLength(10)]
        public string Metodo { get; set; }
        [Column("razon")]
        [StringLength(500)]
        public string Razon { get; set; }
        [Column("id_usuario_reg")]
        [StringLength(10)]
        public string IdUsuarioReg { get; set; }
        [Column("fecha_reg", TypeName = "datetime")]
        public DateTime? FechaReg { get; set; }
        [Column("id_usuario_utl_mod")]
        [StringLength(10)]
        public string IdUsuarioUtlMod { get; set; }
        [Column("fecha_ult_mod", TypeName = "datetime")]
        public DateTime? FechaUltMod { get; set; }
        [Column("fecha_recepcion", TypeName = "datetime")]
        public DateTime? FechaRecepcion { get; set; }
        [Column("firma_autografa")]
        [StringLength(30)]
        public string FirmaAutografa { get; set; }
        [Column("usuario_recep")]
        [StringLength(50)]
        public string UsuarioRecep { get; set; }
        [Column("folio", TypeName = "numeric(18, 0)")]
        public decimal? Folio { get; set; }
        [Column("comisiones", TypeName = "decimal(12, 2)")]
        public decimal? Comisiones { get; set; }
        [Column("fletes", TypeName = "decimal(12, 2)")]
        public decimal? Fletes { get; set; }
        [Column("seguros", TypeName = "decimal(12, 2)")]
        public decimal? Seguros { get; set; }
        [Column("carga_descarga", TypeName = "decimal(12, 2)")]
        public decimal? CargaDescarga { get; set; }
        [Column("envases_ensambles", TypeName = "decimal(12, 2)")]
        public decimal? EnvasesEnsambles { get; set; }
        [Column("tecnologia", TypeName = "decimal(12, 2)")]
        public decimal? Tecnologia { get; set; }
        [Column("otros", TypeName = "decimal(12, 2)")]
        public decimal? Otros { get; set; }
        [Column("tipo_moneda")]
        [StringLength(3)]
        public string TipoMoneda { get; set; }
        [Column("fanexo_1")]
        [StringLength(1)]
        public string Fanexo1 { get; set; }
        [Column("fanexo_2")]
        [StringLength(1)]
        public string Fanexo2 { get; set; }
        [Column("fanexo_3")]
        [StringLength(1)]
        public string Fanexo3 { get; set; }
        [Column("fanexo_4")]
        [StringLength(1)]
        public string Fanexo4 { get; set; }
        [Column("fanexo_5")]
        [StringLength(1)]
        public string Fanexo5 { get; set; }
        [Column("fanexo_6")]
        [StringLength(1)]
        public string Fanexo6 { get; set; }
        [Column("otros_metodos_a")]
        [StringLength(1)]
        public string OtrosMetodosA { get; set; }
        [Column("otros_metodos_b")]
        [StringLength(1)]
        public string OtrosMetodosB { get; set; }
        [Column("imp_temp_1")]
        [StringLength(1)]
        public string ImpTemp1 { get; set; }
        [Column("imp_temp_2")]
        [StringLength(1)]
        public string ImpTemp2 { get; set; }
        [Column("imp_temp_3")]
        [StringLength(1)]
        public string ImpTemp3 { get; set; }
        [Column("numero_hojas")]
        [StringLength(255)]
        public string NumeroHojas { get; set; }
        [Column("anexo_manifestacion")]
        [StringLength(1)]
        public string AnexoManifestacion { get; set; }
        [Column("precio_pagado", TypeName = "decimal(12, 2)")]
        public decimal? PrecioPagado { get; set; }
        [Column("anexa_documentacion")]
        [StringLength(1)]
        public string AnexaDocumentacion { get; set; }
        [Column("descripcion_documentacion")]
        [StringLength(250)]
        public string DescripcionDocumentacion { get; set; }
        [Column("fvalortransacciondemercancia")]
        [StringLength(1)]
        public string Fvalortransacciondemercancia { get; set; }
        [Column("valornoanexadoc")]
        [StringLength(1)]
        public string Valornoanexadoc { get; set; }
    }
}
