﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fconsecutivo_embarque")]
    public partial class FconsecutivoEmbarque
    {
        [Column("consecutivo_embarque", TypeName = "numeric(7, 0)")]
        public decimal ConsecutivoEmbarque { get; set; }
    }
}