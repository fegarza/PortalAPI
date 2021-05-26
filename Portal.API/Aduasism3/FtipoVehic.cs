using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("FTIPO_VEHIC")]
    [Index(nameof(Rowguid), Name = "index_181575685", IsUnique = true)]
    public partial class FtipoVehic
    {
        public FtipoVehic()
        {
            Fembarque1s = new HashSet<Fembarque1>();
        }

        [Key]
        [Column("ID_TIPO_VEHICULO")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(30)]
        public string Descripcion { get; set; }
        [Column("abreviado")]
        [StringLength(5)]
        public string Abreviado { get; set; }
        [Column("SELLOS")]
        [StringLength(1)]
        public string Sellos { get; set; }
        [Column("description")]
        [StringLength(30)]
        public string Description { get; set; }
        [Column("cve_transporte")]
        [StringLength(1)]
        public string CveTransporte { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("id_tipo_contenedor")]
        [StringLength(2)]
        public string IdTipoContenedor { get; set; }
        [Column("peso_limite", TypeName = "decimal(12, 3)")]
        public decimal? PesoLimite { get; set; }
        [Column("activo")]
        public bool Activo { get; set; }

        [InverseProperty(nameof(Fembarque1.IdTipoVehiculoNavigation))]
        public virtual ICollection<Fembarque1> Fembarque1s { get; set; }
    }
}
