namespace AcessoBiometria.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("biometria.fiscal")]
    public partial class fiscal
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int id { get; set; }
        public float InceRece { get; set; }
        public float ImposMuniPago { get; set; }
        public float ImposEstaReco { get; set; }
        public float ImposFedePago { get; set; }
        public float TaxaFedePaga { get; set; }
    }
}
