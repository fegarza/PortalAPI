using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_bulto")]
    [Index(nameof(Rowguid), Name = "index_1893581784", IsUnique = true)]
    public partial class FpedimentoBulto
    {
        public FpedimentoBulto()
        {
            FpedimentoBultoDetalles = new HashSet<FpedimentoBultoDetalle>();
        }

        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
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
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [InverseProperty(nameof(FpedimentoBultoDetalle.IdRe))]
        public virtual ICollection<FpedimentoBultoDetalle> FpedimentoBultoDetalles { get; set; }
    }
}
