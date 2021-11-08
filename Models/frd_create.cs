using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FriendApplication.Models
{
    [Table("frd_create")]
    public class frd_create
    {
        [Key]
        public int UserId { get; set; }
        public string Fname { get; set; }

        public string Lname { get; set; }

        public string MobileNo { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
