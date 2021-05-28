using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Test
{
    public static class TaskManagement
    {
        internal static Task InserisciTask()
        {
            Task task = new Task();
            try
            {
                bool success;
                Console.WriteLine("Inscerisci il nome");
                task.Nome = Console.ReadLine();
                Console.WriteLine("Inserisci la Descrizione");
                task.Descrizione = Console.ReadLine();
                Console.WriteLine("Inserisci la data di scadenza del task");
                bool dataOK = DateTime.TryParse(Console.ReadLine(), out DateTime data);
                //verifico se l'utente ha inserito una data corretta
                while (!dataOK)
                {
                    Console.WriteLine("Inscerisci una data corretta");
                    success = DateTime.TryParse(Console.ReadLine(), out DateTime date);
                }
                task.DataScadenza = data;
                Console.WriteLine("Inserisci l'importanza");
                int[] values = new int[] { 0, 1, 2 };
                foreach (int enumValue in values)
                {
                    Console.WriteLine(Enum.GetName(typeof(LivelloImportanza), enumValue));
                }
                success = Enum.TryParse(Console.ReadLine(), out LivelloImportanza import);
                task.Importanza = import;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return task;
        }

        public static LivelloImportanza FiltroImportanza(ArrayList task)
        {
            Console.WriteLine("Inserisci il tipo task che vuoi vedere");
            
            LivelloImportanza nome = (Importanza)Convert.ToString(Console.ReadLine());
            foreach (LivelloImportanza task in tasks)
            {
                if(nome == LivelloImportanza.Basso)
                {
                    return Console.WriteLine(Enum.GetName(typeof(LivelloImportanza), tasks));
                }
                else if (nome == LivelloImportanza.Medio)
                {
                    return Console.WriteLine(Enum.GetName(typeof(LivelloImportanza), tasks));
                }
                else if(nome == LivelloImportanza.Alto)
                {
                    return  Console.WriteLine(Enum.GetName(typeof(LivelloImportanza), tasks));
                }
                else
                {
                    return  Console.WriteLine("Livello incoretto");
                }
                



            }
        }

        public static Task CercaTask(ArrayList tasks)
        {
            Console.WriteLine("Cerca task inserendo il nome de task");
            string nome = Console.ReadLine();
            foreach (Task task in tasks)
            {
                if(task.Nome == nome)
                {
                    return task;
                }
                
            }
            return null;
        }

        public static void StampaTask(ArrayList tasks)
        {
            foreach (Task task in tasks)
            {
                Console.WriteLine(task);
            }
        }
    }
}
