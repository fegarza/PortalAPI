using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcontrol_embarque")]
    public partial class FcontrolEmbarque
    {
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Column("id_embarque")]
        [StringLength(10)]
        public string IdEmbarque { get; set; }
        [Required]
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Required]
        [Column("num_vehiculo")]
        [StringLength(20)]
        public string NumVehiculo { get; set; }
        [Column("vehiculos")]
        [StringLength(100)]
        public string Vehiculos { get; set; }
        [Required]
        [Column("id_linea_fletera_mex")]
        [StringLength(4)]
        public string IdLineaFleteraMex { get; set; }
        [Required]
        [Column("id_linea_fletera_ame")]
        [StringLength(4)]
        public string IdLineaFleteraAme { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Column("id_ag_ad_ame")]
        [StringLength(6)]
        public string IdAgAdAme { get; set; }
        [Required]
        [Column("id_agencia_aduanal")]
        [StringLength(4)]
        public string IdAgenciaAduanal { get; set; }
        [Column("pre_file")]
        [StringLength(20)]
        public string PreFile { get; set; }
        [Column("fecha_entrada", TypeName = "datetime")]
        public DateTime FechaEntrada { get; set; }
        [Column("id_transfer")]
        [StringLength(4)]
        public string IdTransfer { get; set; }
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Column("id_orden_compra")]
        [StringLength(15)]
        public string IdOrdenCompra { get; set; }
        [Column("orden_compra")]
        [StringLength(150)]
        public string OrdenCompra { get; set; }
        [Column("entry")]
        [StringLength(20)]
        public string Entry { get; set; }
        [Column("fecha_cita_orig", TypeName = "datetime")]
        public DateTime? FechaCitaOrig { get; set; }
        [Column("fecha_sal_planta", TypeName = "datetime")]
        public DateTime? FechaSalPlanta { get; set; }
        [Column("fecha_lleg_fronte", TypeName = "datetime")]
        public DateTime? FechaLlegFronte { get; set; }
        [Column("fecha_reci_prefile", TypeName = "datetime")]
        public DateTime? FechaReciPrefile { get; set; }
        [Column("fecha_gancha_caja", TypeName = "datetime")]
        public DateTime? FechaGanchaCaja { get; set; }
        [Column("fecha_reci_docu", TypeName = "datetime")]
        public DateTime? FechaReciDocu { get; set; }
        [Column("fecha_lleg_pat_ta", TypeName = "datetime")]
        public DateTime? FechaLlegPatTa { get; set; }
        [Column("fecha_entre_prov", TypeName = "datetime")]
        public DateTime? FechaEntreProv { get; set; }
        [Column("fecha_ped_pag", TypeName = "datetime")]
        public DateTime? FechaPedPag { get; set; }
        [Column("fecha_cruce", TypeName = "datetime")]
        public DateTime? FechaCruce { get; set; }
        [Column("fecha_envia_prefile", TypeName = "datetime")]
        public DateTime? FechaEnviaPrefile { get; set; }
        [Column("fecha_salida_destino", TypeName = "datetime")]
        public DateTime? FechaSalidaDestino { get; set; }
        [Column("observaciones", TypeName = "text")]
        public string Observaciones { get; set; }
        [Column("fecha_reg", TypeName = "datetime")]
        public DateTime FechaReg { get; set; }
        [Required]
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Column("fecha_ult_modif", TypeName = "datetime")]
        public DateTime FechaUltModif { get; set; }
        [Required]
        [Column("id_usuario_ult_modif")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
        [Column("cliente_sello")]
        [StringLength(20)]
        public string ClienteSello { get; set; }
        [Column("cliente_observ")]
        [StringLength(250)]
        public string ClienteObserv { get; set; }
        [Column("linea_mex_sello")]
        [StringLength(20)]
        public string LineaMexSello { get; set; }
        [Column("linea_mex_observ")]
        [StringLength(250)]
        public string LineaMexObserv { get; set; }
        [Column("agencia_ad_sello")]
        [StringLength(20)]
        public string AgenciaAdSello { get; set; }
        [Column("agencia_ad_observ")]
        [StringLength(250)]
        public string AgenciaAdObserv { get; set; }
        [Column("transfer_sello")]
        [StringLength(20)]
        public string TransferSello { get; set; }
        [Column("transfer_observ")]
        [StringLength(250)]
        public string TransferObserv { get; set; }
        [Column("ag_ad_ame_sello")]
        [StringLength(20)]
        public string AgAdAmeSello { get; set; }
        [Column("ag_ad_ame_observ")]
        [StringLength(250)]
        public string AgAdAmeObserv { get; set; }
        [Column("linea_ame_sello")]
        [StringLength(20)]
        public string LineaAmeSello { get; set; }
        [Column("linea_ame_observ")]
        [StringLength(250)]
        public string LineaAmeObserv { get; set; }
        [Column("proveedor_sello")]
        [StringLength(20)]
        public string ProveedorSello { get; set; }
        [Column("proveedor_oberv")]
        [StringLength(250)]
        public string ProveedorOberv { get; set; }
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
    }
}
