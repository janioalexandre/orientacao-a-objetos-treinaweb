using System;

namespace Personagens
{
    public class Mago : Personagem
    {
        public int Magia { get; set; } 

        public Mago(string nome, int vida, int magia) : base(nome, vida)
        {
            Magia = magia;  
        }

        public override void Atacar()
        {
            Console.WriteLine($"{ Nome } atacou com magia.");
        }  

        public override void AtacarEspecial()
        {
            Console.WriteLine($"{ Nome } Atacou Especial com magia.");
        }
    }
}