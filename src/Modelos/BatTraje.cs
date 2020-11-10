using Batcaverna.Modelos.Acessorios;

namespace Batcaverna.Modelos
{
    public class BatTraje
    {
        public long Id { get; set; }
        public bool ResistenteÀCorte { get; set; }
        public bool ResistenteÀBalas { get; set; }
        public string CorPrincipal { get; set; }
        public Capuz Capuz { get; set; }
    }
}
