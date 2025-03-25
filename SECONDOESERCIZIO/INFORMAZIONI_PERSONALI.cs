using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SECONDOESERCIZIO
{
    internal class INFORMAZIONI_PERSONALI
    {
        // Proprietà pubbliche
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Codicefiscale { get; set; }
        public string Indirizzo { get; set; }
        public string Luogonascita { get; set; }

        // Costruttore
        public INFORMAZIONI_PERSONALI(string nome, string cognome, string codicefiscale, string indirizzo, string luogonascita)
        {
            Nome = nome;
            Cognome = cognome;
            Codicefiscale = codicefiscale;
            Indirizzo = indirizzo;
            Luogonascita = luogonascita;
        }

        public string NomeCompleto()
        {
            return $"{Nome} {Cognome}";
        }

        public string IndirizzoFormattato()
        {
            return $"Via {Indirizzo}, {Luogonascita}";
        }

        public bool VerificaCodiceFiscale()
        {
            return Codicefiscale.Length == 16;
        }

        public string StampaInformazioni()
        {
            return $"Mi chiamo {Nome} {Cognome}. Il mio codice fiscale è {Codicefiscale}. Vivo in via {Indirizzo} e sono nato a {Luogonascita}.";
        }

        public string InserisciNome(string nome, string cognome)
        {
            return $"{nome} {cognome}";
        }
    }
}
