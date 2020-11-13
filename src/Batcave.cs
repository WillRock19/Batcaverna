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
            var opcaoSelecionadaBatTraje = "";
            var opcaoSelecionadaBatCarro = "";
            var batTrajes = new BatTrajeRepositorio();
            var batCarros = new BatCarroRepositorio();
            var idInformado = "";

            Console.WriteLine("Bem-vindo à Batcaverna!");

            while (opcaoSelecionada != "x") 
            {
                opcaoSelecionada = ObterOpçãoDoMenuComUsuário();

                if (opcaoSelecionada == "1")
                {
                    opcaoSelecionadaBatTraje = ObterOpçãoDoMenuBatTrajeComUsuário();

                    while (opcaoSelecionadaBatTraje != "x")
                    {

                        if (opcaoSelecionadaBatTraje == "1") 
                        {
                            batTrajes.AdicionarTraje(new BatTraje());
                            Console.WriteLine($"BatTraje adicionado com sucesso :) \n");
                        }

                        if(opcaoSelecionadaBatTraje == "2") 
                        {
                            var quantidadeDeTrajes = batTrajes.ListarTrajes().Count;
                            Console.WriteLine($"Quantidade de BatTrajes: {quantidadeDeTrajes}\n");
                        }

                        if (opcaoSelecionadaBatTraje == "3")
                        {
                            Console.WriteLine("Favor, informar o Id: ");
                            idInformado = Console.ReadLine();

                            var traje = batTrajes.ObterPorId(Int64.Parse(idInformado));

                            if (traje != null)
                                Console.WriteLine($"O BatTraje existe! \n");
                            else
                                 Console.WriteLine("BatTraje não encontrado :/ \n");
                        }

                        if (opcaoSelecionadaBatTraje == "4") 
                        {
                            Console.WriteLine("Favor, informar o Id: ");
                            idInformado = Console.ReadLine();

                            var traje = batTrajes.ObterPorId(Int64.Parse(idInformado));

                            if (traje != null)
                            {
                                batTrajes.ExcluirTraje(batTrajes.ObterPorId(Int64.Parse(idInformado)));
                                Console.WriteLine($"BatTraje excluido com sucesso :) \n");
                            }
                       
                            else
                                Console.WriteLine("BatTraje não encontrado :/ \n");

                        }

                        if (opcaoSelecionadaBatTraje == "0")
                            ObterOpçãoDoMenuComUsuário();
                    }
                }

                if ( opcaoSelecionada == "2")
                {

                    var opcaoSelecionadaBatCarro = "";
                    opcaoSelecionadaBatCarro = ObterOpçãoDoMenuBatCarroComUsuário();

                    while(opcaoSelecionadaBatCarro != "x")
                    {

                        if (opcaoSelecionadaBatCarro == "1") 
                        {
                            batCarros.AdicionarCarro(new BatCarro());
                            Console.WriteLine($"BatCarro adicionado com sucesso :) \n");
                        }

                        if(opcaoSelecionadaBatCarro == "2") 
                        {
                            var quantidadeDeCarros = batCarros.ListarCarros().Count;
                            Console.WriteLine($"Quantidade de BatCarros: {quantidadeDeCarros}\n");
                        }

                        if (opcaoSelecionadaBatCarro == "3")
                        {
                            Console.WriteLine("Favor, informar o Id: ");
                            idInformado = Console.ReadLine();

                            var carro = batCarros.ObterPorId(Int64.Parse(idInformado));

                            if (carro != null)
                                Console.WriteLine($"O BatCarro existe! \n");
                            else
                                Console.WriteLine("BatCarro não encontrado :/ \n");
                        }

                        if (opcaoSelecionadaBatCarro == "4") 
                        {
                            Console.WriteLine("Favor, informar o Id: ");
                            idInformado = Console.ReadLine();

                            var carro = batCarros.ObterPorId(Int64.Parse(idInformado));

                            if (carro != null)
                            {
                                batCarros.ExcluirCarro(batCarros.ObterPorId(Int64.Parse(idInformado)));
                                Console.WriteLine($"BatCarro excluido com sucesso :) \n");
                            }
                            else
                                Console.WriteLine("BatCarro não encontrado :/ \n");
                    
                        }

                        if (opcaoSelecionadaBatCarro == "0")
                        ObterOpçãoDoMenuComUsuário();
                    }
                }
            }
        }

        static string ObterOpçãoDoMenuComUsuário() 
        {
            
                Console.WriteLine("O que deseja acessar?");
                Console.WriteLine("1. BatTraje");
                Console.WriteLine("2. BatCarro");
                Console.WriteLine("X. Sair");
            

            return Console.ReadLine();
        }
        static string ObterOpçãoDoMenuBatTrajeComUsuário()
        {
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1. Cadastrar BatTraje");
            Console.WriteLine("2. Quantidade de BatTrajes");
            Console.WriteLine("3. Verificar se BatTraje existe");
            Console.WriteLine("4. Excluir BatTraje");
            Console.WriteLine("0. Voltar ao menu inicial");
            Console.WriteLine("X. Sair");

            return Console.ReadLine();
        }
        static string ObterOpçãoDoMenuBatCarroComUsuário()
        {
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1. Cadastrar BatCarro");
            Console.WriteLine("2. Quantidade de BatCarros");
            Console.WriteLine("3. Verificar se BatCarro existe");
            Console.WriteLine("4. Excluir Batcarro");
            Console.WriteLine("0. Voltar ao menu inicial");
            Console.WriteLine("X. Sair");

            return Console.ReadLine();

        }
    }
}
