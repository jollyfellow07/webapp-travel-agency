using System.ComponentModel.DataAnnotations;

namespace Viaggiatore.Models
{
    public class RichiestaUtente
    {
        [Key]
        public int id { get; set; }
        
        [Required(ErrorMessage = "Il campo nome è obbligatorio")]
        [StringLength(20, ErrorMessage = "Il titolo non può avere più di 60 caratteri")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Il campo cognome è obbligatorio")]
        [StringLength(20, ErrorMessage = "Il titolo non può avere più di 60 caratteri")]
        public string cognome { get; set; }

        [Required(ErrorMessage = "Il campo email è obbligatorio")]
        [StringLength(20, ErrorMessage = "Il titolo non può avere più di 60 caratteri")]
        public string email { get; set; }

        [Required(ErrorMessage = "Il campo messaggio è obbligatorio")]
        public string messaggio { get; set; }

        public List<Pacchetto> pacchetti { get; set; }

        public RichiestaUtente()
        {

        }
        public RichiestaUtente(string nome, string cognome, string email, string messaggio)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.email = email;
            this.messaggio = messaggio;
        }

    }
}
