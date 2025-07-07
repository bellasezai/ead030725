using System;
using System.Collections.Generic;

using ead030725;
public class Programa
{
    public static void Main()
    {
        List<Animal> animais = new List<Animal>
        {
            new Leao("Simba", 5),
            new Elefante("Dumbo", 10)
        };

        foreach (Animal animal in animais)
        {
            animal.ExibirInfo();
            animal.EmitirSom();
            Console.WriteLine();
        }
    }
}