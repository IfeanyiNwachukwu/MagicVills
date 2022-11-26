using System.ComponentModel.DataAnnotations;

namespace magicVilla.Web.DTOs.Writable
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
