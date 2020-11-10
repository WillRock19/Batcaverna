namespace Batcaverna.Modelos.Acessorios
{
    public class Capuz
    {
        public bool PossuiVisãoNoturna { get; set; }
        public bool ResistenteÀCorte { get; set; }
        public bool ResistenteÀBalas { get; set; }
        public string CorPrincipal { get; set; }
        public bool BocaÀMostra { get; set; }

        public Capuz()
        {
            CorPrincipal = "Preto";
            BocaÀMostra = true;
        }
    }
}
