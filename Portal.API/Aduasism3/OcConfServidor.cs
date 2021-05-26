using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_conf_servidor")]
    public partial class OcConfServidor
    {
        [Key]
        public short Id { get; set; }
        [Required]
        [Column("lugar_llamada")]
        [StringLength(50)]
        public string LugarLlamada { get; set; }
        [Column("servidor_sql")]
        [StringLength(50)]
        public string ServidorSql { get; set; }
        [Column("bd_sql")]
        [StringLength(128)]
        public string BdSql { get; set; }
        [Column("usuario_sql")]
        [StringLength(63)]
        public string UsuarioSql { get; set; }
        [Column("contraseña_sql")]
        [StringLength(128)]
        public string ContraseñaSql { get; set; }
        [Column("prendido")]
        public bool Prendido { get; set; }
    }
}
