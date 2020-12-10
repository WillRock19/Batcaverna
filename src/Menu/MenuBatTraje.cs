using Batcaverna.Menu;
using Batcaverna.Modelos;
using Batcaverna.Repositorios;
using src.Repositorios;
using System;
namespace src.MenuBatTraje
{
    public class MenuBatTraje : MenuBase<BatTraje>
    {
        public MenuBatTraje() : base(typeof(BatTraje).Name,new BatTrajeRepositorio())
        {
        }

        public override void Cadastrar()
        {
            _baseRepositorio.Adicionar(new BatTraje());
            Console.WriteLine($"{typeof(BatTraje).Name} adicionado com sucesso :) \n");
        }
    }
}