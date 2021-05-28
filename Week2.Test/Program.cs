using System;
using System.Collections;

namespace Week2.Test
{
    class Program
    {
        public static void Main(string[] args)
        {

            //vedere task inseriti
            //agiungere un nuovo task
            //eliminare un task
            //filtrare i task per importanza
            ArrayList tasks = new ArrayList();
            bool continua = true;
            while (continua)
            {
                int scelta = SchermoMenu();
                switch (scelta)
                {
                   case 1:
                Task taskDaAggiungere = TaskManagement.InserisciTask();
                break;
                    case 2:
                        TaskManagement.StampaTask(tasks);
                        break;
                    case 3:
                        Task taskDaCancellare = TaskManagement.CercaTask(tasks);
                        try
                        {
                            Task.Remove(taskDaCancellare);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Task non trovato");
                        }
                        break;
                    case 4:
                        // per filtrare i task
                        TaskManagement.FiltroImportanza(task);
                        break;
                    case 5:
                        TaskIO.StampaSuFile(tasks);
                        break;
                    case 6:
                        TaskIO.StampaContenutoFile();
                        break;
                    case 0:
                        //per catturare l'eccezione
                        break;
                    default:
                        //con un numero diverso da 0
                        continua = false;
                        Console.WriteLine("A presto");
                        break;



                }
            }
        }

    public static int SchermoMenu()
    {
        Console.WriteLine("1. Inserisci Task");
        Console.WriteLine("2. Stampa task inserito");
        Console.WriteLine("3. Elimina task");
        Console.WriteLine("4. Filtra i task per importanza");
        Console.WriteLine("5. Stampa su file");
        Console.WriteLine("6. Stampa lista task");
        Console.WriteLine("9. Per uscire");
        int scelta = 0;
        try
        {
            scelta = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("Inserisci un numero corretto");
            scelta = 0;
        }
        return scelta;
    }
}
}
