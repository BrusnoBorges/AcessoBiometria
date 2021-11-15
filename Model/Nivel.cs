namespace AcessoBiometria.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("biometria.nivel")]
    public partial class nivel
    {
        public nivel()
        {
            biometria = new HashSet<biometria>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(60)]
        public string Descricao { get; set; }
        public virtual ICollection<biometria> biometria { get; set; }
    }
}
