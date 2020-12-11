using System;
using System.Collections.Generic;
using System.Text;

namespace Batcaverna.Servicos
{
    public class MenuService
    {
        public void ExecutarMenuPrincipal() 
        {
            var sairMenu = false;

            while (!sairMenu) 
            {
                Console.WriteLine("O que deseja acessar?");

                var opçõesMenuPrincipal = GerarOpçõesMenuPrincipal();
                var opçãoSelecionada = ObterOpçãoDoMenu(opçõesMenuPrincipal);

                if (!OpçãoValida(opçãoSelecionada, opçõesMenuPrincipal)) 
                {
                    Console.WriteLine("Opcao inválida, favor selecione outra.");
                    continue;
                }

                var opçõesSubMenu = GerarOpçõesSubmenu(opçõesMenuPrincipal.GetValueOrDefault(opçãoSelecionada));
                var opçãoSubmenuSelecionada = ObterOpçãoDoMenu(opçõesSubMenu);


            }
        }

        private void ExecutarOpção(string opção) 
        {
            switch (opção) 
            {
                case "1":
                    return;
                case "2":
                    return;
                case "3":
                    return;
                case "4":
                    return;
            }
        }

        private string ObterOpçãoDoMenu(Dictionary<string, string> opcoesMenu)
        {
            foreach (var opcao in opcoesMenu)
                Console.WriteLine($"{opcao.Key}. {opcao.Value}");

            return Console.ReadLine();
        }

        private bool OpçãoValida(string opcaoSelecionada, Dictionary<string, string> opcoesMenu) 
        {
            return opcoesMenu.ContainsKey(opcaoSelecionada);
        }

        private Dictionary<string, string> GerarOpçõesMenuPrincipal()
        {
            return new Dictionary<string, string>()
            {
                { "1", "BatTraje" },
                { "2", "BatCarro" },
                { "X", "Sair" }
            };
        }

        private Dictionary<string, string> GerarOpçõesSubmenu(string nomeEntidade) 
        {
            return new Dictionary<string, string>()
            {
                { "1", $"Cadastrar {nomeEntidade}" },
                { "2", $"Quantidade {nomeEntidade}" },
                { "3", $"Verificar {nomeEntidade}" },
                { "4", $"Excluir {nomeEntidade}" },
                { "X", "Sair" }
            };
        }
    }
}
