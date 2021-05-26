using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fferrocarril_carro")]
    [Index(nameof(Rowguid), Name = "index_1551344591", IsUnique = true)]
    public partial class FferrocarrilCarro
    {
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Column("id_escape")]
        public int IdEscape { get; set; }
        [Required]
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Key]
        [Column("carro_numero")]
        [StringLength(20)]
        public string CarroNumero { get; set; }
        [Column("guia")]
        [StringLength(20)]
        public string Guia { get; set; }
        [Column("peso_lbs", TypeName = "numeric(14, 3)")]
        public decimal? PesoLbs { get; set; }
        [Column("peso_kgs", TypeName = "numeric(14, 3)")]
        public decimal? PesoKgs { get; set; }
        [Column("fecha_cruce", TypeName = "datetime")]
        public DateTime? FechaCruce { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column("shipper")]
        [StringLength(20)]
        public string Shipper { get; set; }
        [Column("secuencial", TypeName = "numeric(5, 0)")]
        public decimal? Secuencial { get; set; }
        [Column("cve_entrada_aduana")]
        [StringLength(1)]
        public string CveEntradaAduana { get; set; }
    }
}
