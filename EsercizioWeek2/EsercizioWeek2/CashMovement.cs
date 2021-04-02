using System;
using System.Collections.Generic;
using System.Text;

namespace EsercizioWeek2
{
    class CashMovement : Movement
    {
        public string Esecutore { get; set; }
        public CashMovement(string esecutore ,int importo)
        {
            Esecutore = esecutore;
            Importo = importo;
            DataMovimento = DateTime.Now;
        }
    }
}
