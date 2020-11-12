using Batcaverna.Modelos;
using System.Collections.Generic;
using System.Linq;

namespace Batcaverna.Repositorios
{
    public class BatTrajeRepositorio
    {
        private long _contadorRegistros;
        private List<BatTraje> _listaDeTrajes;

        public BatTrajeRepositorio()
        {
            _listaDeTrajes = new List<BatTraje>();
            _contadorRegistros = _listaDeTrajes.Count;
        }

        public void AdicionarTraje(BatTraje traje) 
        {
            traje.Id = _contadorRegistros + 1;

            _listaDeTrajes.Add(traje);
            _contadorRegistros++;
        }


        public List<BatTraje> ListarTrajes() 
        {
            return _listaDeTrajes;
        }

        public BatTraje ObterPorId(long id) 
        {
            var traje = _listaDeTrajes.FirstOrDefault(batTraje => batTraje.Id == id);
            return traje;
        }
        public void ExcluirTraje(BatTraje traje) 
        {
            _listaDeTrajes.Remove(traje);
        }
        public void ExcluirTraje(BatTraje traje) 
        {
            _listaDeTrajes.Remove(traje);
        }
    }
}
