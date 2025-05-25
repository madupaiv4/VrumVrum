using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarroApp1
{
    internal class Carro
    {
        private string Fabricante;
        private string Modelo;
        private Direcao direcao;
        private Roda[] roda;
        private Ignicao ignicao;
        private Acelerador acelerador;
        private Freio freio;
        private Cambio cambio;

        public Carro(string fabricante,string modelo)
        {
            Fabricante = fabricante;
            Modelo = modelo;

        }
    }
}
