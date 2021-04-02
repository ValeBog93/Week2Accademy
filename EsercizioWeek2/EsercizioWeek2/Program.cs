using System;

namespace EsercizioWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variabili:
            int userScelta = 0;

            do
            {
                Console.WriteLine("Buongiorno utente cosa vuoole fare?");
                Console.WriteLine("1 Per creare un account in banca");
                Console.WriteLine("2 uscire dall'app");
                userScelta = Convert.ToInt32(Console.ReadLine());

                if (userScelta == 1)
                {
                    Console.WriteLine("Inserire Nome del proprietario dell'account:");
                    string nomeProp = Console.ReadLine();
                    Console.WriteLine("In quale banca vuoi registrarti?");
                    string nomeBanca = Console.ReadLine();

                    Account account = new Account(nomeBanca, nomeProp);

                    Console.WriteLine($"Account di {account.NomeProprietarioConto}" +
                        $" è stato creato corettamente.\nil saldo: {account.Saldo}." +
                        $"\nNumero del conto: {account.NumeroConto}\nNome banca: {account.NomeBanca}");

                    Console.WriteLine("\n\nCosa vuoi fare del tuo conto");
                    Console.WriteLine("1.Depositare");
                    Console.WriteLine("2.Prelevare");
                    int scelta2 = Convert.ToInt32(Console.ReadLine());
                    if (scelta2==1)
                    {
                        int depo =account.Deposito();
                        account.Saldo = depo;

                    }

                    Console.WriteLine($"\n\nAccount di {account.NomeProprietarioConto}" +
                        $" è stato creato corettamente.\nil saldo: {account.Saldo}." +
                        $"\nNumero del conto: {account.NumeroConto}\nNome banca: {account.NomeBanca}");

                }
                else
                {
                    Console.WriteLine("Arrivederci!");
                }

                Console.WriteLine("");

            } while (userScelta != 2);
            






        }
    }
}
