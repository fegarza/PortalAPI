using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fprefijos")]
    public partial class Fprefijo
    {
        public Fprefijo()
        {
            FoliadorClientes = new HashSet<FoliadorCliente>();
        }

        [Key]
        [Column("id_prefijo")]
        public int IdPrefijo { get; set; }
        [Required]
        [Column("prefijo")]
        [StringLength(6)]
        public string Prefijo { get; set; }
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }

        [InverseProperty(nameof(FoliadorCliente.PrefijoNavigation))]
        public virtual ICollection<FoliadorCliente> FoliadorClientes { get; set; }
    }
}
