using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ead030725
{
    public class Leao : Animal
    {
        public Leao(string nome, int idade) : base(nome, idade) { }

    public override void EmitirSom()
    {
        Console.WriteLine("O leão ruge!");
    }
    }
}