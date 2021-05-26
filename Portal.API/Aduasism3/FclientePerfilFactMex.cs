using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcliente_perfil_fact_mex")]
    public partial class FclientePerfilFactMex
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("incluir_cta_ame")]
        [StringLength(1)]
        public string IncluirCtaAme { get; set; }
        [Column("localidad")]
        [StringLength(250)]
        public string Localidad { get; set; }
        [Column("referencia")]
        [StringLength(250)]
        public string Referencia { get; set; }
        [Column("atencion")]
        [StringLength(50)]
        public string Atencion { get; set; }
        [Column("mensajeria")]
        [StringLength(50)]
        public string Mensajeria { get; set; }
        [Column("id_destino")]
        [StringLength(3)]
        public string IdDestino { get; set; }
        [Column("id_tipo_org")]
        [StringLength(2)]
        public string IdTipoOrg { get; set; }
        [Column("id_organizacion")]
        [StringLength(8)]
        public string IdOrganizacion { get; set; }
        [Column("tipo_contable")]
        [StringLength(1)]
        public string TipoContable { get; set; }
        [Column("c_UsoCFDI")]
        [StringLength(5)]
        public string CUsoCfdi { get; set; }
        [Column("c_Pais")]
        [StringLength(3)]
        public string CPais { get; set; }
        [Column("porcentaje_adicional", TypeName = "decimal(7, 4)")]
        public decimal? PorcentajeAdicional { get; set; }
        [Column("cuenta_predial")]
        [StringLength(20)]
        public string CuentaPredial { get; set; }
        [Column("ruta_archivo_pdf")]
        [StringLength(255)]
        public string RutaArchivoPdf { get; set; }
    }
}
