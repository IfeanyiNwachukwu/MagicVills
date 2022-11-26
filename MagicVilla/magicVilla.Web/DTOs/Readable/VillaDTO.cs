using System.ComponentModel.DataAnnotations;

namespace magicVilla.Web.DTOs.Readable
{
    public class VillaDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string Details { get; set; }
        public double Rate { get; set; }
        public int Occupancy { get; set; }
        public int sqFt { get; set; }
        public string ImageUrl { get; set; }
        public string Amenity { get; set; }
    }
}
