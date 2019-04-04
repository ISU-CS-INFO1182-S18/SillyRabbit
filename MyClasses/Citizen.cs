using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObjects {
 public    class Citizen:Person,INumberable<int> {
        //public abstract string Yell();
        public override Person CopyMe() {
            Person vc = new Citizen();
            vc.FirstName = this.FirstName;
            vc.LastName = this.LastName;
            vc.Personality = Personalities.Chatty;
            vc.MiddleName = this.MiddleName;
            vc.DateOfBirth = this.DateOfBirth;
            return vc;
        }

        public int GetFavoriteNumber() {
            return 3;
        }

        public string SayFavorite(int value) {
            throw new NotImplementedException();
        }
    }
}
