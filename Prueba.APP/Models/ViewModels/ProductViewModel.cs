using System.ComponentModel.DataAnnotations;

namespace Prueba.APP.Models.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public decimal Price { get; set; }

        public int? Stock { get; set; }

        [Display(Name = "Features")]
        [StringLength(500)]
        public string FeaturedCharacteristics { get; set; }

        [Display(Name ="Image")]
        [StringLength(500)]
        public string FeaturedImages { get; set; }
    }
}