using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdestinos")]
    [Index(nameof(Rowguid), Name = "index_1181963287", IsUnique = true)]
    public partial class Fdestino
    {
        [Key]
        [Column("id_destino")]
        [StringLength(4)]
        public string IdDestino { get; set; }
        [Key]
        [Column("id_tipo_org")]
        [StringLength(2)]
        public string IdTipoOrg { get; set; }
        [Key]
        [Column("id_organizacion")]
        [StringLength(8)]
        public string IdOrganizacion { get; set; }
        [Column("calle")]
        [StringLength(120)]
        public string Calle { get; set; }
        [Column("numero")]
        [StringLength(30)]
        public string Numero { get; set; }
        [Column("colonia")]
        [StringLength(80)]
        public string Colonia { get; set; }
        [Column("cod_post")]
        [StringLength(10)]
        public string CodPost { get; set; }
        [Required]
        [Column("id_municipio")]
        [StringLength(4)]
        public string IdMunicipio { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("telefono1")]
        [StringLength(15)]
        public string Telefono1 { get; set; }
        [Column("id_referencia")]
        [StringLength(20)]
        public string IdReferencia { get; set; }
    }
}
