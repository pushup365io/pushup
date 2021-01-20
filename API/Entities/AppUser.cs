namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }

        // ASP.NET Core Identity 
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

    }
}