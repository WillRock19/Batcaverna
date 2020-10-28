using Batcaverna.Modelos;
using System.Collections.Generic;

namespace Batcaverna.Repositorios
{
    public class BatTrajeRepositorio
    {
        private List<BatTraje> _listaDeTrajes;

        public BatTrajeRepositorio()
        {
            _listaDeTrajes = new List<BatTraje>();
        }

        public void AdicionarTraje(BatTraje traje) 
        {
            _listaDeTrajes.Add(traje);
        }


        public List<BatTraje> ListarTrajes() 
        {
            return _listaDeTrajes;
        }
    }
}
