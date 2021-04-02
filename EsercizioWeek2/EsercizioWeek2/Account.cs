using System;
using System.Collections.Generic;
using System.Text;

namespace EsercizioWeek2
{
   public class Account
    {
        public int NumeroConto { get; set; } = 0;
        public string NomeProprietarioConto { get; set; }
        public string NomeBanca { get; set; }
        public decimal Saldo { get; set; }
        public DateTime DataUltimaOperazione { get; set; }

        List<Movement> listaMovimenti = new List<Movement>();

        public Account(string nomeBanca, string nomeProprietarioConto)
        {
            NomeBanca = nomeBanca;
            NomeProprietarioConto = nomeProprietarioConto;
            NumeroConto++;
            Saldo =0;
            DataUltimaOperazione = DateTime.Now;
        }

        // Metodi:

        public int Deposito()
        {
            Console.WriteLine("Quanto depositi?");
            int deposito = Convert.ToInt32(Console.ReadLine());

            return deposito;
        }
    }
}
