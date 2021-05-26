using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftipo_factura")]
    [Index(nameof(Rowguid), Name = "index_674101442", IsUnique = true)]
    public partial class FtipoFactura
    {
        public FtipoFactura()
        {
            Fgfacturas = new HashSet<Fgfactura>();
        }

        [Key]
        [Column("id_tipo_factura")]
        [StringLength(4)]
        public string IdTipoFactura { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(30)]
        public string Descripcion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("inactivo")]
        [StringLength(100)]
        public string Inactivo { get; set; }

        [InverseProperty(nameof(Fgfactura.IdTipoFacturaNavigation))]
        public virtual ICollection<Fgfactura> Fgfacturas { get; set; }
    }
}
