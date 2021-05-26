using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fconsec_lec_auto")]
    public partial class FconsecLecAuto
    {
        [Key]
        [Column("id_referencia", TypeName = "numeric(18, 0)")]
        public decimal IdReferencia { get; set; }
    }
}
