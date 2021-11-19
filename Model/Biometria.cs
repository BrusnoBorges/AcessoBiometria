namespace AcessoBiometria.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Drawing;

    [Table("biometria.biometria")]
    public partial class biometria
    {
        public biometria()
        {
            usuario = new HashSet<usuario>();
        }
        [Key]
        public int id { get; set; } 
        [Column("Biometria")]
        [Required]
        public byte[] biometria1 { get; set; }
        public int Nivel_id { get; set; } 
        public virtual nivel nivel { get; set; }
        public virtual ICollection<usuario> usuario { get; set; }
    }
}
