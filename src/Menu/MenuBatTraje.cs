using Batcaverna.Menu;
using Batcaverna.Modelos;
using Batcaverna.Repositorios;
using System;
namespace src.MenuBatTraje
{
    public class MenuBatTraje : Menu
    {
        public var batTrajes = new BatTrajeRepositorio();
        public override void Cadastrar()
        {
            batTrajes.AdicionarTraje(new BatTraje());
            Console.WriteLine($"BatTraje adicionado com sucesso :) \n");
        }

        public override void Excluir()
        {
            var idInformado = "";
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

        public override void Quantidade()
        {
            var quantidadeDeTrajes = batTrajes.ListarTrajes().Count;
            Console.WriteLine($"Quantidade de BatTrajes: {quantidadeDeTrajes}\n");
        }

        public override void Verificar()
        {
            var idInformado = "";
            Console.WriteLine("Favor, informar o Id: ");
            idInformado = Console.ReadLine();

            var traje = batTrajes.ObterPorId(Int64.Parse(idInformado));

            if (traje != null)
                 Console.WriteLine($"O BatTraje existe! \n");
            else
                 Console.WriteLine("BatTraje não encontrado :/ \n");
        }
    }
}