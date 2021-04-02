using System;
using System.Collections.Generic;
using System.Text;

namespace EsercizioWeek2
{
    class TransfertMovement: Movement
    {
        public string BancaOrigine { get; set; }
        public string BancaDestinazione { get; set; }

        public TransfertMovement(string bancaOrigine, string bancaDestinazione,int importo)
        {
            BancaOrigine = bancaOrigine;
            BancaDestinazione = bancaDestinazione;
            Importo = importo;
            DataMovimento = DateTime.Now;
        }
    }
}
