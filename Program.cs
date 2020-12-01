using System;

namespace Atributos_e_métodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem objetoPersonagem1 = new Personagem();

            objetoPersonagem1.nome = "Seiya";
            objetoPersonagem1.idade = 13;
            objetoPersonagem1.armadura = "Armadura de Pégaso";
        
            Personagem objetoPersonagem2 = new Personagem();

            objetoPersonagem2.nome = "Ikki";
            objetoPersonagem2.idade = 15;
            objetoPersonagem2.armadura = "Armadura de Fenix";

            Console.WriteLine($"Personagem 1 = {objetoPersonagem1.nome}");
            Console.WriteLine($"Personagem 2 = {objetoPersonagem2.nome}");
        }    
        
            
    }
}
