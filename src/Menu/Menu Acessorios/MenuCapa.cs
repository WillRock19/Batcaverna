using Batcaverna.Menu;
using Batcaverna.Modelos.Acessorios;
using Batcaverna.Repositorios;
using System;
namespace src.MenuCapa
{
    public class MenuCapa : MenuBase<Capa>
    {
        public MenuCapa() : base(typeof(Capa).Name, new BatCapaRepositorio()){}
        public override void Cadastrar()
        {
            _baseRepositorio.Adicionar(new Capa());
            Console.WriteLine($"{typeof(Capa).Name} adicionado com sucesso :) \n");
        }

   }
}