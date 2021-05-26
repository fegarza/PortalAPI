using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftipo_advalorem_complemento")]
    public partial class FtipoAdvaloremComplemento
    {
        [Key]
        [Column("id_tipo_advalorem")]
        [StringLength(3)]
        public string IdTipoAdvalorem { get; set; }
        [Column("complemento")]
        [StringLength(20)]
        public string Complemento { get; set; }
    }
}
