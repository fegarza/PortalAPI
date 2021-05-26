using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("ffrac_mex_adva_temp")]
    public partial class FfracMexAdvaTemp
    {
        [Required]
        [Column("id_fraccion_mex")]
        [StringLength(8)]
        public string IdFraccionMex { get; set; }
        [Column("descripcion_fm")]
        [StringLength(100)]
        public string DescripcionFm { get; set; }
        [Column("id_unidad_universal")]
        [StringLength(5)]
        public string IdUnidadUniversal { get; set; }
        [Column("cve_tipo_opn")]
        [StringLength(1)]
        public string CveTipoOpn { get; set; }
        [Column("adval_normal", TypeName = "numeric(6, 3)")]
        public decimal? AdvalNormal { get; set; }
        [Column("adval_eeuu", TypeName = "numeric(6, 3)")]
        public decimal? AdvalEeuu { get; set; }
        [Column("adval_canada", TypeName = "numeric(6, 3)")]
        public decimal? AdvalCanada { get; set; }
        [Column("adval_ff", TypeName = "numeric(6, 3)")]
        public decimal? AdvalFf { get; set; }
        [Column("id_fraccion_ame")]
        [StringLength(12)]
        public string IdFraccionAme { get; set; }
        [Column("iva")]
        [StringLength(1)]
        public string Iva { get; set; }
        [Column("cc")]
        [StringLength(1)]
        public string Cc { get; set; }
        [Column("ieps")]
        [StringLength(1)]
        public string Ieps { get; set; }
        [Column("isan")]
        [StringLength(1)]
        public string Isan { get; set; }
        [Column("colombia", TypeName = "numeric(6, 3)")]
        public decimal? Colombia { get; set; }
        [Column("venezuela", TypeName = "numeric(6, 3)")]
        public decimal? Venezuela { get; set; }
        [Column("bolivia", TypeName = "numeric(6, 3)")]
        public decimal? Bolivia { get; set; }
        [Column("costa_rica", TypeName = "numeric(6, 3)")]
        public decimal? CostaRica { get; set; }
        [Column("chile", TypeName = "numeric(6, 3)")]
        public decimal? Chile { get; set; }
        [Column("nicaragua", TypeName = "numeric(6, 3)")]
        public decimal? Nicaragua { get; set; }
        [Column("israel", TypeName = "numeric(6, 3)")]
        public decimal? Israel { get; set; }
        [Column("com_europea", TypeName = "numeric(6, 3)")]
        public decimal? ComEuropea { get; set; }
        [Column("guatemala", TypeName = "numeric(6, 3)")]
        public decimal? Guatemala { get; set; }
        [Column("salvador", TypeName = "numeric(6, 3)")]
        public decimal? Salvador { get; set; }
        [Column("honduras", TypeName = "numeric(6, 3)")]
        public decimal? Honduras { get; set; }
        [Column("suiza", TypeName = "numeric(6, 3)")]
        public decimal? Suiza { get; set; }
        [Column("noruega", TypeName = "numeric(6, 3)")]
        public decimal? Noruega { get; set; }
        [Column("islandia", TypeName = "numeric(6, 3)")]
        public decimal? Islandia { get; set; }
        [Column("tasa_electrica", TypeName = "numeric(6, 3)")]
        public decimal? TasaElectrica { get; set; }
        [Column("sn_electrica")]
        [StringLength(1)]
        public string SnElectrica { get; set; }
        [Column("tasa_electronica", TypeName = "numeric(6, 3)")]
        public decimal? TasaElectronica { get; set; }
        [Column("sn_electronica")]
        [StringLength(1)]
        public string SnElectronica { get; set; }
        [Column("tasa_muebles", TypeName = "numeric(6, 3)")]
        public decimal? TasaMuebles { get; set; }
        [Column("sn_muebles")]
        [StringLength(1)]
        public string SnMuebles { get; set; }
        [Column("tasa_juguete", TypeName = "numeric(6, 3)")]
        public decimal? TasaJuguete { get; set; }
        [Column("sn_juguete")]
        [StringLength(1)]
        public string SnJuguete { get; set; }
        [Column("tasa_calzado", TypeName = "numeric(6, 3)")]
        public decimal? TasaCalzado { get; set; }
        [Column("sn_calzado")]
        [StringLength(1)]
        public string SnCalzado { get; set; }
        [Column("tasa_mineria", TypeName = "numeric(6, 3)")]
        public decimal? TasaMineria { get; set; }
        [Column("sn_mineria")]
        [StringLength(1)]
        public string SnMineria { get; set; }
        [Column("tasa_bienes", TypeName = "numeric(6, 3)")]
        public decimal? TasaBienes { get; set; }
        [Column("sn_bienes")]
        [StringLength(1)]
        public string SnBienes { get; set; }
        [Column("tasa_fotogra", TypeName = "numeric(6, 3)")]
        public decimal? TasaFotogra { get; set; }
        [Column("sn_fotogra")]
        [StringLength(1)]
        public string SnFotogra { get; set; }
        [Column("tasa_agricola", TypeName = "numeric(6, 3)")]
        public decimal? TasaAgricola { get; set; }
        [Column("sn_agricola")]
        [StringLength(1)]
        public string SnAgricola { get; set; }
        [Column("tasa_diversos", TypeName = "numeric(6, 3)")]
        public decimal? TasaDiversos { get; set; }
        [Column("sn_diversos")]
        [StringLength(1)]
        public string SnDiversos { get; set; }
        [Column("tasa_quimica", TypeName = "numeric(6, 3)")]
        public decimal? TasaQuimica { get; set; }
        [Column("sn_quimica")]
        [StringLength(1)]
        public string SnQuimica { get; set; }
        [Column("tasa_caucho", TypeName = "numeric(6, 3)")]
        public decimal? TasaCaucho { get; set; }
        [Column("sn_caucho")]
        [StringLength(1)]
        public string SnCaucho { get; set; }
        [Column("tasa_sider", TypeName = "numeric(6, 3)")]
        public decimal? TasaSider { get; set; }
        [Column("sn_sider")]
        [StringLength(1)]
        public string SnSider { get; set; }
        [Column("tasa_farmacos", TypeName = "numeric(6, 3)")]
        public decimal? TasaFarmacos { get; set; }
        [Column("sn_farmacos")]
        [StringLength(1)]
        public string SnFarmacos { get; set; }
        [Column("tasa_transporte", TypeName = "numeric(6, 3)")]
        public decimal? TasaTransporte { get; set; }
        [Column("sn_transporte")]
        [StringLength(1)]
        public string SnTransporte { get; set; }
        [Column("tasa_papel", TypeName = "numeric(6, 3)")]
        public decimal? TasaPapel { get; set; }
        [Column("sn_papel")]
        [StringLength(1)]
        public string SnPapel { get; set; }
        [Column("tasa_madera", TypeName = "numeric(6, 3)")]
        public decimal? TasaMadera { get; set; }
        [Column("sn_madera")]
        [StringLength(1)]
        public string SnMadera { get; set; }
        [Column("tasa_cuero", TypeName = "numeric(6, 3)")]
        public decimal? TasaCuero { get; set; }
        [Column("sn_cuero")]
        [StringLength(1)]
        public string SnCuero { get; set; }
        [Column("tasa_automo", TypeName = "numeric(6, 3)")]
        public decimal? TasaAutomo { get; set; }
        [Column("sn_automo")]
        [StringLength(1)]
        public string SnAutomo { get; set; }
        [Column("tasa_textil", TypeName = "numeric(6, 3)")]
        public decimal? TasaTextil { get; set; }
        [Column("sn_textil")]
        [StringLength(1)]
        public string SnTextil { get; set; }
        [Column("tasa_choco", TypeName = "numeric(6, 3)")]
        public decimal? TasaChoco { get; set; }
        [Column("sn_choco")]
        [StringLength(1)]
        public string SnChoco { get; set; }
        [Column("tasa_cafe", TypeName = "numeric(6, 3)")]
        public decimal? TasaCafe { get; set; }
        [Column("sn_cafe")]
        [StringLength(1)]
        public string SnCafe { get; set; }
        [Column("norma")]
        [StringLength(1)]
        public string Norma { get; set; }
    }
}
