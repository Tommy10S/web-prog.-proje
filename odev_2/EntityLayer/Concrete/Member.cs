using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
     public class Member
    {   
        [Key]
        public int memberID { get; set; }

        [StringLength(50)]
        public string memberName { get; set; }

        [StringLength(50)]
        public string memberSurName { get; set; }

        [StringLength(50)]
        public string memberEmail { get; set; }

        [StringLength(50)]
        public string memberPassword { get; set; }
        
    }
}
