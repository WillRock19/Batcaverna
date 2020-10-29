using Batcaverna.Repositorios;
using System;

namespace Batcaverna
{
    class Program
    {
        static void Main(string[] args)
        {
            var opcaoSelecionada = "";
            Console.WriteLine("Bem-vindo à Batcaverna!");

            while (opcaoSelecionada != "x") 
            {
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine("1. Verificar quantidade de BatTrajes");
                Console.WriteLine("X. Sair");

                opcaoSelecionada = Console.ReadLine();

                if(opcaoSelecionada == "1") 
                {
                    var repositorio = new BatTrajeRepositorio();
                    var quantidadeDeTrajes = repositorio.ListarTrajes().Count;
                    Console.WriteLine($"Quantidade de trajes: {quantidadeDeTrajes}\n");
                }
            }
        }
    }
}
