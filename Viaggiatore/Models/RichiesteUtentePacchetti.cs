namespace Viaggiatore.Models
{
    public class RichiesteUtentePacchetti
    {
        public Pacchetto pacchetti { get; set; }
        public List<RichiestaUtente>? richiesteUtenti { get; set; }
    }
}
