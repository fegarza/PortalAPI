using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fferr_conocimiento")]
    [Index(nameof(Rowguid), Name = "index_1503344420", IsUnique = true)]
    public partial class FferrConocimiento
    {
        [Key]
        [Column("id_trafico_master")]
        [StringLength(10)]
        public string IdTraficoMaster { get; set; }
        [Key]
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("id_escape")]
        public int IdEscape { get; set; }
        [Column("fecha_conocimiento", TypeName = "datetime")]
        public DateTime? FechaConocimiento { get; set; }
        [Column("cve_tipo_servicio")]
        [StringLength(1)]
        public string CveTipoServicio { get; set; }
        [Column("cve_condiciones_pago")]
        [StringLength(1)]
        public string CveCondicionesPago { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
