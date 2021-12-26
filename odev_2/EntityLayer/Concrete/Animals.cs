using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public  class Animals
    {
        [Key]
        public int AnimalID { get; set; }

        [StringLength(50)]
        public string AnimalName { get; set; }

        [StringLength(50)]
        public string AnimalType { get; set; }
    }
}
