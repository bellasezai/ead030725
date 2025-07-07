using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ead030725
{
    public abstract class Animal
    {
        
    public string Nome { get; set; }
    public int Idade { get; set; }

 
    public Animal(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public virtual void EmitirSom()
    {
        Console.WriteLine("O animal emite um som.");
    }

    public virtual void ExibirInfo()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
    }
}
    }
