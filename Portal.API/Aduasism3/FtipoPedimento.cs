using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("FTIPO_PEDIMENTO")]
    [Index(nameof(Rowguid), Name = "index_149575571", IsUnique = true)]
    public partial class FtipoPedimento
    {
        public FtipoPedimento()
        {
            FrelTipoPedimentoRegimen = new HashSet<FrelTipoPedimentoRegiman>();
        }

        [Key]
        [Column("ID_TIPO_PEDIMENTO")]
        [StringLength(2)]
        public string IdTipoPedimento { get; set; }
        [Required]
        [Column("DESCRIPCION")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [InverseProperty(nameof(FrelTipoPedimentoRegiman.IdTipoPedimentoNavigation))]
        public virtual ICollection<FrelTipoPedimentoRegiman> FrelTipoPedimentoRegimen { get; set; }
    }
}
