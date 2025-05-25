using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarroApp1
{
    internal class Acelerador
    {
        private float Velocidade; 

        public Acelerador(float velocidade)
        {
            this.Velocidade = 0;
        }

        public float velocidade
        {
            get { return Velocidade; }
            set { this.Velocidade = value; }
        }

        //public float getVelocidade()
        //{
        //    return Velocidade;
        //}

        //public void SetVelocidade(float velocidadeAdicionada)
        //{
        //    this.Velocidade = velocidadeAdicionada;
        //}

        public float Acelerar(bool carroLigado, int cambio)
        {
            if(Velocidade > 0 && Velocidade < 120)
            {
                if (carroLigado && cambio != 0)
                {
                  
                    Velocidade += 1;    
                }    
            }
            return Velocidade;
        }

        public float Desacelerar(bool carroLigado, int cambio)
        {
            if (Velocidade > 0 && Velocidade < 120)
            {
                if (carroLigado && cambio != 0)
                {
                    Velocidade -= 1;
                }
            }
            return Velocidade;
        }
    }
}
   

