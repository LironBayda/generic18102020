using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic19092020
{
    class Knight:IComparable
    {

        public string Name { get;private set; }
        public string Birthtown { get; private set; }
        public string Title { get; private set; }

        public Knight(string name, string birthtown, string title)
        {
            Name = name;
            Birthtown = birthtown;
            Title = title;
        }

        public string this[string str]
        {
            get {
                switch (str)
                {
                    case "Name":
                        return Name;

                    case "Birthtown":
                        return Birthtown;

                    case "Title":
                        return Title;

                }

                return "Unknown";


            }
            set {
                switch (str)
                {
                    case "Name":
                         Name=value;
                        break;

                    case "Birthtown":
                        Birthtown= value;
                        break;


                    case "Title":
                         Title= value;
                        break;

                }

             
            }
            
        }


        public override string ToString()
        {
            return $"{Name} {Birthtown} {Title}";
        }

        public int CompareTo(object obj)
        {
            Knight knight = obj as Knight;

            return Name.CompareTo(knight.Name);

        }
    }
}
