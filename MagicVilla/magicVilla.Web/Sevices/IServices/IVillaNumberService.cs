using magicVilla.Web.DTOs.Writable;

namespace magicVilla.Web.Sevices.IServices
{
    public interface IVillaNumberService
    {
        Task<T> GetAllAsync<T>();
        Task<T> GetAsync<T>(int id);
        Task<T> CreateAsync<T>(VillaNumberCreateDTOW dto);
        Task<T> UpdateAsync<T>(VillaNumberUpdateDTOW dto);
        Task<T> DeleteAsync<T>(int id);
    }
}
