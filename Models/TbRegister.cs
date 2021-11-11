using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FriendApplication.Models
{
    public class TbRegister
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string MobileNo { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Password and confirm password does not match")]
        public string ConfPassword { get; set; }
    }
}
