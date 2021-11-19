namespace AcessoBiometria.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("biometria.agrotoxico")]
    public partial class agrotoxico
    {
        
       
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(30)]
        public string Nome { get; set; }        
    }
}
