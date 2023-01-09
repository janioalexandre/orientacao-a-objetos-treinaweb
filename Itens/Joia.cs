using System;

namespace Itens
{
    public class Joia : Item, Icolecionavel, IConsumivel
    {
        public int Valor { get; set; }

        public Joia(string nome, int x, int y, int valor) : base(nome, x, y)
        {
            Valor = valor;
        }

        public void Consumir()
        {
            Console.WriteLine("Joia consumida.");
        }

        public void Colecionar()
        {
            Console.WriteLine("Joia colecionada.");
        }
    }
}