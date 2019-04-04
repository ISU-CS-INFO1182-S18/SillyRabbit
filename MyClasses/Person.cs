using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObjects {
    /// <summary>
    /// This is a representation of things that we call people.
    /// </summary>
    /// <remarks>
    /// This class is based from Prof. Holmes Deliver 5 Solution
    /// </remarks>
   public abstract class  Person : IComparable<Person> {
        #region Private Variables 
        // This is the data!!!!
        private String _FirstName = "Frank";
        private String _MiddleName = "Billy";
        private String _LastName = "Bobworth";
        private DateTime _DateOfBirth;
        private Personalities _Personality;

        public static int MagicNumber = 0;
        #endregion

        #region Public Enums
        public enum Personalities {
            Angry, Charismatic, Twitchy = 76, Edgy = 3, Lazy, Sad, Chatty, Euphoric
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Makes a Person
        /// </summary>
        public Person() {

        }
        /// <summary>
        /// Makes a person too. 
        /// </summary>
        /// <param name="fname">Person's first Name</param>
        /// <param name="lname">Person's last Name</param>
        public Person(string fname, string lname) {
            FillPersonData(fname, lname, new DateTime(1980, 1, 1));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="dob"></param>
        public Person(string fname, string lname, DateTime dob) {
            FillPersonData(fname, lname, dob);
        }

        private void FillPersonData(string fname, string lname, DateTime dob) {
            FirstName = fname;
            LastName = lname;
            DateOfBirth = dob;
        }

        #endregion

        #region Public Properties
        public String FirstName {
            get {
                return _FirstName;
            }
            set {
                _FirstName = CapSecond(value).Trim();
            }
        }
        public String MiddleName {
            get {
                return _MiddleName;
            }
            set {
                _MiddleName = value;
            }
        }

        public String LastName {
            get {
                return _LastName;
            }
            set {
                _LastName = value.Trim();
            }
        }

        public string FullName {
            get { return String.Format("{0} {1}", FirstName, LastName);  }
        }

        private Vehicle _Transportation;

        public Vehicle Transportation {
            get { return _Transportation; }
            set { _Transportation = value; }
        }


        public Personalities Personality {
            get {
                return _Personality;
            }
            set {
                _Personality = value;
            }
        }
        /// <summary>
        /// Gets and Sets the Date our person was born
        /// </summary>
        /// <remarks>
        /// If the date given is greater than today, the sets the date to today.
        /// </remarks>
        public DateTime DateOfBirth {
            get {
                return _DateOfBirth;
            }
            set {
                if (value < DateTime.Now) {
                    _DateOfBirth = value;
                } else {
                    _DateOfBirth = DateTime.Now;
                }
            }
        }

        public int Age {
            get {
                return (int)((DateTime.Now - _DateOfBirth).TotalDays / 365.29);
            }
        }


        #endregion

        #region Private Methods
        /// <summary>
        /// Capitalized the second char in a string
        /// </summary>
        /// <param name="strToCap">string to Capitalize</param>
        /// <returns></returns>
        private string CapSecond(string strToCap) {
            return strToCap[0] + strToCap[1].ToString().ToUpper()
               + strToCap.Substring(2);
        }
        #endregion

        #region Public Methods
        public virtual string Sing() {
            return "La La La";
        }

        public abstract Person CopyMe();

        public int CompareTo(object obj) {
            // 1 0 -1
            return this.Age.CompareTo(((Person)obj).Age);
        }
        public int CompareTo(Person other) {
            // 1 0 -1
            //return this.Age.CompareTo(other.Age);
            return other.Age.CompareTo(this.Age);
        }

        public override string ToString() {
            return this.FullName + " " + this.Age;
        }





        #endregion


    }

}
