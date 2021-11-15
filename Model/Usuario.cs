namespace AcessoBiometria.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("biometria.usuario")]
    public partial class usuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(60)]
        public string Login { get; set; }
        [Required]
        [StringLength(60)]
        public string Senha { get; set; }
        public int Biometria_id { get; set; }
        public virtual agrotoxico agrotoxico { get; set; }
    }
}
