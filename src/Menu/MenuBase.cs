using System;
using src.Interface;
using src.Repositorios;

namespace Batcaverna.Menu
{
    public abstract class MenuBase<T> where T : IEntidadeCadastral
    {
        private string _entidade;
        protected BatBaseRepositorio<T> _baseRepositorio;

        protected MenuBase(string entidade,BatBaseRepositorio<T> baseRepositorio)
        {
            _entidade=entidade;
            _baseRepositorio=baseRepositorio;
        }

        public abstract void Cadastrar();

        public void Excluir()
        {
            var idInformado = "";
            Console.WriteLine("Favor, informar o Id: ");
            idInformado = Console.ReadLine();

            var valorInformado = _baseRepositorio.ObterPorId(Int64.Parse(idInformado));

            if (valorInformado != null)
            {
                _baseRepositorio.Excluir(_baseRepositorio.ObterPorId(Int64.Parse(idInformado)));
                Console.WriteLine($"{_entidade} excluido com sucesso :) \n");
            }
            else
            Console.WriteLine($"{_entidade} não encontrado :/ \n");
        }

        public void Quantidade()
        {
            var quantidade = _baseRepositorio.Listar().Count;
            Console.WriteLine($"Quantidade de {_entidade}: {quantidade}\n");
        }

        public void Verificar()
        {
            var idInformado = "";
            Console.WriteLine("Favor, informar o Id: ");
            idInformado = Console.ReadLine();

            var valorInformado = _baseRepositorio.ObterPorId(Int64.Parse(idInformado));

            if (valorInformado != null)
                Console.WriteLine($"O {_entidade} existe! \n");
            else
                Console.WriteLine($"{_entidade} não encontrado :/ \n");
        }
 
    }
}