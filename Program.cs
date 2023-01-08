﻿using Contas;
using RH;

namespace orientacao_a_objetos_treinaweb
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operações com a Classe Conta
            var conta = new Conta();
            Console.WriteLine(conta.ExibirExtrato());

            conta.Depositar(1000);
            Console.WriteLine(conta.ExibirExtrato());

            conta.Sacar(100);
            Console.WriteLine(conta.ExibirExtrato());

            conta.RealizarEmprestimo(1000, 10);  
            Console.WriteLine(conta.ExibirExtrato());

            // Operações com a Classe Funcionario
            var funcionario = new Funcionario("Janio Alexandre", "065.065.065-06");
            funcionario.CPF = "111.111.111-11";
            Console.WriteLine(funcionario.CPF);
        }
    }
}