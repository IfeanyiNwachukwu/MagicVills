using magicVilla.Web.Models;

namespace magicVilla.Web.Sevices.IServices
{
    public interface IBaseService
    {
        APIResponse responseModel { get; set; }

        Task<T> SendAsync<T>(APIRequest apiRequest);
    }
}
