using LasticShop.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace LasticShop.DatabaseModels
{
    public class User
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public DateTime Created { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; } = Gender.Other;
    }
}
