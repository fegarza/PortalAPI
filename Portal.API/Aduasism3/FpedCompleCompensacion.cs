using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fped_comple_compensacion")]
    [Index(nameof(Rowguid), Name = "index_1145823194", IsUnique = true)]
    public partial class FpedCompleCompensacion
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("secuencial", TypeName = "decimal(1, 0)")]
        public decimal Secuencial { get; set; }
        [Required]
        [Column("patente_ori")]
        [StringLength(4)]
        public string PatenteOri { get; set; }
        [Required]
        [Column("pedimento_ori")]
        [StringLength(7)]
        public string PedimentoOri { get; set; }
        [Required]
        [Column("aduana_ori")]
        [StringLength(2)]
        public string AduanaOri { get; set; }
        [Required]
        [Column("seccion_ori")]
        [StringLength(1)]
        public string SeccionOri { get; set; }
        [Column("fecha_pago_ori", TypeName = "datetime")]
        public DateTime? FechaPagoOri { get; set; }
        [Column("clave_ori")]
        [StringLength(3)]
        public string ClaveOri { get; set; }
        [Column("importe", TypeName = "decimal(12, 0)")]
        public decimal? Importe { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
