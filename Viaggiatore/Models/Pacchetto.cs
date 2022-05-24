using System.ComponentModel.DataAnnotations;

namespace Viaggiatore.Models
{
    public class Pacchetto
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Il campo titolo è obbligatorio")]
        [StringLength(20, ErrorMessage = "Il titolo non può avere più di 20 caratteri")]
        public string titolo { get; set; }

        [Required(ErrorMessage = "Il campo descrizione è obbligatorio")]
        public string descrizione { get; set; }

        [Required(ErrorMessage = "Il campo immagine è obbligatorio")]
        public string immagine { get; set; }

        [Required(ErrorMessage = "Il campo prezzo è obbligatorio")]
        [Range(1, 2000, ErrorMessage = "Il valore inserito non è corretto")]
        public double Prezzo { get; set; }

        public List<RichiestaUtente> richiesteUtenti { get; set; }
        public Pacchetto()
        {

        }
        public Pacchetto(string titolo, string descrizione, string immagine, double prezzo)
        {
            this.titolo = titolo;
            this.descrizione = descrizione;
            this.immagine = immagine;
            this.Prezzo = prezzo;
        }


    }
}
