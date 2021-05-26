using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_almacen_generales")]
    public partial class OcAlmacenGenerale
    {
        [Key]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Column("consecutivo_bulto")]
        public bool ConsecutivoBulto { get; set; }
        [Column("escaneo_movimiento")]
        public bool EscaneoMovimiento { get; set; }
        [Column("movimiento_sencillo")]
        public bool MovimientoSencillo { get; set; }
        [Column("validar_puerta")]
        public bool ValidarPuerta { get; set; }
        [Column("salida_por_puerta")]
        public bool SalidaPorPuerta { get; set; }
        [Column("generar_movimiento")]
        public bool GenerarMovimiento { get; set; }
        [Column("bloquear_movimiento")]
        public bool BloquearMovimiento { get; set; }
        [Column("password_desbloqueo")]
        [StringLength(250)]
        public string PasswordDesbloqueo { get; set; }
        [Required]
        [Column("localizacion_carga")]
        [StringLength(15)]
        public string LocalizacionCarga { get; set; }
        [Column("motivo_reacomodo")]
        public short MotivoReacomodo { get; set; }
        [Column("usuario_ingreso")]
        [StringLength(6)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column("usuario_modifica")]
        [StringLength(6)]
        public string UsuarioModifica { get; set; }
        [Column("fecha_modifica", TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
        [Column("validar_existencia_bulto")]
        public bool ValidarExistenciaBulto { get; set; }
        [Column("validar_existencia_vehiculo")]
        public bool ValidarExistenciaVehiculo { get; set; }
        [Column("clase_material_paq")]
        public short? ClaseMaterialPaq { get; set; }
        [Column("localizacion_paq")]
        [StringLength(15)]
        public string LocalizacionPaq { get; set; }
        [Column("tipo_bulto_paq")]
        [StringLength(5)]
        public string TipoBultoPaq { get; set; }
        [Column("tipo_vehiculo_paq")]
        [StringLength(2)]
        public string TipoVehiculoPaq { get; set; }
        [Column("clase_carga_paq")]
        public short? ClaseCargaPaq { get; set; }
        [Column("surtido")]
        public bool Surtido { get; set; }
        [Column("prefijo_agrupacion")]
        [StringLength(3)]
        public string PrefijoAgrupacion { get; set; }
        [Column("previo_recibo")]
        public bool? PrevioRecibo { get; set; }
        [Column("agrupar_packing")]
        public bool? AgruparPacking { get; set; }
        [Column("validar_exw")]
        public bool? ValidarExw { get; set; }
        [Column("validar_peso_embarque")]
        public bool? ValidarPesoEmbarque { get; set; }
        [Column("peso_embarque", TypeName = "decimal(14, 3)")]
        public decimal? PesoEmbarque { get; set; }
        [Column("tipo_embarque_arribo")]
        public bool TipoEmbarqueArribo { get; set; }
        [Column("repetir_numero_factura")]
        public bool? RepetirNumeroFactura { get; set; }
        [Column("EEI_opcional")]
        public bool EeiOpcional { get; set; }
        [Required]
        [Column("embarque_opcional")]
        public bool? EmbarqueOpcional { get; set; }
        [Column("embarque_generico")]
        public bool EmbarqueGenerico { get; set; }
    }
}
