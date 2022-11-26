using magicVilla.Web.DTOs.Writable;
using magicVilla.Web.Models;
using magicVilla.Web.Sevices.IServices;
using MagicVilla.Utility;
using static MagicVilla.Utility.StaticDetails;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Configuration;

namespace magicVilla.Web.Sevices
{
    public class VillaNumberService : BaseService, IVillaNumberService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string villaUrl;

        public VillaNumberService(IHttpClientFactory clientFactory,  IConfiguration configuration):base(clientFactory)
        {
            _clientFactory = clientFactory;
            villaUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI");
        }

        public Task<T> CreateAsync<T>(VillaNumberCreateDTOW dto)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = ApiType.POST,
                Data = dto,
                Url = villaUrl + "/api/villaNumber",
              
            });
        }

        public Task<T> DeleteAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = ApiType.DELETE,
                Url = villaUrl + "/api/villaNumber/" + id,
               
            });
        }

        public Task<T> GetAllAsync<T>()
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = ApiType.GET,
                Url = villaUrl + "/api/villaNumber",
                
            });
        }

        public Task<T> GetAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = ApiType.GET,
                Url = villaUrl + "/api/villaNumber/" + id,
                
            });
        }

        public Task<T> UpdateAsync<T>(VillaNumberUpdateDTOW dto)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = ApiType.PUT,
                Data = dto,
                Url = villaUrl + "/api/villaNumber/" + dto.VillaNo,
            }); 
        }
    }
}
