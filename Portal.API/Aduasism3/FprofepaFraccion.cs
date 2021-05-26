using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fprofepa_fraccion")]
    [Index(nameof(Rowguid), Name = "index_509296924", IsUnique = true)]
    public partial class FprofepaFraccion
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(5, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("num_secuencial", TypeName = "numeric(5, 0)")]
        public decimal NumSecuencial { get; set; }
        [Column("secuencial_ped", TypeName = "numeric(5, 0)")]
        public decimal SecuencialPed { get; set; }
        [Required]
        [Column("id_fraccion")]
        [StringLength(8)]
        public string IdFraccion { get; set; }
        [Column("id_nombre")]
        [StringLength(4)]
        public string IdNombre { get; set; }
        [Required]
        [Column("nombre_comercial")]
        [StringLength(120)]
        public string NombreComercial { get; set; }
        [Required]
        [Column("nombre_cientifico")]
        [StringLength(120)]
        public string NombreCientifico { get; set; }
        [Required]
        [Column("tipo_producto")]
        [StringLength(1)]
        public string TipoProducto { get; set; }
        [Column("cantidad_comercial", TypeName = "numeric(14, 2)")]
        public decimal CantidadComercial { get; set; }
        [Required]
        [Column("unidad_comercial")]
        [StringLength(2)]
        public string UnidadComercial { get; set; }
        [Required]
        [Column("pais_origen")]
        [StringLength(3)]
        public string PaisOrigen { get; set; }
        [Required]
        [Column("entidad_origen")]
        [StringLength(2)]
        public string EntidadOrigen { get; set; }
        [Required]
        [Column("condado_origen")]
        [StringLength(120)]
        public string CondadoOrigen { get; set; }
        [Required]
        [Column("plantacion_origen")]
        [StringLength(120)]
        public string PlantacionOrigen { get; set; }
        [Required]
        [Column("pais_procedencia")]
        [StringLength(3)]
        public string PaisProcedencia { get; set; }
        [Required]
        [Column("entidad_procedencia")]
        [StringLength(2)]
        public string EntidadProcedencia { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
