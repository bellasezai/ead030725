using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ead030725
{
    public class Elefante : Animal
    {
         public Elefante(string nome, int idade) : base(nome, idade) { }

    public override void EmitirSom()
    {
        Console.WriteLine("O elefante trombeta!");
    }
    }
}