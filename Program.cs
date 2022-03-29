using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace systemIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite putanju direktorija: ");
            string putanja = Console.ReadLine();
            
            if (Directory.Exists(putanja))
            {
                Console.WriteLine("Datoteke: ");
                foreach (string datoteka in Directory.GetFiles(putanja))
                {
                    Console.WriteLine(datoteka);
                }
            }

            string putanjaPoddirektorija = "\\Test";
            string novaPutanja = putanja + putanjaPoddirektorija;

            if (!Directory.Exists(putanja+putanjaPoddirektorija))
            {
                Directory.CreateDirectory(novaPutanja);
            }
            else
            {
                Console.WriteLine("Direktorij već postoji");
            }

            if (Directory.Exists(putanja))
            {
                Console.WriteLine("Poddirektoriji:");
                foreach (string poddirektoriji in Directory.GetDirectories(putanja))
                Console.WriteLine(poddirektoriji);
            }

            Directory.Delete(novaPutanja);

            Console.WriteLine("Nakon brisanja:");
            foreach (string poddirektorij in Directory.GetDirectories(putanja))
            {
                Console.WriteLine(poddirektorij);
            }

            Console.ReadKey();
        }
    }
}
