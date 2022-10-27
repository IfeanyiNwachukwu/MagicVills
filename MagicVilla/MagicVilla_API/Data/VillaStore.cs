using MagicVilla_API.DTOs.Readable;

namespace MagicVilla_API.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
            {
                new VillaDTO{Id=1,Name="Pool View",sqFt = 100,Occupancy = 4},
                new VillaDTO{Id=2,Name="Beach View",sqFt = 300,Occupancy = 3}
            };
    }
}
