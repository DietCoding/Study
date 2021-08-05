using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Lambda
{
    delegate void Junsik(int i);   

    static void main(string[] args)
    {
        Junsik junsik = null;
        /*
         junsik+= new System.EventHandler(add);
        private void add(int a)
        {
            Console.WriteLine(++a);
        };
        */
        /*
         junsik+= delegate(int a)
        {
            Console.WriteLine(++a);
        };
        */
        junsik += a => Console.WriteLine(++a);
        junsik(100);
    }
}

