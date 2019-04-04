using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObjects {
   public class Hideout<A> {
        private List<A> _Members;

        public List<A> Members {
            get                 {
                if (_Members == null) _Members = new List<A>();
                return _Members; }
            set { _Members = value; }
        }

    }
}
