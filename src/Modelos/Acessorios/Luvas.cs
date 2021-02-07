using src.Interface;

namespace Batcaverna.Modelos.Acessorios
{
    public class Luvas : IEntidadeCadastral
    {
        public long Id { get; set; }
        public bool Aderente { get; set; }
        public bool LancadorDeDardos { get; set; }
        public bool LaminasAngulares { get; set; }
        public string CorPrincipal { get; set; }
        public bool ResistenciaACortes { get; set; }

        public Luvas()
        {
            CorPrincipal = "Preto";
            LaminasAngulares = true;
            ResistenciaACortes = true;
        }
    }
}
