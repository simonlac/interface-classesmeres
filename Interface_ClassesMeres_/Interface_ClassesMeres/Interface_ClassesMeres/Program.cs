using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ClassesMeres
{
    class Program
    {
        interface IVolant
        {
            void Decoller();
            void Atterrir();
        }
        
        class Oiseau : IVolant
        {
            public void Decoller()
            {
                Console.WriteLine("Je décolle de mon nid...\n");
            }
            public void Atterrir()
            {
                Console.WriteLine("J'atterris dans mon nid...\n");
            }
        }
        class Avion : IVolant
        {
            public void Decoller()
            {
                Console.WriteLine("L'avion décolle...\n");
            }
            public void Atterrir()
            {
                Console.WriteLine("L'avion atterrit...\n");
            }
        }
        class Projet : IVolant
        {
            public void Decoller()
            {
                Console.WriteLine("Le projet décolle...\n");
            }
            public void Atterrir()
            {
                Console.WriteLine("Le projet atterit...\n");
            }
        }
        static void Main(string[] args)
        {
            List<IVolant> volants = new List<IVolant>();
            volants.Add(new Oiseau());
            volants.Add(new Avion());
            volants.Add(new Projet());
            foreach (IVolant v in volants)
            {
                v.Decoller();
                v.Atterrir();
            }
            Console.ReadKey();

        }

    }
}
        
    
