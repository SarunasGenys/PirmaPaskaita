using System;
using System.Transactions;

namespace PirmaPaskaita
{ 
    public class Program
    {
        public static void Main(string[] args)
        {
            string kintamasis = "Sveiki studentai!";

            var x = kintamasis.Where(e => e.Equals("e"));
            
        }
    }
}