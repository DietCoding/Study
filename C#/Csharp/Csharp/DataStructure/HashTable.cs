using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

class HashTable
{
    static void main( string[] args)
    {
        Hashtable ht = new Hashtable();
        //hashtable은 key,value값 모두 object값을 받아들인다.
        ht.Add("Je", "Ju wan");
        ht.Add("Kim", "Jin ho");

        Console.WriteLine(ht["Je"]);
    }
}

