using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class HaberBülteni
    {
        [Key]
        public int AbonelikID { get; set; }
        public string Mail { get; set; }
    }
}
