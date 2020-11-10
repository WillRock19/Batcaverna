using Batcaverna.Modelos;
using System.Collections.Generic;

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
            foreach(var traje in _listaDeTrajes) 
            {
                if (traje.Id == id)
                    return traje;
            }

            return null;
        }
    }
}
