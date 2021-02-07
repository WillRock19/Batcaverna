using Batcaverna.Menu;
using Batcaverna.Modelos.Acessorios;
using Batcaverna.Repositorios;
using System;
namespace src.MenuCinto
{
    public class MenuCinto : MenuBase<Cinto>
    {
        public MenuCinto() : base(typeof(Cinto).Name, new BatCintoRepositorio()){}
        public override void Cadastrar()
        {
            _baseRepositorio.Adicionar(new Cinto());
            Console.WriteLine($"{typeof(Cinto).Name} adicionado com sucesso :) \n");
        }

   }
}