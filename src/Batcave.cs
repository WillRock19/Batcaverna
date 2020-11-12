using Batcaverna.Modelos;
using Batcaverna.Repositorios;
using System;

namespace Batcaverna
{
    class Batcave
    {
        static void Main(string[] args)
        {
            var opcaoSelecionada = "";
            var batTrajes = new BatTrajeRepositorio();
            var batCarros = new BatCarroRepositorio();
            var idInformado = "";

            Console.WriteLine("Bem-vindo à Batcaverna!");

            while (opcaoSelecionada != "x") 
            {
                opcaoSelecionada = ObterOpçãoDoMenuComUsuário();

                if (opcaoSelecionada == "1") 
                {
                    batTrajes.AdicionarTraje(new BatTraje());
                    Console.WriteLine($"BatTraje adicionado com sucesso :) \n");
                }

                if(opcaoSelecionada == "2") 
                {
                    var quantidadeDeTrajes = batTrajes.ListarTrajes().Count;
                    Console.WriteLine($"Quantidade de BatTrajes: {quantidadeDeTrajes}\n");
                }


                if (opcaoSelecionada == "3")
                {
                    Console.WriteLine("Favor, informar o Id: ");
                    idInformado = Console.ReadLine();

                    var traje = batTrajes.ObterPorId(Int64.Parse(idInformado));

                    if (traje != null)
                        Console.WriteLine($"O BatTraje existe! \n");
                    else
                        Console.WriteLine("BatTraje não encontrado :/ \n");
                }

                if (opcaoSelecionada == "4") 
                {
                    Console.WriteLine("Favor, informar o Id: ");
                    idInformado = Console.ReadLine();

                    batTrajes.ExcluirTraje(batTrajes.ObterPorId(Int64.Parse(idInformado)));
                    Console.WriteLine($"BatTraje excluido com sucesso :) \n");
                }

                if (opcaoSelecionada == "5") 
                {
                    batCarros.AdicionarCarro(new BatCarro());
                    Console.WriteLine($"BatCarro adicionado com sucesso :) \n");
                }

                if(opcaoSelecionada == "6") 
                {
                    var quantidadeDeCarros = batCarros.ListarCarros().Count;
                    Console.WriteLine($"Quantidade de BatCarros: {quantidadeDeCarros}\n");
                }


                if (opcaoSelecionada == "7")
                {
                    Console.WriteLine("Favor, informar o Id: ");
                    idInformado = Console.ReadLine();

                    var carro = batCarros.ObterPorId(Int64.Parse(idInformado));

                    if (carro != null)
                        Console.WriteLine($"O BatCarro existe! \n");
                    else
                        Console.WriteLine("BatCarro não encontrado :/ \n");
                }
                if (opcaoSelecionada == "8") 
                {
                    Console.WriteLine("Favor, informar o Id: ");
                    idInformado = Console.ReadLine();

                    batCarros.ExcluirCarro(batCarros.ObterPorId(Int64.Parse(idInformado)));
                    Console.WriteLine($"BatCarro excluido com sucesso :) \n");
                }
            }
        }

        static string ObterOpçãoDoMenuComUsuário() 
        {
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1. Cadastrar BatTraje");
            Console.WriteLine("2. Quantidade de BatTrajes");
            Console.WriteLine("3. Verificar se BatTraje existe");
            Console.WriteLine("4. Excluir BatTraje");
            Console.WriteLine("5. Cadastrar BatCarro");
            Console.WriteLine("6. Quantidade de BatCarros");
            Console.WriteLine("7. Verificar se BatCarro existe");
            Console.WriteLine("8. Excluir Batcarro");
            Console.WriteLine("X. Sair");

            return Console.ReadLine();
        }
    }
}
