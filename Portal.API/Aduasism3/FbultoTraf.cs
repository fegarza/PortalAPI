using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fbulto_traf")]
    [Index(nameof(Rowguid), Name = "index_555149023", IsUnique = true)]
    public partial class FbultoTraf
    {
        public FbultoTraf()
        {
            FbultoTrafDeta = new HashSet<FbultoTrafDetum>();
        }

        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Column("fecha_reg", TypeName = "datetime")]
        public DateTime FechaReg { get; set; }
        [Required]
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ultmodif", TypeName = "datetime")]
        public DateTime FechaUltmodif { get; set; }
        [Required]
        [Column("id_usuario_ultmodif")]
        [StringLength(6)]
        public string IdUsuarioUltmodif { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [ForeignKey(nameof(IdTrafico))]
        [InverseProperty(nameof(Fgtrafico.FbultoTraf))]
        public virtual Fgtrafico IdTraficoNavigation { get; set; }
        [ForeignKey(nameof(IdUsuarioRegistro))]
        [InverseProperty(nameof(Fusuario.FbultoTrafs))]
        public virtual Fusuario IdUsuarioRegistroNavigation { get; set; }
        [InverseProperty(nameof(FbultoTrafDetum.IdTraficoNavigation))]
        public virtual ICollection<FbultoTrafDetum> FbultoTrafDeta { get; set; }
    }
}
