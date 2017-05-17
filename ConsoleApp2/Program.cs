using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var num_grupos = 3;
            var num_materias = 5;
            List<string> grupos_horas = new List<string>();
            List<string> materias = new List<string>()
            {
                "Programacion",
                "Pokemones",
                "Netflix",
                "Temis",
                "DiegoLasser"
            };
            List<string> lista_horas = new List<string>()
            {

            };
            List<string> grupos = new List<string>();
            var horas = 7;

            for (int i = 0; i < num_grupos; i++)
            {
                grupos.Add("Grupo"+i);
            }
            var cont0 = 0;
            var cont1 = 0;
            var cont3 = 0;
            for (int i = 0; i < num_grupos; i++)
            {
                for (int j = 0; j < horas; j++)
                {
                 
                   if (cont1 < num_materias)
                    {
                        grupos_horas.Add(grupos[i] + " Horas: " + j + materias[cont0]);
                        cont1++;
                    }
                    else
                    {
                        if (cont1+cont3<horas+1)
                        {
                            grupos_horas.Add(grupos[i] + " Horas: "+ j +"Vacio");
                            cont3++;

                        }
                        else
                        {
                            cont1 = 0;
                            cont3 = 0;
                        }

                    }


                    cont0++;
                    if (cont0>=num_materias)
                    {
                        cont0 = 0;
                        cont1++;
                    }
                }
                
            }
            foreach (var cosas in grupos_horas)
            {
                Console.WriteLine(cosas);
            }
            Console.ReadKey();
        }
    }
}
