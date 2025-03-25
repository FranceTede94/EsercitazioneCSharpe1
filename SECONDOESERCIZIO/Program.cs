namespace SECONDOESERCIZIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INFORMAZIONI_PERSONALI info = new INFORMAZIONI_PERSONALI
               (
               "Francesco", "Giaffreda", "FGBFNC87E05B945J", "Via Napoli, 55", "Gallipoli"
               );

            Console.WriteLine(info.Luogonascita);

            info.Luogonascita = "Casarano";

            Console.WriteLine(info.Luogonascita);

            Console.WriteLine(info.NomeCompleto());

            Console.WriteLine(info.IndirizzoFormattato());

            Console.WriteLine(info.VerificaCodiceFiscale());

            Console.WriteLine(info.StampaInformazioni());

            info.InserisciNome("Francesco", "Greco");
            Console.WriteLine(info.InserisciNome("Francesco", "Greco"));

        }
    }
}
