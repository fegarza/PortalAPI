using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdoda_qr_detalle")]
    public partial class FdodaQrDetalle
    {
        [Key]
        [Column("num_control")]
        [StringLength(10)]
        public string NumControl { get; set; }
        [Required]
        [Column("tipo_movimiento")]
        [StringLength(1)]
        public string TipoMovimiento { get; set; }
        [Key]
        [Column("secuencial", TypeName = "numeric(9, 0)")]
        public decimal Secuencial { get; set; }
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("documento")]
        [StringLength(7)]
        public string Documento { get; set; }
        [Column("remesa", TypeName = "numeric(5, 0)")]
        public decimal? Remesa { get; set; }
        [Column("cove")]
        [StringLength(13)]
        public string Cove { get; set; }
        [Column("cantidad_umc", TypeName = "decimal(15, 3)")]
        public decimal? CantidadUmc { get; set; }
        [Column("importe_efectivo", TypeName = "numeric(14, 2)")]
        public decimal? ImporteEfectivo { get; set; }
        [Column("importe_diferencia", TypeName = "numeric(14, 2)")]
        public decimal? ImporteDiferencia { get; set; }
        [Column("DTAniu")]
        [StringLength(15)]
        public string Dtaniu { get; set; }
        [Column("articulo7")]
        [StringLength(10)]
        public string Articulo7 { get; set; }
        [Column("acuse_validador")]
        [StringLength(8)]
        public string AcuseValidador { get; set; }
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal? IdRectificacion { get; set; }
        [Column("codigo")]
        [StringLength(1)]
        public string Codigo { get; set; }
    }
}
