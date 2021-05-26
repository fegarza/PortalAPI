using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_importador_exportador")]
    public partial class TpImportadorExportador
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("id_importador_exp")]
        public short IdImportadorExp { get; set; }
        [Column("rfc")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Column("curp")]
        [StringLength(18)]
        public string Curp { get; set; }
        [Column("razon_social")]
        [StringLength(120)]
        public string RazonSocial { get; set; }
        [Column("calle")]
        [StringLength(80)]
        public string Calle { get; set; }
        [Column("numero_exterior")]
        [StringLength(10)]
        public string NumeroExterior { get; set; }
        [Column("numero_interior")]
        [StringLength(10)]
        public string NumeroInterior { get; set; }
        [Column("ciudad_municipio")]
        [StringLength(80)]
        public string CiudadMunicipio { get; set; }
        [Column("codigo_postal")]
        [StringLength(10)]
        public string CodigoPostal { get; set; }
        [Column("pais_direccion")]
        [StringLength(250)]
        public string PaisDireccion { get; set; }
        [Column("seguros", TypeName = "decimal(12, 0)")]
        public decimal? Seguros { get; set; }
        [Column("fletes", TypeName = "decimal(12, 0)")]
        public decimal? Fletes { get; set; }
        [Column("embalajes", TypeName = "decimal(12, 0)")]
        public decimal? Embalajes { get; set; }
        [Column("incrementables", TypeName = "decimal(12, 0)")]
        public decimal? Incrementables { get; set; }
        [Column("aduana_despacho")]
        public int? AduanaDespacho { get; set; }
        [Column("bultos")]
        public int? Bultos { get; set; }
        [Column("efectivo", TypeName = "decimal(12, 0)")]
        public decimal? Efectivo { get; set; }
        [Column("otros", TypeName = "decimal(12, 0)")]
        public decimal? Otros { get; set; }
        [Column("total", TypeName = "decimal(12, 0)")]
        public decimal? Total { get; set; }
        [Column("pais")]
        [StringLength(3)]
        public string Pais { get; set; }
    }
}
