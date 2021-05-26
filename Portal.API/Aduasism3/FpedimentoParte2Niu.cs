using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_parte2_niu")]
    [Index(nameof(Rowguid), Name = "index_1334893910", IsUnique = true)]
    public partial class FpedimentoParte2Niu
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(18, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Key]
        [Column("numero_vehiculo")]
        [StringLength(20)]
        public string NumeroVehiculo { get; set; }
        [Key]
        [Column("consecutivo", TypeName = "numeric(18, 0)")]
        public decimal Consecutivo { get; set; }
        [Key]
        [Column("num_ident_uni")]
        [StringLength(20)]
        public string NumIdentUni { get; set; }
        [Column("secuencial", TypeName = "numeric(18, 0)")]
        public decimal? Secuencial { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
