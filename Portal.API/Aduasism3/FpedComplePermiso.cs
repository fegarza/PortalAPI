using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fped_comple_permiso")]
    [Index(nameof(Rowguid), Name = "index_841822111", IsUnique = true)]
    public partial class FpedComplePermiso
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("numero_secuencial", TypeName = "numeric(5, 0)")]
        public decimal NumeroSecuencial { get; set; }
        [Key]
        [Column("id_permiso")]
        [StringLength(3)]
        public string IdPermiso { get; set; }
        [Key]
        [Column("numero_permiso")]
        [StringLength(25)]
        public string NumeroPermiso { get; set; }
        [Key]
        [Column("firma_permiso")]
        [StringLength(17)]
        public string FirmaPermiso { get; set; }
        [Column("valor_comercial_dlls", TypeName = "numeric(14, 2)")]
        public decimal? ValorComercialDlls { get; set; }
        [Column("cantidad_tarifa", TypeName = "numeric(15, 3)")]
        public decimal? CantidadTarifa { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
