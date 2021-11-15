namespace AcessoBiometria.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("biometria.produto")]
    public partial class produto
    {
        public produto()
        {
            producaoagricola = new HashSet<producaoagricola>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(60)]
        public string Nome { get; set; }
        public virtual ICollection<producaoagricola> producaoagricola { get; set; }
    }
}
