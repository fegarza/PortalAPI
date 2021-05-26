using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcoorporativo")]
    [Index(nameof(Rowguid), Name = "index_629577281", IsUnique = true)]
    public partial class Fcoorporativo
    {
        public Fcoorporativo()
        {
            FcoorporativoClientes = new HashSet<FcoorporativoCliente>();
        }

        [Key]
        [Column("id_coorporativo")]
        [StringLength(4)]
        public string IdCoorporativo { get; set; }
        [Required]
        [Column("nombre")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Required]
        [Column("abreviado")]
        [StringLength(15)]
        public string Abreviado { get; set; }
        [Required]
        [Column("representante")]
        [StringLength(50)]
        public string Representante { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [InverseProperty(nameof(FcoorporativoCliente.IdCoorporativoNavigation))]
        public virtual ICollection<FcoorporativoCliente> FcoorporativoClientes { get; set; }
    }
}
