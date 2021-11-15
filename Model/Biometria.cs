namespace AcessoBiometria.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("biometria.biometria")]
    public partial class biometria
    {
        [Key]
        public int id { get; set; }
        [Column("biometria")]
        [Required]
        [StringLength(60)]
        public string biometria1 { get; set; }
        public int Nivel_id { get; set; }
        public virtual nivel nivel { get; set; }
    }
}
