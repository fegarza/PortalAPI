using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fusuario")]
    [Index(nameof(Rowguid), Name = "index_1901965852", IsUnique = true)]
    public partial class Fusuario
    {
        public Fusuario()
        {
            FagAdAmes = new HashSet<FagAdAme>();
            FagenciaAduanals = new HashSet<FagenciaAduanal>();
            Fapoderados = new HashSet<Fapoderado>();
            FbodegaIdUsuarioRegistroNavigations = new HashSet<Fbodega>();
            FbodegaIdUsuarioResponsableNavigations = new HashSet<Fbodega>();
            FbultoTrafs = new HashSet<FbultoTraf>();
            FconsignatarioIdUsuarioRegistroNavigations = new HashSet<Fconsignatario>();
            FconsignatarioIdUsuarioUltmodifNavigations = new HashSet<Fconsignatario>();
            Fcorresponsals = new HashSet<Fcorresponsal>();
            Fgtraficos = new HashSet<Fgtrafico>();
            FlineaFleteras = new HashSet<FlineaFletera>();
            FproveedorInternoIdUsuarioRegistroNavigations = new HashSet<FproveedorInterno>();
            FproveedorInternoIdUsuarioUltmodifNavigations = new HashSet<FproveedorInterno>();
            Fproveedors = new HashSet<Fproveedor>();
            FrelProdFracIdUsuarioClasificaNavigations = new HashSet<FrelProdFrac>();
            FrelProdFracIdUsuarioUltmodifNavigations = new HashSet<FrelProdFrac>();
            FrelUsuactDetalles = new HashSet<FrelUsuactDetalle>();
        }

        [Key]
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Required]
        [Column("nombre")]
        [StringLength(30)]
        public string Nombre { get; set; }
        [Required]
        [Column("ap_paterno")]
        [StringLength(25)]
        public string ApPaterno { get; set; }
        [Column("ap_materno")]
        [StringLength(25)]
        public string ApMaterno { get; set; }
        [Column("rfc")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Column("titulo")]
        [StringLength(4)]
        public string Titulo { get; set; }
        [Column("estado_civil")]
        [StringLength(1)]
        public string EstadoCivil { get; set; }
        [Column("sexo")]
        [StringLength(1)]
        public string Sexo { get; set; }
        [Column("cve_telefono")]
        [StringLength(5)]
        public string CveTelefono { get; set; }
        [Column("fax")]
        [StringLength(7)]
        public string Fax { get; set; }
        [Column("correo_electronico")]
        [StringLength(150)]
        public string CorreoElectronico { get; set; }
        [Column("telefono1")]
        [StringLength(7)]
        public string Telefono1 { get; set; }
        [Column("telefono2")]
        [StringLength(7)]
        public string Telefono2 { get; set; }
        [Column("telefono3")]
        [StringLength(7)]
        public string Telefono3 { get; set; }
        [Column("telefono4")]
        [StringLength(7)]
        public string Telefono4 { get; set; }
        [Required]
        [Column("calle")]
        [StringLength(30)]
        public string Calle { get; set; }
        [Required]
        [Column("numero")]
        [StringLength(8)]
        public string Numero { get; set; }
        [Required]
        [Column("colonia")]
        [StringLength(30)]
        public string Colonia { get; set; }
        [Column("codigo_postal")]
        [StringLength(8)]
        public string CodigoPostal { get; set; }
        [Required]
        [Column("id_municipio")]
        [StringLength(4)]
        public string IdMunicipio { get; set; }
        [Required]
        [Column("id_clase")]
        [StringLength(10)]
        public string IdClase { get; set; }
        [Column("fecha_expiracion", TypeName = "datetime")]
        public DateTime? FechaExpiracion { get; set; }
        [Column("id_org")]
        [StringLength(6)]
        public string IdOrg { get; set; }
        [Column("cve_tipo_organizacion")]
        [StringLength(2)]
        public string CveTipoOrganizacion { get; set; }
        [Column("password")]
        [StringLength(10)]
        public string Password { get; set; }
        [Column("num_dependientes", TypeName = "numeric(2, 0)")]
        public decimal? NumDependientes { get; set; }
        [Column("hrs_stdr_x_sem", TypeName = "numeric(5, 2)")]
        public decimal? HrsStdrXSem { get; set; }
        [Column("tarifa_x_hr", TypeName = "numeric(6, 2)")]
        public decimal? TarifaXHr { get; set; }
        [Column("porc_x_hr_extra", TypeName = "numeric(3, 0)")]
        public decimal? PorcXHrExtra { get; set; }
        [Column("password_val")]
        [StringLength(10)]
        public string PasswordVal { get; set; }
        [Column("curp")]
        [StringLength(18)]
        public string Curp { get; set; }
        [Column("num_serie")]
        [StringLength(30)]
        public string NumSerie { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("modulo")]
        public int? Modulo { get; set; }
        [Column("supervisor", TypeName = "numeric(18, 0)")]
        public decimal? Supervisor { get; set; }
        [Column("password_match")]
        [StringLength(10)]
        public string PasswordMatch { get; set; }
        [Column("id_bodega")]
        [StringLength(8)]
        public string IdBodega { get; set; }
        [Column("usuario")]
        [StringLength(40)]
        public string Usuario { get; set; }
        [Column("numempresa")]
        public int? Numempresa { get; set; }
        [Column("master")]
        [StringLength(1)]
        public string Master { get; set; }
        [Column("pwd_monto")]
        [StringLength(10)]
        public string PwdMonto { get; set; }
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("ruta_cove")]
        [StringLength(50)]
        public string RutaCove { get; set; }
        [Column("password_interface")]
        [StringLength(10)]
        public string PasswordInterface { get; set; }
        [Column("tipo_conexion_cove")]
        [StringLength(1)]
        public string TipoConexionCove { get; set; }
        [Column("password_proval")]
        [StringLength(10)]
        public string PasswordProval { get; set; }
        [Column("status")]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("password_r1")]
        [StringLength(10)]
        public string PasswordR1 { get; set; }
        [Column("monto_iva_efectivo", TypeName = "numeric(12, 0)")]
        public decimal? MontoIvaEfectivo { get; set; }
        [Column("password_anexo10")]
        [StringLength(10)]
        public string PasswordAnexo10 { get; set; }
        [Column("password_factura")]
        [StringLength(10)]
        public string PasswordFactura { get; set; }
        [Column("psw_archivo_bancos")]
        [StringLength(10)]
        public string PswArchivoBancos { get; set; }
        [Column("acceso_light")]
        [StringLength(1)]
        public string AccesoLight { get; set; }
        [Column("contrasena_referencia_vulnerable")]
        [StringLength(30)]
        public string ContrasenaReferenciaVulnerable { get; set; }
        [Column("contrasena_trafico_vulnerable")]
        [StringLength(30)]
        public string ContrasenaTraficoVulnerable { get; set; }
        [Column("contrasena_pago_vulnerable")]
        [StringLength(10)]
        public string ContrasenaPagoVulnerable { get; set; }
        [Column("pass_rect_sin_cove")]
        [StringLength(30)]
        public string PassRectSinCove { get; set; }
        [Column("password_pedimento_desistido")]
        [StringLength(10)]
        public string PasswordPedimentoDesistido { get; set; }
        [Column("monto_igi", TypeName = "numeric(12, 0)")]
        public decimal? MontoIgi { get; set; }
        [Column("monto_ieps", TypeName = "numeric(12, 0)")]
        public decimal? MontoIeps { get; set; }
        [Column("pass_desbloquear_cove")]
        [StringLength(30)]
        public string PassDesbloquearCove { get; set; }
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("password_cuenta_general")]
        [StringLength(10)]
        public string PasswordCuentaGeneral { get; set; }

        [ForeignKey(nameof(IdClase))]
        [InverseProperty(nameof(FtipoUsuario.Fusuarios))]
        public virtual FtipoUsuario IdClaseNavigation { get; set; }
        [ForeignKey(nameof(IdMunicipio))]
        [InverseProperty(nameof(Fmunicipio.Fusuarios))]
        public virtual Fmunicipio IdMunicipioNavigation { get; set; }
        [InverseProperty(nameof(FagAdAme.IdUsuarioRegistroNavigation))]
        public virtual ICollection<FagAdAme> FagAdAmes { get; set; }
        [InverseProperty(nameof(FagenciaAduanal.IdUsuarioRegistroNavigation))]
        public virtual ICollection<FagenciaAduanal> FagenciaAduanals { get; set; }
        [InverseProperty(nameof(Fapoderado.IdUsuarioRegistroNavigation))]
        public virtual ICollection<Fapoderado> Fapoderados { get; set; }
        [InverseProperty(nameof(Fbodega.IdUsuarioRegistroNavigation))]
        public virtual ICollection<Fbodega> FbodegaIdUsuarioRegistroNavigations { get; set; }
        [InverseProperty(nameof(Fbodega.IdUsuarioResponsableNavigation))]
        public virtual ICollection<Fbodega> FbodegaIdUsuarioResponsableNavigations { get; set; }
        [InverseProperty(nameof(FbultoTraf.IdUsuarioRegistroNavigation))]
        public virtual ICollection<FbultoTraf> FbultoTrafs { get; set; }
        [InverseProperty(nameof(Fconsignatario.IdUsuarioRegistroNavigation))]
        public virtual ICollection<Fconsignatario> FconsignatarioIdUsuarioRegistroNavigations { get; set; }
        [InverseProperty(nameof(Fconsignatario.IdUsuarioUltmodifNavigation))]
        public virtual ICollection<Fconsignatario> FconsignatarioIdUsuarioUltmodifNavigations { get; set; }
        [InverseProperty(nameof(Fcorresponsal.IdUsuarioRegistroNavigation))]
        public virtual ICollection<Fcorresponsal> Fcorresponsals { get; set; }
        [InverseProperty(nameof(Fgtrafico.IdUsuarioNavigation))]
        public virtual ICollection<Fgtrafico> Fgtraficos { get; set; }
        [InverseProperty(nameof(FlineaFletera.IdUsuarioRegistroNavigation))]
        public virtual ICollection<FlineaFletera> FlineaFleteras { get; set; }
        [InverseProperty(nameof(FproveedorInterno.IdUsuarioRegistroNavigation))]
        public virtual ICollection<FproveedorInterno> FproveedorInternoIdUsuarioRegistroNavigations { get; set; }
        [InverseProperty(nameof(FproveedorInterno.IdUsuarioUltmodifNavigation))]
        public virtual ICollection<FproveedorInterno> FproveedorInternoIdUsuarioUltmodifNavigations { get; set; }
        [InverseProperty(nameof(Fproveedor.IdUsuarioRegistroNavigation))]
        public virtual ICollection<Fproveedor> Fproveedors { get; set; }
        [InverseProperty(nameof(FrelProdFrac.IdUsuarioClasificaNavigation))]
        public virtual ICollection<FrelProdFrac> FrelProdFracIdUsuarioClasificaNavigations { get; set; }
        [InverseProperty(nameof(FrelProdFrac.IdUsuarioUltmodifNavigation))]
        public virtual ICollection<FrelProdFrac> FrelProdFracIdUsuarioUltmodifNavigations { get; set; }
        [InverseProperty(nameof(FrelUsuactDetalle.IdUsuarioNavigation))]
        public virtual ICollection<FrelUsuactDetalle> FrelUsuactDetalles { get; set; }
    }
}
