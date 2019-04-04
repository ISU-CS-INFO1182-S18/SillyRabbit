using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObjects {
    public class Prison<J,I> {
        private J _Jailor;
        private List<I> _Inmates;

        public J Jailor {
            get { return _Jailor; }
            set { _Jailor = value; }
        }

        public List<I> Inmates {
            get {
                if (_Inmates == null) _Inmates = new List<I>();
                return _Inmates; }
            set { _Inmates = value; }
        }


    }
}
