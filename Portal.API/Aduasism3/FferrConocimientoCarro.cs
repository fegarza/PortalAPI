using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fferr_conocimiento_carro")]
    [Index(nameof(Rowguid), Name = "index_1519344477", IsUnique = true)]
    public partial class FferrConocimientoCarro
    {
        [Key]
        [Column("id_trafico_master")]
        [StringLength(10)]
        public string IdTraficoMaster { get; set; }
        [Key]
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Key]
        [Column("carro")]
        [StringLength(20)]
        public string Carro { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
