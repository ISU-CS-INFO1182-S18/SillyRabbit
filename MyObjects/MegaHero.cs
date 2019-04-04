using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObjects {
    public class MegaHero : SuperHero, INumberable<MegaHero> {
        public MegaHero(string f, string l):base(f,l) {

        }

        public List<int> GetFavoriteNumber() {
            List<int> i = new List<int>();
            i.Add(1);
            i.Add(3);
            return i;
        }

        public string SayFavorite(MegaHero value) {
            throw new NotImplementedException();
        }

        public override string Sing() {
            return base.Sing() + " Fa La La La"; 
        }

        MegaHero INumberable<MegaHero>.GetFavoriteNumber() {
            return this;
        }
    }
}
