using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Test
{
    public static class TaskIO
    {
        //private static object writer;

        public static void StampaSuFile(ArrayList tasks)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                 "Tasks.txt");
            try
            {
                using (StreamWriter writer = File.CreateText(path))
                {
                    foreach (Task task in tasks)
                    {
                        writer.WriteAsync(task.ToString());
                    }
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void StampaContenutoFile()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
                , "Tasks.txt");
            string line;
            Task t = new Task();
            try
            {
                using (StreamReader reader = File.OpenText(path))
                {
                    while ((line = reader.ReadLine()) != null)//richiedo la lettura della singola linea
                    {
                        string[] values = line.Split("\t");
                        t.Nome = values[0];
                        t.Descrizione = values[1];
                        t.DataScadenza = Convert.ToDateTime(values[2]);
                        t.Importanza =(LivelloImportanza)Convert.ToInt32(values[3]);
                        Console.WriteLine(line);

                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
    }
    }
}
