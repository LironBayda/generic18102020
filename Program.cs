using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic19092020
{
    class Program
    {
        static void Main(string[] args)
        {

            Knight knight1 = new Knight("a","London","g");
            Knight knight2 = new Knight("b", "London", "g");
            Knight knight3 = new Knight("c", "London", "g");

            Magician Magician1 = new Magician("aa", "London", "g");
            Magician Magician2 = new Magician("bb", "London", "g");
            Magician Magician3 = new Magician("cc", "London", "g");


            RoundTable<Knight> RoundTableKnight = new RoundTable<Knight>();
            RoundTable<Magician> RoundTableMagician = new RoundTable<Magician>();
            RoundTableMagician.Add(Magician1);
            RoundTableMagician.Add(Magician2);
            RoundTableMagician.Add(Magician3);
            RoundTableMagician.RemoveAt(5);
            RoundTableMagician.InsertAt(2, Magician3);
            Magician2["Name"] = "n";
            Magician2["Birthtown"] = "n";
            Magician2["FavoriteSpell"] = "n";
            RoundTableMagician.Sort();
            List<Magician> magicians  = RoundTableMagician.GetRounded(6);

            magicians.ForEach(magician => Console.WriteLine(magician.ToString()));

            Console.WriteLine(RoundTableMagician[1]);

            Console.WriteLine(RoundTableMagician["aa"]);

            RoundTableKnight.Add(knight1);
            RoundTableKnight.Add(knight2);
            RoundTableKnight.Add(knight3);
            RoundTableKnight.RemoveAt(5);
          RoundTableKnight.InsertAt(2, knight3);
            knight2["Name"] = "n";
            knight2["Birthtown"] = "n";
            knight2["Title"] = "n";
            RoundTableKnight.Sort();
            List<Knight> knights = RoundTableKnight.GetRounded(6);

            knights.ForEach(knight => Console.WriteLine(knight.ToString()));

            Console.WriteLine(RoundTableKnight[1]);

            Console.WriteLine(RoundTableKnight["a"]);


            Console.ReadLine();
        }
    }
}
