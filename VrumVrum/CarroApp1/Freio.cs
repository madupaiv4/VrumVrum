using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarroApp1
{
    internal class Freio
    {
        public bool FreioAcionado;

        public Freio(bool freioAcionado)
        {
            FreioAcionado = freioAcionado;
            FreioAcionado = false;
        }
        public bool GetFreio()
        {
            return FreioAcionado;
        }
        public void SetFreio(bool freio, float velocidade, int marcha)
        {
            if (FreioAcionado == false)
            {
                FreioAcionado = true;
                if (velocidade != 0)
                {
                    velocidade = 0;
                    marcha = 0;
                    FreioAcionado = false;
                }
            }
            else
                FreioAcionado = false;



          
        }
    }
}
