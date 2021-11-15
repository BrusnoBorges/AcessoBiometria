namespace AcessoBiometria.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("biometria.producaoagricola")]
    public partial class producaoagricola
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(60)]
        public string NomeUniProd { get; set; }
        public int Produto_id { get; set; }
        public int Destino_id { get; set; }
        public int quantEmprg { get; set; }
        public int QuantMaqui { get; set; }
        [Required]
        [StringLength(60)]
        public string NivelAuto { get; set; }
        public virtual destino destino { get; set; }
        public virtual produto produto { get; set; }
    }
}
