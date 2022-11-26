using magicVilla.Web.DTOs.Writable;
using magicVilla.Web.Models;
using magicVilla.Web.Sevices.IServices;
using MagicVilla.Utility;
using static MagicVilla.Utility.StaticDetails;

namespace magicVilla.Web.Sevices
{
    public class VillaService : BaseService, IVillaService
    {
        private readonly IHttpClientFactory _clietFactory;
        private string villaUrl;
        public VillaService(IHttpClientFactory clietFactory, IConfiguration configuration) : base(clietFactory)
        {
            _clietFactory = clietFactory;
            villaUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI");
        }
        public Task<T> CreateAsync<T>(VillaCreateDTOW dto)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.POST,
                Data = dto,
                Url = villaUrl + "/api/VillaAPI"
            });
        }

        public Task<T> DeleteAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = ApiType.DELETE,
                Url = villaUrl + "/api/VillaAPI/" + id
            });
        }

        public Task<T> GetAllAsync<T>()
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = ApiType.GET,
                Url = villaUrl + "/api/VillaAPI"
            });
        }

        public Task<T> GetAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = ApiType.GET,
                Url = villaUrl + "/api/VillaAPI/" + id
            });
        }

        public Task<T> UpdateAsync<T>(VillaUpdateDTOW dto)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = ApiType.PUT,
                Data = dto,
                Url = villaUrl + "/api/VillaAPI/" + dto.Id
            });
        }
    }
}
