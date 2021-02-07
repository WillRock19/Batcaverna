using Batcaverna.Menu;
using Batcaverna.Modelos.Acessorios;
using Batcaverna.Repositorios;
using System;
namespace src.MenuCapuz
{
    public class MenuCapuz : MenuBase<Capuz>
    {
        public MenuCapuz() : base(typeof(Capuz).Name, new BatCapuzRepositorio()){}
        public override void Cadastrar()
        {
            _baseRepositorio.Adicionar(new Capuz());
            Console.WriteLine($"{typeof(Capuz).Name} adicionado com sucesso :) \n");
        }

   }
}