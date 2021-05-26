using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftipo_usuario")]
    [Index(nameof(Rowguid), Name = "index_866102126", IsUnique = true)]
    public partial class FtipoUsuario
    {
        public FtipoUsuario()
        {
            Fusuarios = new HashSet<Fusuario>();
        }

        [Key]
        [Column("id_clase")]
        [StringLength(10)]
        public string IdClase { get; set; }
        [Column("descripcion")]
        [StringLength(30)]
        public string Descripcion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [InverseProperty(nameof(Fusuario.IdClaseNavigation))]
        public virtual ICollection<Fusuario> Fusuarios { get; set; }
    }
}
