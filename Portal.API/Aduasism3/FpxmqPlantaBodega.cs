using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpxmq_planta_bodega")]
    public partial class FpxmqPlantaBodega
    {
        [Key]
        [Column("clave_planta")]
        [StringLength(4)]
        public string ClavePlanta { get; set; }
        [Column("RFC")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Column("Tipo_domicilio")]
        public short? TipoDomicilio { get; set; }
        [StringLength(40)]
        public string Calle { get; set; }
        [Column("Num_ext")]
        [StringLength(10)]
        public string NumExt { get; set; }
        [Column("num_int")]
        [StringLength(10)]
        public string NumInt { get; set; }
        [StringLength(40)]
        public string Colonia { get; set; }
        [Column("cp")]
        [StringLength(5)]
        public string Cp { get; set; }
        [Column("id_municipio")]
        [StringLength(4)]
        public string IdMunicipio { get; set; }
        [Column("entidad_federativa")]
        [StringLength(2)]
        public string EntidadFederativa { get; set; }
        [StringLength(1)]
        public string Movimiento { get; set; }
        [Column("Fecha_inicio", TypeName = "datetime")]
        public DateTime? FechaInicio { get; set; }
        [Column("fecha_final", TypeName = "datetime")]
        public DateTime? FechaFinal { get; set; }
        [Column("firma")]
        [StringLength(250)]
        public string Firma { get; set; }
        [Column("num_serie")]
        [StringLength(45)]
        public string NumSerie { get; set; }
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("curp")]
        [StringLength(18)]
        public string Curp { get; set; }
        [Column("acuse")]
        [StringLength(8)]
        public string Acuse { get; set; }
        [Required]
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_ult_modif")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
        [Column("fecha_ult_modif", TypeName = "datetime")]
        public DateTime FechaUltModif { get; set; }
        [Column("archivo_generado")]
        [StringLength(250)]
        public string ArchivoGenerado { get; set; }
    }
}
