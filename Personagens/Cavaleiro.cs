using System;

namespace Personagens
{
    public class Cavaleiro : Personagem
    {
        public Cavaleiro(string nome, int vida) : base(nome, vida)
        {
        }

        public override void Atacar()
        {
            Console.WriteLine($"{ Nome } atacou com espada.");
        }  

        public override void AtacarEspecial()
        {
            Console.WriteLine($"{ Nome } Atacou Especial com espada.");
        }
    }
}