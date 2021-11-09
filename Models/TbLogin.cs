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
        [Required]
        
        public string MobileNo { get; set; }
       
        [Required]
        public string Password { get; set; }
       
        public string Name { get; set; }
        
        
        public string ConfPassword { get; set; }
    }
}
