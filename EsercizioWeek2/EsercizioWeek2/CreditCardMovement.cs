using System;
using System.Collections.Generic;
using System.Text;

namespace EsercizioWeek2
{
    class CreditCardMovement: Movement
    {
        public int NumeroCarta { get; set; }
        public TipoCarta Tipo { get; set; }

        public CreditCardMovement(int numeroCarta, TipoCarta tipo,int importo)
        {
            NumeroCarta = numeroCarta;
            Tipo = tipo;
            Importo = importo;
            DataMovimento = DateTime.Now;
        }

        public enum TipoCarta
        {
            Amex,
            Visa,
            Mastercard,
        }

    }
}
