namespace Viaggiatore.Models
{
    public class RichiesteUtentiPacchetti
    {
        public RichiestaUtente richiesteUtenti { get; set; }
        public List<Pacchetto>? pacchetti { get; set; }
    }
}
