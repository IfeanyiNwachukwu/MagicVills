using System.ComponentModel.DataAnnotations;

namespace MagicVilla_API.DTOs.Writable
{
    public class VillaNumberCreateDTOW
    {
        [Required]
        public int VillaNo { get; set; }
        [Required]
        public int VillaID { get; set; }
        public string SpecialDetails { get; set; }
    }
}
