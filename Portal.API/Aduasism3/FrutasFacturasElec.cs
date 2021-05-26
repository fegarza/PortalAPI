using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frutas_facturas_elec")]
    public partial class FrutasFacturasElec
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("ruta")]
        [StringLength(250)]
        public string Ruta { get; set; }
        [Key]
        [Column("fac_ped")]
        [StringLength(1)]
        public string FacPed { get; set; }
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Column("tipo_layout")]
        [StringLength(3)]
        public string TipoLayout { get; set; }
    }
}
