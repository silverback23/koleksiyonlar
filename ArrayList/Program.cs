using System;
using System.Collections;

namespace ArrayListt
{
    class Program
    {
        static void Main(string[] args)
        {
            //system.Collections namesapace

            ArrayList liste= new ArrayList();
            liste.Add("ayşe");
            liste.Add(2);

            //içerisindeki elamanlara erişim

            Console.WriteLine(liste[1]);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}
