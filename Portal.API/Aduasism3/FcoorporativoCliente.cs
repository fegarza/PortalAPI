using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcoorporativo_cliente")]
    [Index(nameof(Rowguid), Name = "index_1314103722", IsUnique = true)]
    public partial class FcoorporativoCliente
    {
        [Key]
        [Column("id_coorporativo")]
        [StringLength(4)]
        public string IdCoorporativo { get; set; }
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [ForeignKey(nameof(IdCoorporativo))]
        [InverseProperty(nameof(Fcoorporativo.FcoorporativoClientes))]
        public virtual Fcoorporativo IdCoorporativoNavigation { get; set; }
    }
}
