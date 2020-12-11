using Batcaverna.Menu;
using Batcaverna.Modelos.Acessorios;
using Batcaverna.Repositorios;
using System;
namespace src.MenuLuvas
{
    public class MenuLuvas : MenuBase<Luvas>
    {
        public MenuLuvas() : base(typeof(Luvas).Name, new BatLuvasRepositorio()){}
        public override void Cadastrar()
        {
            _baseRepositorio.Adicionar(new Luvas());
            Console.WriteLine($"{typeof(Luvas).Name} adicionado com sucesso :) \n");
        }

   }
}