using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_es03_mattina
{
    internal class ShowMessag
    {
        public static void AppendiMessage(string message)
        {

            // IMPLEMENTAZIONE RICORSIVA
            if (message.Length > 10)
            {

                Console.WriteLine(message.Substring(0, 10));

                // Richiamo lo stesso metodo da dentro e stampo il resto del messaggio
                AppendiMessage(message.Substring(10));
            }
            else { 
                Console.WriteLine(message);
            }


            // IMPLEMENTAZIONE ITERATIVA
            //while (message.Length > 10)
            //{
            //    Console.WriteLine(message.Substring(0, 10));
            //
            //    message = message.Substring(10); 
            //}
            //Console.WriteLine(message);


            // ITERATIVA SU SINGOLI CARATTERI
            //int pos = 0;
            //foreach (char c in message)
            //{
            //    if (pos == 10)
            //    { 
            //        Console.WriteLine();
            //        pos = 0;
            //    }
            //    Console.WriteLine(c);
            //    pos++;
            //}
        }

    }
}
