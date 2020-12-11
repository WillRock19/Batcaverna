using src.Interface;

namespace Batcaverna.Modelos.Acessorios
{
    public class Capa : IEntidadeCadastral
    {
        public long Id { get; set; }
        public bool PodeEnrijecer { get; set; }
        public bool ResistenteÀCorte { get; set; }
        public bool ResistenteÀBalas { get; set; }
        public string CorPrincipal { get; set; }
        public bool BocaÀMostra { get; set; }

        public Capa()
        {
            CorPrincipal = "Preto";
            PodeEnrijecer = true;
            ResistenteÀBalas = true;
        }
    }
}
