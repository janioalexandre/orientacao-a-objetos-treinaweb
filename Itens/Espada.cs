using System;

namespace Itens
{
    public class Espada : Item, Icolecionavel
    {
        public int Dano { get; set; }

        public Espada(string nome, int x, int y, int dano) : base(nome, x, y)
        {
            Dano = dano;
        }

        public void Colecionar()
        {
            Console.WriteLine("Espada adicionada ao invetário.");
        }
    }
}