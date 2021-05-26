using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpermiso_vigente")]
    public partial class FpermisoVigente
    {
        [Key]
        [Column("id_permiso")]
        [StringLength(2)]
        public string IdPermiso { get; set; }
        [Key]
        [Column("identificador")]
        [StringLength(3)]
        public string Identificador { get; set; }
        [Column("id_comp")]
        [StringLength(3)]
        public string IdComp { get; set; }
    }
}
