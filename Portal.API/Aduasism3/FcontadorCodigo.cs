using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fcontador_codigo")]
    public partial class FcontadorCodigo
    {
        [Column("contador")]
        public int? Contador { get; set; }
    }
}
