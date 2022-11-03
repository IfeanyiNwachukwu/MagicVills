using System.ComponentModel.DataAnnotations;

namespace MagicVilla_API.DTOs.Writable
{
    public class VillaCreateDTOW
    {
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
