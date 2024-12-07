using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase02092024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Auto vw = new Auto("AZA2991", "Volkswagen", "rojo");
            Auto citroen = new Auto("SAS2344", "Citroën", "verde");

            
            vw.Pintar("azul");

            
            Console.WriteLine($"Auto 1: Marca = {vw.GetMarca()}, Matrícula = {vw.GetMatricula()}, Color = {vw.GetColor()}");
            Console.WriteLine($"Auto 2: Marca = {citroen.GetMarca()}, Matrícula = {citroen.GetMatricula()}, Color = {citroen.GetColor()}");
        }
    }
}
