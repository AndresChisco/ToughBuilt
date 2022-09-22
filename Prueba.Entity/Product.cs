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
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public decimal Price { get; set; }

        public int? Stock { get; set; }

        [StringLength(500)]
        public string FeaturedCharacteristics { get; set; }

        [StringLength(500)]
        public string FeaturedImages { get; set; }

        public bool? Active { get; set; }
    }
}
