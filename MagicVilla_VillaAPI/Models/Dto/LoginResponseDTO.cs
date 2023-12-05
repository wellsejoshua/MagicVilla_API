namespace MagicVilla_VillaAPI.Models.Dto
{
    public class LoginResponseDTO
    {
        public UserDTO User { get; set; }
        //Role is Now contained in the token
        //public string Role { get; set; }
        public string Token { get; set; }
    }
}
