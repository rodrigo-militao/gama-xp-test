using System;
using System.Collections.Generic;

namespace gama_xp_test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Saque> saques = new List<Saque>();
            var saque = new Saque(250);
            var salvo = saque.salvar();

            saques.Add(salvo);

            Console.WriteLine(saques);
        }
    }
}
