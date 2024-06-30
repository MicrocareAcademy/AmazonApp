namespace AmazonApp.Areas.Account.Models
{
    public class UserModel
    {
        public string UserName { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string Email { get; set; } = null!;

        public int UserId { get; set; }
    }
}
