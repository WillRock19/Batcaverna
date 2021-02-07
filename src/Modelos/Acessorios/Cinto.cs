using src.Interface;

namespace Batcaverna.Modelos.Acessorios
{
    public class Cinto : IEntidadeCadastral
    {
        public long Id { get; set; }
        public int QuantidadeDeBolsos { get; set; }
        public bool ResistenteÀCorte { get; set; }
        public string CorPrincipal { get; set; }
        
        public Cinto()
        {
            CorPrincipal = "Preto";
            QuantidadeDeBolsos = 4;
            ResistenteÀCorte = true;
        }
    }
}
