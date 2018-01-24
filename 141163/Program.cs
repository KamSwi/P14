using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141163
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<Magazyn> stos = new Stack<Magazyn>();
            stos.Push(new Magazyn("a"));
            stos.Push(new Magazyn("b"));
            stos.Push(new Magazyn("c"));
            Console.WriteLine("{0}", stos.Pop());
            Console.WriteLine("{0}", stos.Pop());
            Console.WriteLine("{0}", stos.Pop());
            List<Bohater> mo = new List<Bohater>();
            mo.Add(new Ork(120, 12));
            mo.Add(new Ork(120, 10));
            mo.Add(new Elf(90, "10"));
            mo.Add(new Elf(80, "11"));
            object a = mo[0];
            foreach (var item in mo)
            {
                Console.WriteLine(item);
            }
            Prostokat prostokat1 = new Prostokat(20, 10);


            Console.WriteLine(prostokat1.Obwod());
            Console.WriteLine(prostokat1.Pole());
            Student st1 = new Student("Jan", 23, 'w');
            Student st2 = new Student("Anna", 4.5,'w');
            Console.ReadKey();
            
            
        }
    }
}
