using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase02092024
{
    internal class Auto
    {
        private string matricula;
        private string marca;
        private string color;

        public Auto(string matricula, string marca, string color)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.color = color;
        }

        
        public string GetMatricula()
        {
            return matricula;
        }

       
        public string GetMarca()
        {
            return marca;
        }

       
        public string GetColor()
        {
            return color;
        }

        
        public void Pintar(string nuevoColor)
        {
            color = nuevoColor;
        }
    }
}
