using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_shipper_trafico")]
    [Index(nameof(Rowguid), Name = "index_226099846", IsUnique = true)]
    public partial class FrelShipperTrafico
    {
        [Key]
        [Column("id_shipper")]
        [StringLength(8)]
        public string IdShipper { get; set; }
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
