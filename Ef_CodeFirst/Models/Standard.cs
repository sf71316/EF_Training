using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_CodeFirst
{
    public class Standard
    {
        public Standard()
        {
            this.Students =new  HashSet<Student>();
        }
        public int StandardId { get; set; }
        public string StandardName { get; set; }

        public virtual ICollection<Student> Students { get; set; }

    }
}
