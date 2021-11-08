using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace FriendApplication.Models
{
    public class TbLogin
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage ="Please Enter Mobile No")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Please Enter Valid Mobile Number.")]
        public string MobileNo { get; set; }


        [DataMember]
        [Required(ErrorMessage ="Please Enter password")]
        public string Password { get; set; }


        [Required(ErrorMessage ="Please Enter Name")]
        public string Name { get; set; }

     
        [Required(ErrorMessage = "Please Enter Confirm Pasword")]
        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        public string ConfPassword { get; set; }
    }
}
