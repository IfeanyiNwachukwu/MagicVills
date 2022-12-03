using MagicVilla_API.DTOs.Readable;
using MagicVilla_API.DTOs.Writable;
using MagicVilla_API.Models;

namespace MagicVilla_API.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);

        Task<LoginResponseDTO> Login(LoginRequestDTOW loginRequestDTOW);

        Task<LocalUser> Register(RegisterationRequestDTOW registerationRequestDTOW);
    }
}
