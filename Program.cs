
using System;


namespace csharp_es03_mattina
{
    internal class Program
    {

        static void Main(string[] args)  //entry point
        {

            ShowMessag.AppendiMessage("Nel mezzo del cammino di nostra vita, mi ritrovai per una selva...");

            //int valore;

            //string sValore = Console.ReadLine();
            //valore = Convert.ToInt32(sValore);

            //while(valore != 0)
            //{
            //    Console.WriteLine(Borsellino.Add(valore));
            //    sValore = Console.ReadLine();
            //    valore = Convert.ToInt32(sValore);
            //}


            //COSI CREO DUE SALVADANAI 
            {
                Salvadanaio salva1 = new Salvadanaio();
                Salvadanaio salva2 = new Salvadanaio();

                int valore;
                while (int.TryParse(Console.ReadLine(), out valore))
                {
                    Console.WriteLine(salva1.Add(valore));

                    valore = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(salva2.Add(valore));
                }
            }

            
        }
    }
}

