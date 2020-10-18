using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic19092020
{
    class Magician:IComparable
    {
        public Magician(string name, string birthtown, string favoriteSpell)
        {
            Name = name;
            Birthtown = birthtown;
            FavoriteSpell = favoriteSpell;
        }

        public string Name { get; private set; }
        public string Birthtown { get; private set; }
        public string FavoriteSpell { get; private set; }

        public string this[string str]
        {
            get
            {
                switch (str)
                {
                    case "Name":
                        return Name;

                    case "Birthtown":
                        return Birthtown;

                    case "FavoriteSpell":
                        return FavoriteSpell;

                }

                return "Unknown";


            }
            set
            {
                switch (str)
                {
                    case "Name":
                        Name = value;
                        break;

                    case "Birthtown":
                        Birthtown = value;
                        break;


                    case "FavoriteSpell":
                        FavoriteSpell = value;
                        break;

                }


            }

        }


        public override string ToString()
        {
            return  $"{Name} {Birthtown} {FavoriteSpell}";
        }

        public int CompareTo(object obj)
        {
            Magician magician  = obj as Magician;

            return Name.CompareTo(magician.Name);

        }
    }
}
