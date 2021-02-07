using Batcaverna.Modelos.Acessorios;
using src.Interface;

namespace Batcaverna.Modelos
{
    public class BatTraje : IEntidadeCadastral
    {
        public long Id { get; set; }
        public bool ResistenteÀCorte { get; set; }
        public bool ResistenteÀBalas { get; set; }
        public string CorPrincipal { get; set; }
        public Capuz Capuz { get; set; }
        public Capa Capa { get; set; }
        public Cinto Cinto { get; set; }
        public Luvas Luvas { get; set; }
    }
}
