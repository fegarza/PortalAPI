using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("g_adu_edi")]
    public partial class GAduEdi
    {
        [Column("fraccion_total")]
        [StringLength(8000)]
        public string FraccionTotal { get; set; }
    }
}
