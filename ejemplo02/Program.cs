using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Linea> lineas = new List<Linea>();

            using (var reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"../../../vial.csv"))
            {
                while (!reader.EndOfStream)
                {
                    try
                    {
                        lineas.Add(
                            new Linea(reader.ReadLine())
                        );
                    } catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Environment.Exit(1);
                    }
                }
            }

            foreach (Linea linea in lineas)
            {
                Console.WriteLine(linea.imprimir());
            }
        }
    }
}
