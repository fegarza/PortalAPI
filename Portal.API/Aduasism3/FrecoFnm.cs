using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("freco_fnm")]
    public partial class FrecoFnm
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Column("fecha_con", TypeName = "datetime")]
        public DateTime? FechaCon { get; set; }
        [Column("id_estacion")]
        [StringLength(6)]
        public string IdEstacion { get; set; }
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Column("imp_exp")]
        [StringLength(1)]
        public string ImpExp { get; set; }
        [Column("estacion")]
        [StringLength(50)]
        public string Estacion { get; set; }
        [Column("escapes")]
        [StringLength(50)]
        public string Escapes { get; set; }
        [Column("consigna")]
        [StringLength(48)]
        public string Consigna { get; set; }
        [Column("calle_consigna")]
        [StringLength(30)]
        public string CalleConsigna { get; set; }
        [Column("numero_consigna")]
        [StringLength(30)]
        public string NumeroConsigna { get; set; }
        [Column("id_municipio")]
        [StringLength(4)]
        public string IdMunicipio { get; set; }
        [Column("municipio_consigna")]
        [StringLength(40)]
        public string MunicipioConsigna { get; set; }
        [Column("estado")]
        [StringLength(10)]
        public string Estado { get; set; }
        [Column("rfc")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Column("telefono")]
        [StringLength(20)]
        public string Telefono { get; set; }
        [Column("reconsigna")]
        [StringLength(48)]
        public string Reconsigna { get; set; }
        [Column("domicilio_reconsigna")]
        [StringLength(40)]
        public string DomicilioReconsigna { get; set; }
        [Column("telefono_reconsigna")]
        [StringLength(20)]
        public string TelefonoReconsigna { get; set; }
        [Column("final_reconsigna")]
        [StringLength(40)]
        public string FinalReconsigna { get; set; }
        [Column("observacion1")]
        [StringLength(60)]
        public string Observacion1 { get; set; }
        [Column("observacion2")]
        [StringLength(60)]
        public string Observacion2 { get; set; }
        [Column("descripcion_art")]
        [StringLength(60)]
        public string DescripcionArt { get; set; }
        [Column("inst_manejo")]
        [StringLength(60)]
        public string InstManejo { get; set; }
        [Column("bultos", TypeName = "numeric(6, 0)")]
        public decimal? Bultos { get; set; }
        [Column("cond_pago")]
        [StringLength(10)]
        public string CondPago { get; set; }
        [Column("peso_docu", TypeName = "numeric(12, 3)")]
        public decimal? PesoDocu { get; set; }
        [Column("peso_veri", TypeName = "numeric(12, 3)")]
        public decimal? PesoVeri { get; set; }
        [Column("linea")]
        [StringLength(1)]
        public string Linea { get; set; }
        [Column("tipo_ser")]
        [StringLength(1)]
        public string TipoSer { get; set; }
        [Column("pagos")]
        [StringLength(10)]
        public string Pagos { get; set; }
        [Column("auto")]
        [StringLength(40)]
        public string Auto { get; set; }
        [Column("porcentaje")]
        [StringLength(5)]
        public string Porcentaje { get; set; }
        [Column("tipo_carro")]
        [StringLength(15)]
        public string TipoCarro { get; set; }
        [Column("iniciales")]
        [StringLength(7)]
        public string Iniciales { get; set; }
        [Column("numero", TypeName = "numeric(6, 0)")]
        public decimal? Numero { get; set; }
        [Column("numero_econo")]
        [StringLength(8)]
        public string NumeroEcono { get; set; }
    }
}
