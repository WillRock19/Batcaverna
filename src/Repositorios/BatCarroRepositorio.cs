using Batcaverna.Modelos;
using System.Collections.Generic;
using System.Linq;

namespace Batcaverna.Repositorios
{
    public class BatCarroRepositorio
    {
        private long _contadorRegistros;
        private List<BatCarro> _listaDeCarros;

        public BatCarroRepositorio()
        {
            _listaDeCarros = new List<BatCarro>();
            _contadorRegistros = _listaDeCarros.Count;
        }

        public void AdicionarCarro(BatCarro carro) 
        {
            carro.Id = _contadorRegistros + 1;

            _listaDeCarros.Add(carro);
            _contadorRegistros++;
        }

        public List<BatCarro> ListarCarros() 
        {
            return _listaDeCarros;
        }

        public BatCarro ObterPorId(long id) 
        {

          var carro = _listaDeCarros.FirstOrDefault(batCarro => batCarro.Id == id);
            return carro;
        }
        public void ExcluirCarro(BatCarro carro) 
        {
            _listaDeCarros.Remove(carro);
        }
    }
}
