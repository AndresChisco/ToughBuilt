namespace Prueba.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [StringLength(200)]
        public string description { get; set; }

        public decimal price { get; set; }

        public int? stock { get; set; }

        [StringLength(500)]
        public string featuredCharacteristics { get; set; }

        [StringLength(500)]
        public string feaaturedImages { get; set; }
    }
}
