using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarroApp1
{
    internal class Ignicao
    {
         bool Ligado { get; set; }


        public Ignicao(bool ligado)
        {
            this.Ligado = ligado;
            this.Ligado = false;
        }
        public void SetIgnicao( bool Ligado, float velocidade, int cambio)
        {
            if (Ligado == false)
                Ligado = true;
            else
            { 
                if (Ligado && velocidade == 0 && cambio == 0)
                Ligado = false;
            }

        }
    }
}
