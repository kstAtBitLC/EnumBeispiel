using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumBeispiel {
    class Teilnehmer {
        public int ID { get; set; }
        public string Name { get; set; }
        public Tugend Tugend { get; set; }
        public Reichtum Rechtum { get; set; }
        public Tag Tag { get; set; }

        public string ToString () {
            StringBuilder sb = new StringBuilder ();
            sb.Append ("TN: ").Append(this.Name).Append(" Tugend: ").Append(this.Tugend);
            string s = sb.ToString();

            return s;
        }
    }
}
