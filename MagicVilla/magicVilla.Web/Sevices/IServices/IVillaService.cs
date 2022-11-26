using magicVilla.Web.DTOs.Writable;

namespace magicVilla.Web.Sevices.IServices
{
    public interface IVillaService
    {
        Task<T> GetAllAsync<T>();
        Task<T> GetAsync<T>(int id);
        Task<T> CreateAsync<T>(VillaCreateDTOW dto);
        Task<T> UpdateAsync<T>(VillaUpdateDTOW dto);
        Task<T> DeleteAsync<T>(int id);
    }
}
