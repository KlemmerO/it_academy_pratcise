using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        public static void Main(string [] args)
        {   
            List<Neighbour> FloorNeighbour1 = new List<Neighbour>();
            FloorNeighbour1.Add(new Neighbour("Vadzim Papko",23,2353489));
            List<Neighbour> FloorNeighbour2 = new List<Neighbour>();            
            FloorNeighbour2.Add(new Neighbour("Olga Klemmer",12,2345648));
            List<Neighbour> FloorNeighbour3 = new List<Neighbour>();
            FloorNeighbour3.Add(new Neighbour("Vasja Pupkin",2,2347895));

            Console.WriteLine("Input the flat number");
            string text = Console.ReadLine();
            int x = Convert.ToInt32(text);
            if (x == 1)
            {
                foreach (var neighbour in FloorNeighbour1)
                {
                Console.WriteLine($"Name:{neighbour.FullName} Flat:{neighbour.FlatNumber} Number:{neighbour.PhoneNumber}");
                }                
            }
            if (x == 2)
            {
                foreach (var neighbour in FloorNeighbour2)
                {
                    Console.WriteLine($"Name:{neighbour.FullName} Flat:{neighbour.FlatNumber} Number:{neighbour.PhoneNumber}");
                }
            }
            if (x == 3)
            {
                foreach (var neighbour in FloorNeighbour3)
                {
                    Console.WriteLine($"Name:{neighbour.FullName} Flat:{neighbour.FlatNumber} Number:{neighbour.PhoneNumber}");
                }
            }

            else 
                {
                    foreach (var neighbour in FloorNeighbour3)
                    {
                        Console.WriteLine($"Missing adress");
                    }
                }
        }
    }
}




