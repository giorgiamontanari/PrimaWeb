using System;
using System.ComponentModel.DataAnnotations;

namespace Montanari.Giorgia._5H.PrimaWeb.Models
{
    public class Prenotazione
    {
        public int PrenotazioneId {get; set;}
        public string Nome { get; set; }

        [Required(ErrorMessage="Inserisci una Email valida")]
        [EmailAddress]
        public string Email { get; set; }
        public DateTime Data {get; set;}

        
    }
}