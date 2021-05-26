using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcliente_perfil")]
    public partial class FclientePerfil
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("cve_tipo_op")]
        [StringLength(1)]
        public string CveTipoOp { get; set; }
        [Column("manifestacion_valor")]
        [StringLength(1)]
        public string ManifestacionValor { get; set; }
        [Column("carta_encomenda")]
        [StringLength(1)]
        public string CartaEncomenda { get; set; }
        [Column("certificado_origen")]
        [StringLength(1)]
        public string CertificadoOrigen { get; set; }
        [Column("fecha_venc_mval", TypeName = "datetime")]
        public DateTime? FechaVencMval { get; set; }
        [Column("fecha_venc_cenc", TypeName = "datetime")]
        public DateTime? FechaVencCenc { get; set; }
        [Column("fecha_venc_cori", TypeName = "datetime")]
        public DateTime? FechaVencCori { get; set; }
        [Column("dias_ant_mval", TypeName = "numeric(3, 0)")]
        public decimal? DiasAntMval { get; set; }
        [Column("dias_ant_cenc", TypeName = "numeric(3, 0)")]
        public decimal? DiasAntCenc { get; set; }
        [Column("dias_ant_cori", TypeName = "numeric(3, 0)")]
        public decimal? DiasAntCori { get; set; }
        [Column("pago_electronico")]
        [StringLength(1)]
        public string PagoElectronico { get; set; }
        [Column("tipo_factura")]
        [StringLength(4)]
        public string TipoFactura { get; set; }
        [Column("cve_destino")]
        [StringLength(1)]
        public string CveDestino { get; set; }
        [Column("cve_trans_ent")]
        [StringLength(2)]
        public string CveTransEnt { get; set; }
        [Column("cve_trans_arribo")]
        [StringLength(2)]
        public string CveTransArribo { get; set; }
        [Column("cve_trans_salida")]
        [StringLength(2)]
        public string CveTransSalida { get; set; }
        [Column("prod_obligatorio")]
        [StringLength(1)]
        public string ProdObligatorio { get; set; }
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Column("descripcion_clas")]
        [StringLength(250)]
        public string DescripcionClas { get; set; }
        [Column("razon_social_prov")]
        [StringLength(200)]
        public string RazonSocialProv { get; set; }
        [Column("pasar_contenedor")]
        [StringLength(1)]
        public string PasarContenedor { get; set; }
        [Column("filtro_fc")]
        [StringLength(1)]
        public string FiltroFc { get; set; }
        [Column("id_destino")]
        [StringLength(3)]
        public string IdDestino { get; set; }
        [Column("calcular_factor")]
        [StringLength(1)]
        public string CalcularFactor { get; set; }
        [Column("factor", TypeName = "decimal(8, 2)")]
        public decimal? Factor { get; set; }
        [Column("cove_observaciones_pedimento")]
        [StringLength(1)]
        public string CoveObservacionesPedimento { get; set; }
        [Column("pasar_observaciones")]
        [StringLength(1)]
        public string PasarObservaciones { get; set; }
        [Column("dualidad_productos")]
        [StringLength(1)]
        public string DualidadProductos { get; set; }
        [Column("codigo_barras_ped_completo")]
        [StringLength(1)]
        public string CodigoBarrasPedCompleto { get; set; }
        [Column("anexo_facturas_ped_completo")]
        [StringLength(1)]
        public string AnexoFacturasPedCompleto { get; set; }
    }
}
