using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToMany.Models
{
    public class Boyfriend
    {
        public int BoyfriendId { get; set; }
        public string BoyfriendName { get; set; }

        public int GirlId { get; set; }
        public virtual Girl Girl { get; set; }
    }
}
