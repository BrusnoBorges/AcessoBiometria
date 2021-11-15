namespace AcessoBiometria.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("biometria.destino")]
    public partial class destino
    {
        
        public destino()
        {
            producaoagricola = new HashSet<producaoagricola>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(60)]
        public string Descricao { get; set; }
        public virtual ICollection<producaoagricola> producaoagricola { get; set; }
    }
}
