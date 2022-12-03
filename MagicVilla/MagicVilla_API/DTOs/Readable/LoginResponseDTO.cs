using MagicVilla_API.Models;

namespace MagicVilla_API.DTOs.Readable
{
    public class LoginResponseDTO
    {
        public LocalUser User { get; set; }
        public string Token { get; set; }
    }
}
