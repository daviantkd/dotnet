using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToMany.Models
{
    public class Girl
    {
        public Girl()
        {
            //this.Boyfriends = new HashSet<Boyfriend>();
            this.Boyfriends = new List<Boyfriend>();
        }

        public int GirlId { get; set; }
        public string GirlName { get; set; }

        public virtual ICollection<Boyfriend> Boyfriends { get; set; }
    }
}
