using Batcaverna.Menu;
using Batcaverna.Modelos;
using Batcaverna.Repositorios;
using System;
namespace src.MenuBatCarro
{
    public class MenuBatCarro : Menu
    {
        public var batCarros = new BatCarroRepositorio();
        public override void Cadastrar()
        {
            batCarros.AdicionarCarro(new BatCarro());
            Console.WriteLine($"BatCarro adicionado com sucesso :) \n");
        }

        public override void Excluir()
        {
            var idInformado = "";
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

        public override void Quantidade()
        {
            var quantidadeDeCarros = batCarros.ListarCarros().Count;
            Console.WriteLine($"Quantidade de BatCarros: {quantidadeDeCarros}\n");
        }

        public override void Verificar()
        {
            var idInformado = "";
            Console.WriteLine("Favor, informar o Id: ");
            idInformado = Console.ReadLine();

            var carro = batCarros.ObterPorId(Int64.Parse(idInformado));

            if (carro != null)
                Console.WriteLine($"O BatCarro existe! \n");
            else
                Console.WriteLine("BatCarro não encontrado :/ \n");
        }
    }
}