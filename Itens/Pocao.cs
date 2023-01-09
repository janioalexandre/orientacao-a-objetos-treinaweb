using System;

namespace Itens
{
    public class Pocao : Item, IConsumivel
    {
        public int Vida { get; set; }

        public Pocao(string nome, int x, int y, int vida) : base(nome, x, y)
        {
            Vida = vida;
        }

        public void Consumir()
        {
            Console.WriteLine("Poção consumida.");
        }
    }
}