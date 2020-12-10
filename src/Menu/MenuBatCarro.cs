using Batcaverna.Menu;
using Batcaverna.Modelos;
using Batcaverna.Repositorios;
using src.Repositorios;
using System;
namespace src.MenuBatCarro
{
    public class MenuBatCarro : MenuBase<BatCarro>
    {
        public MenuBatCarro() : base(typeof(BatCarro).Name, new BatCarroRepositorio()){}
        public override void Cadastrar()
        {
            _baseRepositorio.Adicionar(new BatCarro());
            Console.WriteLine($"{typeof(BatCarro).Name} adicionado com sucesso :) \n");
        }

   }
}