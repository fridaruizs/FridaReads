namespace FridaReads.Server.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<TextModel>? Texts { get; set; }
        public bool IsAdmin { get; set; }
    }
}
