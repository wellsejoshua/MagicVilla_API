namespace MagicVilla_Web.Models.Dto
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        //encrypt and store in database
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
