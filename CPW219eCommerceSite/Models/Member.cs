using System.ComponentModel.DataAnnotations;

namespace CPW219eCommerceSite.Models
{
    public class Member
    {
        [Key]
        public int MemberID { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public string Username { get; set; }
    }


}
