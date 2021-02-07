using src.Interface;

namespace Batcaverna.Modelos
{
    public class BatCarro : IEntidadeCadastral
    {
        public long Id { get; set; }
        public bool ResistenteÀCorte { get; set; }
        public bool ResistenteÀBalas { get; set; }
        public string CorPrincipal { get; set; }
        public bool RodasResistenteÀBalas { get; set; }
        public bool RodasResistenteÀCorte { get; set; }    
        public bool LigarMotor { get; set; }
        public void AtivarDefesas()
        {
            ResistenteÀBalas = true;
            ResistenteÀCorte =true;
            RodasResistenteÀBalas = true;
            RodasResistenteÀCorte = true;

        }    
    }
}
