using System.Collections.Generic;

namespace Batcaverna.Repositorio
{
    public class TrajesRepositorio
    {
        private List<string> _listaDeTrajes;

        public TrajesRepositorio()
        {
            _listaDeTrajes = new List<string>();
        }

        public void AdicionarTraje(string traje) 
        {
            _listaDeTrajes.Add(traje);
        }

    }
}
