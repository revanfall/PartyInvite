using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvite.Models
{
    public class GuestResponce
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Input your name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Input your E-mail")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="Please input validated e-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Input your phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Please select whether you are going to attend event or not")]
        public bool? WillAttend { get; set; }

    }
}
