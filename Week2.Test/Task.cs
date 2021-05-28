using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Test
{
    public enum LivelloImportanza
    {
        Basso,
        Medio,
        Alto
    }
    class Task
    {
        public String Nome { get; set; }
        public String Descrizione { get; set; }
        public DateTime DataScadenza { get; set; }

        public LivelloImportanza Importanza { get; set; }

        public override string ToString()
        {
            return $"Nome task: {Nome}" +
                $"\n Descrizione task: {Descrizione}" +
                $"\n Data Scadenza: {DataScadenza.ToShortDateString()}" +
                $"\n Livello Importanza: {Importanza}";
        }

        internal static void Remove(Task taskDaCancellare)
        {
            throw new NotImplementedException();
        }
    }
}
