using Batcaverna.Modelos;
using Batcaverna.Repositorios;
using src.MenuBatCarro;
using src.MenuBatTraje;
using System;

namespace Batcaverna
{
    class Batcave
    {
        static void Main(string[] args)
        {
            var opcaoSelecionada = "";
            var menuBatTraje = new MenuBatTraje();
            var menuBatCarro = new MenuBatCarro();

            Console.WriteLine("Bem-vindo à Batcaverna!");

            while (opcaoSelecionada != "x") 
            {
                opcaoSelecionada = ObterOpçãoDoMenuComUsuário();

                var opcaoSelecionadaBatTraje = "";
                var opcaoSelecionadaBatCarro = "";

                if (opcaoSelecionada == "1")
                {
                    while (opcaoSelecionadaBatTraje != "x")
                    {
                        opcaoSelecionadaBatTraje = ObterOpçãoDoMenuBatTrajeComUsuário();

                        if (opcaoSelecionadaBatTraje == "1") 
                            menuBatTraje.Cadastrar();

                        if(opcaoSelecionadaBatTraje == "2") 
                            menuBatTraje.Quantidade();

                        if(opcaoSelecionadaBatTraje == "3")
                            menuBatTraje.Verificar();

                        if(opcaoSelecionadaBatTraje == "4") 
                            menuBatTraje.Excluir();
                        
                    }
                }

                if ( opcaoSelecionada == "2")
                {
                    while(opcaoSelecionadaBatCarro != "x")
                    {
                        opcaoSelecionadaBatCarro = ObterOpçãoDoMenuBatCarroComUsuário();

                        if (opcaoSelecionadaBatCarro == "1") 
                            menuBatCarro.Cadastrar();

                        if(opcaoSelecionadaBatCarro == "2") 
                            menuBatCarro.Quantidade();

                        if (opcaoSelecionadaBatCarro == "3")
                            menuBatCarro.Verificar();

                        if (opcaoSelecionadaBatCarro == "4") 
                            menuBatCarro.Excluir();
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
            Console.WriteLine("X. Sair");
            
            return Console.ReadLine();

        }
    }
}
