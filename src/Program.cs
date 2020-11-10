using Batcaverna.Modelos;
using Batcaverna.Repositorios;
using System;

namespace Batcaverna
{
    class Program
    {
        static void Main(string[] args)
        {
            var opcaoSelecionada = "";
            var repositorio = new BatTrajeRepositorio();

            Console.WriteLine("Bem-vindo à Batcaverna!");

            while (opcaoSelecionada != "x") 
            {
                opcaoSelecionada = ObterOpçãoDoMenuComUsuário();

                if (opcaoSelecionada == "1") 
                {
                    repositorio.AdicionarTraje(new BatTraje());
                    Console.WriteLine($"Traje adicionado com sucesso :) \n");
                }

                if(opcaoSelecionada == "2") 
                {
                    var quantidadeDeTrajes = repositorio.ListarTrajes().Count;
                    Console.WriteLine($"Quantidade de trajes: {quantidadeDeTrajes}\n");
                }


                if (opcaoSelecionada == "3")
                {
                    Console.WriteLine("Favor, informar o Id: ");
                    var idInformado = Console.ReadLine();

                    var traje = repositorio.ObterPorId(Int64.Parse(idInformado));

                    if (traje != null)
                        Console.WriteLine($"O traje existe! \n");
                    else
                        Console.WriteLine("Traje não encontrado :/ \n");
                }
            }
        }

        static string ObterOpçãoDoMenuComUsuário() 
        {
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1. Cadastrar BatTraje");
            Console.WriteLine("2. Quantidade de BatTrajes");
            Console.WriteLine("3. Verificar se traje existe");
            Console.WriteLine("X. Sair");

            return Console.ReadLine();
        }
    }
}
