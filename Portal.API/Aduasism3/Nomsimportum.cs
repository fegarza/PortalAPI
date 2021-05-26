using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("NOMSIMPORTA")]
    public partial class Nomsimportum
    {
        [Column("FRACCION")]
        [StringLength(50)]
        public string Fraccion { get; set; }
        [Column("NOMENCLATURA", TypeName = "ntext")]
        public string Nomenclatura { get; set; }
        [Column("NOM", TypeName = "ntext")]
        public string Nom { get; set; }
        [Column("DOF")]
        [StringLength(50)]
        public string Dof { get; set; }
        [Column("SIMBOLO")]
        [StringLength(50)]
        public string Simbolo { get; set; }
    }
}
