using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftransfer_pagado")]
    public partial class FtransferPagado
    {
        [Key]
        [Column("id_transfer_pagado")]
        [StringLength(7)]
        public string IdTransferPagado { get; set; }
        [Column("descripcion")]
        [StringLength(100)]
        public string Descripcion { get; set; }
    }
}
