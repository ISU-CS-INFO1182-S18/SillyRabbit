using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObjects {
   public static class Universe {
        private static List<Person> _People;
        private static List<SuperHero> _SuperHeroes;
        private static List<Villian> _Villians;
        private static List<Citizen> _Citizens;

        public static List<SuperHero> SuperHeroes {
            get {
                if (_SuperHeroes == null) MakeSupers();
                return _SuperHeroes; }
            set { _SuperHeroes = value; }
        }

        public static List<Citizen> Citizens {
            get {
                if (_Citizens == null) PopulateCity();
                return _Citizens; }
            set { _Citizens = value; }
        }


        public static List<Villian> Villians {
            get {
                if (_Villians == null) MakeBaddies();
                return _Villians; }
            set { _Villians = value; }
        }

        public static List<Person> People {
            get {
                if (_People == null) _People = new List<Person>();
                return _People;
            }
            set { _People = value; }
        }

        private static void MakeSupers() {
            _SuperHeroes = new List<SuperHero>();
            
            _SuperHeroes.Add(new SuperHero("Superman", "") { SecretIdentity = Citizens[0] });
            _SuperHeroes.Add(new SuperHero("Batman", "") { SecretIdentity = Citizens[1] });
            _SuperHeroes.Add(new SuperHero("Wonder", "Woman") { SecretIdentity = Citizens[2] });
            _SuperHeroes.Add(new SuperHero("Green", "Lantern") { SecretIdentity = Citizens[3] });
            _SuperHeroes.Add(new SuperHero("The", "Flash") { SecretIdentity = Citizens[4] });
            _SuperHeroes.Add(new SuperHero("Supegirl", "") { SecretIdentity = Citizens[5] });
            _SuperHeroes.Add(new SuperHero("Aquaman", ""));
        }
        private static void MakeBaddies() {
            _Villians = new List<Villian>();
            _Villians.Add(new Villian() { FirstName = "Lex", LastName = "Luther" });
            _Villians.Add(new Villian() { FirstName = "Joker" });
            _Villians.Add(new Villian() { FirstName = "Bane" });
            _Villians.Add(new Villian() { FirstName = "Sinestro" });
            _Villians.Add(new Villian() { FirstName = "Felix", LastName = "Faust" });
            _Villians.Add(new Villian() { FirstName = "Doomsday" });
            _Villians.Add(new Villian() { FirstName = "Circe" });
            _Villians.Add(new Villian() { FirstName = "Gigantica" });
            _Villians.Add(new Villian() { FirstName = "Harley" });

        }

        private static void PopulateCity() {
            _Citizens = new List<Citizen>();
            _Citizens.Add(new Citizen() { FirstName = "Clark", LastName = "Kent" });     //0
            _Citizens.Add(new Citizen() { FirstName = "Bruce", LastName = "Wayne" });    //1
            _Citizens.Add(new Citizen() { FirstName = "Diana", LastName = "Prince" });   //2
            _Citizens.Add(new Citizen() { FirstName = "Alan", LastName = "Scott" });     //3
            _Citizens.Add(new Citizen() { FirstName = "Barry", LastName = "Allen" });    //4
            _Citizens.Add(new Citizen() { FirstName = "Linda", LastName = "Danvers" });  //5
            _Citizens.Add(new Citizen() { FirstName = "Doris", LastName = "Zeul" });     //6 
            _Citizens.Add(new Citizen() { FirstName = "Ross", MiddleName = "Zane", LastName = "Flynn", DateOfBirth = new DateTime(1984, 11, 28) });
            _Citizens.Add(new Citizen() { FirstName = "Gay", MiddleName = "Naida", LastName = "Bullock", DateOfBirth = new DateTime(1992, 06, 21) });
            _Citizens.Add(new Citizen() { FirstName = "Lucas", MiddleName = "Geoffrey", LastName = "Franklin", DateOfBirth = new DateTime(2018, 09, 20) });
            _Citizens.Add(new Citizen() { FirstName = "Oscar", MiddleName = "Marshall", LastName = "Cruz", DateOfBirth = new DateTime(2018, 01, 10) });
            _Citizens.Add(new Citizen() { FirstName = "Wang", MiddleName = "Zephania", LastName = "Guerrero", DateOfBirth = new DateTime(1974, 11, 10) });
            _Citizens.Add(new Citizen() { FirstName = "Kevyn", MiddleName = "Dorian", LastName = "Singleton", DateOfBirth = new DateTime(1923, 03, 07) });
            _Citizens.Add(new Citizen() { FirstName = "Chelsea", MiddleName = "Wayne", LastName = "Holcomb", DateOfBirth = new DateTime(1963, 06, 03) });
            _Citizens.Add(new Citizen() { FirstName = "Nash", MiddleName = "Dale", LastName = "Alexander", DateOfBirth = new DateTime(1934, 02, 17) });
            _Citizens.Add(new Citizen() { FirstName = "Sybil", MiddleName = "Brock", LastName = "Bradley", DateOfBirth = new DateTime(2009, 08, 02) });
            _Citizens.Add(new Citizen() { FirstName = "Clark", MiddleName = "Cruz", LastName = "Alvarado", DateOfBirth = new DateTime(1975, 07, 03) });
            _Citizens.Add(new Citizen() { FirstName = "Iris", MiddleName = "Idona", LastName = "Harding", DateOfBirth = new DateTime(1976, 10, 25) });
            _Citizens.Add(new Citizen() { FirstName = "Alfonso", MiddleName = "Alec", LastName = "Deleon", DateOfBirth = new DateTime(2001, 06, 24) });
            _Citizens.Add(new Citizen() { FirstName = "Nissim", MiddleName = "Britanni", LastName = "Mcmahon", DateOfBirth = new DateTime(1992, 06, 27) });
            _Citizens.Add(new Citizen() { FirstName = "Alexis", MiddleName = "Raphael", LastName = "Stafford", DateOfBirth = new DateTime(1938, 03, 27) });
            _Citizens.Add(new Citizen() { FirstName = "Gage", MiddleName = "Xanthus", LastName = "Knight", DateOfBirth = new DateTime(1967, 11, 06) });
            _Citizens.Add(new Citizen() { FirstName = "Giacomo", MiddleName = "Morgan", LastName = "Robbins", DateOfBirth = new DateTime(1971, 03, 14) });
            _Citizens.Add(new Citizen() { FirstName = "Linus", MiddleName = "Sylvester", LastName = "Cochran", DateOfBirth = new DateTime(1935, 09, 19) });
            _Citizens.Add(new Citizen() { FirstName = "Dustin", MiddleName = "Hasad", LastName = "Good", DateOfBirth = new DateTime(1992, 07, 09) });
            _Citizens.Add(new Citizen() { FirstName = "Vernon", MiddleName = "Gage", LastName = "Peck", DateOfBirth = new DateTime(2017, 11, 05) });
            _Citizens.Add(new Citizen() { FirstName = "Amanda", MiddleName = "Alexa", LastName = "Sparks", DateOfBirth = new DateTime(1992, 06, 11) });
            _Citizens.Add(new Citizen() { FirstName = "Karyn", MiddleName = "George", LastName = "Wilcox", DateOfBirth = new DateTime(1918, 12, 27) });
            _Citizens.Add(new Citizen() { FirstName = "Judah", MiddleName = "Daphne", LastName = "Ryan", DateOfBirth = new DateTime(1921, 12, 05) });
            _Citizens.Add(new Citizen() { FirstName = "Eaton", MiddleName = "Francis", LastName = "Barker", DateOfBirth = new DateTime(1929, 05, 05) });
            _Citizens.Add(new Citizen() { FirstName = "Quincy", MiddleName = "Cody", LastName = "Thornton", DateOfBirth = new DateTime(1921, 07, 17) });
            _Citizens.Add(new Citizen() { FirstName = "Ignatius", MiddleName = "April", LastName = "Mckee", DateOfBirth = new DateTime(1947, 03, 07) });
            _Citizens.Add(new Citizen() { FirstName = "Colby", MiddleName = "Leila", LastName = "Goff", DateOfBirth = new DateTime(1986, 01, 13) });
            _Citizens.Add(new Citizen() { FirstName = "Armand", MiddleName = "Len", LastName = "Poole", DateOfBirth = new DateTime(2005, 08, 28) });
            _Citizens.Add(new Citizen() { FirstName = "Desirae", MiddleName = "Candace", LastName = "Golden", DateOfBirth = new DateTime(1923, 09, 24) });
            _Citizens.Add(new Citizen() { FirstName = "September", MiddleName = "Nolan", LastName = "Blackwell", DateOfBirth = new DateTime(1957, 11, 15) });
            _Citizens.Add(new Citizen() { FirstName = "Bree", MiddleName = "Illana", LastName = "Nolan", DateOfBirth = new DateTime(1999, 05, 19) });
            _Citizens.Add(new Citizen() { FirstName = "Eliana", MiddleName = "Blaze", LastName = "Shelton", DateOfBirth = new DateTime(1932, 04, 28) });
            _Citizens.Add(new Citizen() { FirstName = "Iona", MiddleName = "Colleen", LastName = "Dorsey", DateOfBirth = new DateTime(1989, 03, 02) });
            _Citizens.Add(new Citizen() { FirstName = "Mallory", MiddleName = "Nadine", LastName = "Wise", DateOfBirth = new DateTime(2011, 04, 11) });
            _Citizens.Add(new Citizen() { FirstName = "Allegra", MiddleName = "Sarah", LastName = "Hardin", DateOfBirth = new DateTime(1951, 08, 30) });
            _Citizens.Add(new Citizen() { FirstName = "Alexis", MiddleName = "Hedwig", LastName = "Copeland", DateOfBirth = new DateTime(1945, 02, 04) });
            _Citizens.Add(new Citizen() { FirstName = "Lilah", MiddleName = "Kirestin", LastName = "Campos", DateOfBirth = new DateTime(1986, 11, 29) });
            _Citizens.Add(new Citizen() { FirstName = "Timothy", MiddleName = "Emily", LastName = "Kane", DateOfBirth = new DateTime(1981, 10, 23) });
            _Citizens.Add(new Citizen() { FirstName = "Graiden", MiddleName = "Herman", LastName = "Mcdaniel", DateOfBirth = new DateTime(1989, 12, 22) });
            _Citizens.Add(new Citizen() { FirstName = "Vivian", MiddleName = "Kyle", LastName = "Dennis", DateOfBirth = new DateTime(1946, 10, 15) });
            _Citizens.Add(new Citizen() { FirstName = "Arsenio", MiddleName = "Dora", LastName = "Weaver", DateOfBirth = new DateTime(1972, 07, 13) });
            _Citizens.Add(new Citizen() { FirstName = "Kasimir", MiddleName = "Julie", LastName = "Peters", DateOfBirth = new DateTime(1920, 11, 23) });
            _Citizens.Add(new Citizen() { FirstName = "Andrew", MiddleName = "Chadwick", LastName = "Dyer", DateOfBirth = new DateTime(1947, 08, 20) });
            _Citizens.Add(new Citizen() { FirstName = "Whitney", MiddleName = "Ocean", LastName = "Owen", DateOfBirth = new DateTime(2017, 04, 15) });
            _Citizens.Add(new Citizen() { FirstName = "Charles", MiddleName = "Quincy", LastName = "Cross", DateOfBirth = new DateTime(2000, 06, 18) });
            _Citizens.Add(new Citizen() { FirstName = "Caryn", MiddleName = "Clayton", LastName = "Delgado", DateOfBirth = new DateTime(2014, 08, 11) });
            _Citizens.Add(new Citizen() { FirstName = "Shay", MiddleName = "Halee", LastName = "Atkins", DateOfBirth = new DateTime(1930, 01, 09) });
            _Citizens.Add(new Citizen() { FirstName = "Carissa", MiddleName = "Wyatt", LastName = "Church", DateOfBirth = new DateTime(1970, 06, 25) });
            _Citizens.Add(new Citizen() { FirstName = "Kelly", MiddleName = "Jada", LastName = "Holman", DateOfBirth = new DateTime(2005, 03, 22) });
            _Citizens.Add(new Citizen() { FirstName = "Callum", MiddleName = "Kalia", LastName = "Webb", DateOfBirth = new DateTime(1939, 02, 25) });
            _Citizens.Add(new Citizen() { FirstName = "Cailin", MiddleName = "Stone", LastName = "Snider", DateOfBirth = new DateTime(1995, 01, 05) });
            _Citizens.Add(new Citizen() { FirstName = "Wynne", MiddleName = "Neville", LastName = "Coleman", DateOfBirth = new DateTime(2008, 08, 28) });
            _Citizens.Add(new Citizen() { FirstName = "Quinn", MiddleName = "Ezekiel", LastName = "Fitzpatrick", DateOfBirth = new DateTime(1927, 08, 06) });
            _Citizens.Add(new Citizen() { FirstName = "Shana", MiddleName = "Brian", LastName = "Hunt", DateOfBirth = new DateTime(2007, 12, 11) });
            _Citizens.Add(new Citizen() { FirstName = "Kirk", MiddleName = "Nevada", LastName = "Malone", DateOfBirth = new DateTime(1936, 01, 21) });
            _Citizens.Add(new Citizen() { FirstName = "Chiquita", MiddleName = "Wylie", LastName = "Burnett", DateOfBirth = new DateTime(2016, 04, 05) });
            _Citizens.Add(new Citizen() { FirstName = "Charissa", MiddleName = "Quinn", LastName = "Dunlap", DateOfBirth = new DateTime(1942, 09, 10) });
            _Citizens.Add(new Citizen() { FirstName = "Minerva", MiddleName = "Quinn", LastName = "Dickson", DateOfBirth = new DateTime(1965, 01, 24) });
            _Citizens.Add(new Citizen() { FirstName = "Geraldine", MiddleName = "Cade", LastName = "Yates", DateOfBirth = new DateTime(1983, 02, 16) });
            _Citizens.Add(new Citizen() { FirstName = "Demetria", MiddleName = "Kylynn", LastName = "Bridges", DateOfBirth = new DateTime(1938, 02, 19) });
            _Citizens.Add(new Citizen() { FirstName = "Eve", MiddleName = "Dustin", LastName = "Lynch", DateOfBirth = new DateTime(1997, 04, 05) });
            _Citizens.Add(new Citizen() { FirstName = "Noah", MiddleName = "Tara", LastName = "Patrick", DateOfBirth = new DateTime(1977, 10, 01) });
            _Citizens.Add(new Citizen() { FirstName = "Jayme", MiddleName = "Rina", LastName = "Morin", DateOfBirth = new DateTime(1946, 11, 01) });
            _Citizens.Add(new Citizen() { FirstName = "Bruno", MiddleName = "Abdul", LastName = "Russo", DateOfBirth = new DateTime(1975, 06, 02) });
            _Citizens.Add(new Citizen() { FirstName = "Brett", MiddleName = "Ethan", LastName = "Avery", DateOfBirth = new DateTime(2002, 10, 26) });
            _Citizens.Add(new Citizen() { FirstName = "Anne", MiddleName = "Sylvia", LastName = "Wilcox", DateOfBirth = new DateTime(1988, 10, 31) });
            _Citizens.Add(new Citizen() { FirstName = "Silas", MiddleName = "April", LastName = "Trujillo", DateOfBirth = new DateTime(1926, 08, 12) });
            _Citizens.Add(new Citizen() { FirstName = "Ray", MiddleName = "Curran", LastName = "Randall", DateOfBirth = new DateTime(1977, 01, 04) });
            _Citizens.Add(new Citizen() { FirstName = "Darryl", MiddleName = "Shea", LastName = "Armstrong", DateOfBirth = new DateTime(1935, 01, 01) });
            _Citizens.Add(new Citizen() { FirstName = "Nash", MiddleName = "Blair", LastName = "Nicholson", DateOfBirth = new DateTime(1990, 02, 13) });
            _Citizens.Add(new Citizen() { FirstName = "Louis", MiddleName = "Graiden", LastName = "Dalton", DateOfBirth = new DateTime(1928, 01, 16) });
            _Citizens.Add(new Citizen() { FirstName = "Marny", MiddleName = "Cailin", LastName = "Hull", DateOfBirth = new DateTime(1993, 12, 04) });
            _Citizens.Add(new Citizen() { FirstName = "Grant", MiddleName = "Kevin", LastName = "Beck", DateOfBirth = new DateTime(2005, 03, 18) });
            _Citizens.Add(new Citizen() { FirstName = "Isadora", MiddleName = "Harlan", LastName = "Roman", DateOfBirth = new DateTime(1943, 05, 01) });
            _Citizens.Add(new Citizen() { FirstName = "Kitra", MiddleName = "Quynn", LastName = "Cunningham", DateOfBirth = new DateTime(2008, 07, 13) });
            _Citizens.Add(new Citizen() { FirstName = "Noelle", MiddleName = "Alisa", LastName = "Thornton", DateOfBirth = new DateTime(1965, 11, 03) });
            _Citizens.Add(new Citizen() { FirstName = "Kermit", MiddleName = "Fuller", LastName = "Little", DateOfBirth = new DateTime(1971, 01, 08) });
            _Citizens.Add(new Citizen() { FirstName = "Brandon", MiddleName = "Kane", LastName = "Burton", DateOfBirth = new DateTime(1919, 01, 22) });
            _Citizens.Add(new Citizen() { FirstName = "Delilah", MiddleName = "Brittany", LastName = "Vincent", DateOfBirth = new DateTime(1984, 04, 15) });
            _Citizens.Add(new Citizen() { FirstName = "Micah", MiddleName = "David", LastName = "Clay", DateOfBirth = new DateTime(1929, 01, 10) });
            _Citizens.Add(new Citizen() { FirstName = "Boris", MiddleName = "Kai", LastName = "Neal", DateOfBirth = new DateTime(1988, 07, 27) });
            _Citizens.Add(new Citizen() { FirstName = "Uriah", MiddleName = "Wing", LastName = "Bryan", DateOfBirth = new DateTime(1960, 05, 22) });
            _Citizens.Add(new Citizen() { FirstName = "Fuller", MiddleName = "Barry", LastName = "Dale", DateOfBirth = new DateTime(2001, 12, 09) });
            _Citizens.Add(new Citizen() { FirstName = "Carlos", MiddleName = "Kaitlin", LastName = "Stein", DateOfBirth = new DateTime(2006, 10, 11) });
            _Citizens.Add(new Citizen() { FirstName = "Ray", MiddleName = "Wayne", LastName = "Madden", DateOfBirth = new DateTime(1942, 08, 14) });
            _Citizens.Add(new Citizen() { FirstName = "Grace", MiddleName = "Stewart", LastName = "Pickett", DateOfBirth = new DateTime(1978, 09, 23) });
            _Citizens.Add(new Citizen() { FirstName = "Austin", MiddleName = "Jerome", LastName = "Conley", DateOfBirth = new DateTime(1933, 09, 12) });
            _Citizens.Add(new Citizen() { FirstName = "Maya", MiddleName = "Selma", LastName = "Beach", DateOfBirth = new DateTime(1941, 11, 10) });
            _Citizens.Add(new Citizen() { FirstName = "Joel", MiddleName = "Ramona", LastName = "Heath", DateOfBirth = new DateTime(2001, 05, 11) });
            _Citizens.Add(new Citizen() { FirstName = "Lucy", MiddleName = "Odette", LastName = "Forbes", DateOfBirth = new DateTime(2002, 08, 04) });
            _Citizens.Add(new Citizen() { FirstName = "Catherine", MiddleName = "Cooper", LastName = "Vargas", DateOfBirth = new DateTime(1966, 12, 02) });
            _Citizens.Add(new Citizen() { FirstName = "Rhoda", MiddleName = "Indira", LastName = "Compton", DateOfBirth = new DateTime(1943, 09, 12) });
            _Citizens.Add(new Citizen() { FirstName = "Tyler", MiddleName = "Octavius", LastName = "Wiley", DateOfBirth = new DateTime(1994, 04, 20) });
            _Citizens.Add(new Citizen() { FirstName = "Elizabeth", MiddleName = "Mechelle", LastName = "Lloyd", DateOfBirth = new DateTime(2018, 06, 19) });
            _Citizens.Add(new Citizen() { FirstName = "Lareina", MiddleName = "Lars", LastName = "Mckay", DateOfBirth = new DateTime(2001, 08, 06) });
            _Citizens.Add(new Citizen() { FirstName = "Hilda", MiddleName = "Edan", LastName = "Clay", DateOfBirth = new DateTime(2017, 02, 13) });
            _Citizens.Add(new Citizen() { FirstName = "Audra", MiddleName = "Victor", LastName = "Brooks", DateOfBirth = new DateTime(1998, 06, 06) });
            _Citizens.Add(new Citizen() { FirstName = "Fulton", MiddleName = "Arthur", LastName = "Bradford", DateOfBirth = new DateTime(1960, 02, 27) });
            _Citizens.Add(new Citizen() { FirstName = "Nigel", MiddleName = "Rafael", LastName = "Christensen", DateOfBirth = new DateTime(1928, 12, 19) });
            _Citizens.Add(new Citizen() { FirstName = "Lois", MiddleName = "Jaime", LastName = "Valentine", DateOfBirth = new DateTime(1990, 04, 09) });
            _Citizens.Add(new Citizen() { FirstName = "Imani", MiddleName = "Cassady", LastName = "Becker", DateOfBirth = new DateTime(1925, 10, 17) });

        }

    }
}
