using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcontrol_basculas")]
    public partial class FcontrolBascula
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_Rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("secuencial", TypeName = "numeric(4, 0)")]
        public decimal Secuencial { get; set; }
        [Column("consecutivo", TypeName = "numeric(4, 0)")]
        public decimal? Consecutivo { get; set; }
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Column("clave_recinto")]
        [StringLength(3)]
        public string ClaveRecinto { get; set; }
        [Column("numero_contenedor")]
        [StringLength(20)]
        public string NumeroContenedor { get; set; }
        [StringLength(1)]
        public string Granel { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? Peso { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Cantidad { get; set; }
        [Column("total_guias", TypeName = "numeric(18, 0)")]
        public decimal? TotalGuias { get; set; }
        [Column("num_identifica")]
        [StringLength(50)]
        public string NumIdentifica { get; set; }
    }
}
