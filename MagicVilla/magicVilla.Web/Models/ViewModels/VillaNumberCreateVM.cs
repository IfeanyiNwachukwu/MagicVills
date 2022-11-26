using magicVilla.Web.DTOs.Writable;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace magicVilla.Web.Models.ViewModels
{
    public class VillaNumberCreateVM
    {
        public VillaNumberCreateVM()
        {
            VillaNumber = new VillaNumberCreateDTOW();
        }

        public VillaNumberCreateDTOW VillaNumber {get; set;}
        [ValidateNever]
        public IEnumerable<SelectListItem> VillaList { get; set;}
    }
}
