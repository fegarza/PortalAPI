using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fprofepa_transportista")]
    [Index(nameof(Rowguid), Name = "index_605297266", IsUnique = true)]
    public partial class FprofepaTransportistum
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(5, 0)")]
        public decimal IdRectificacion { get; set; }
        [Required]
        [Column("ruta")]
        [StringLength(120)]
        public string Ruta { get; set; }
        [Column("fianza", TypeName = "numeric(13, 0)")]
        public decimal? Fianza { get; set; }
        [Column("vigencia_fianza", TypeName = "datetime")]
        public DateTime? VigenciaFianza { get; set; }
        [Required]
        [Column("id_linea_fletera")]
        [StringLength(6)]
        public string IdLineaFletera { get; set; }
        [Required]
        [Column("nombre")]
        [StringLength(120)]
        public string Nombre { get; set; }
        [Required]
        [Column("calle")]
        [StringLength(40)]
        public string Calle { get; set; }
        [Column("numero_ext")]
        [StringLength(10)]
        public string NumeroExt { get; set; }
        [Column("numero_int")]
        [StringLength(50)]
        public string NumeroInt { get; set; }
        [Required]
        [Column("codigo_postal")]
        [StringLength(6)]
        public string CodigoPostal { get; set; }
        [Required]
        [Column("id_municipio")]
        [StringLength(6)]
        public string IdMunicipio { get; set; }
        [Required]
        [Column("entidad")]
        [StringLength(3)]
        public string Entidad { get; set; }
        [Required]
        [Column("pais")]
        [StringLength(3)]
        public string Pais { get; set; }
        [Column("autorizacion_unidad")]
        [StringLength(25)]
        public string AutorizacionUnidad { get; set; }
        [Column("placas_unidad")]
        [StringLength(10)]
        public string PlacasUnidad { get; set; }
        [Column("numero_serie_unidad")]
        [StringLength(25)]
        public string NumeroSerieUnidad { get; set; }
        [Column("vigencia_unidad", TypeName = "datetime")]
        public DateTime? VigenciaUnidad { get; set; }
        [Column("autorizacion_tracto")]
        [StringLength(25)]
        public string AutorizacionTracto { get; set; }
        [Column("placas_tracto")]
        [StringLength(10)]
        public string PlacasTracto { get; set; }
        [Column("numero_serie_tracto")]
        [StringLength(25)]
        public string NumeroSerieTracto { get; set; }
        [Column("vigencia_tracto", TypeName = "datetime")]
        public DateTime? VigenciaTracto { get; set; }
        [Column("numero_seguro")]
        [StringLength(25)]
        public string NumeroSeguro { get; set; }
        [Column("aseguradora")]
        [StringLength(120)]
        public string Aseguradora { get; set; }
        [Column("importe_poliza", TypeName = "decimal(15, 2)")]
        public decimal? ImportePoliza { get; set; }
        [Column("operador")]
        [StringLength(120)]
        public string Operador { get; set; }
        [Column("manifiesto_entrega")]
        [StringLength(20)]
        public string ManifiestoEntrega { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
