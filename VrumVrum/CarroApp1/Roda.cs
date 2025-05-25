using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarroApp1
{
    public class Roda
    {
        private string Longitudinal;
        private string Transversal;
        private float Angulo;

        public Roda(string longitudinal, string transversal)
        {
            Longitudinal = longitudinal;
            Transversal = transversal;
            Angulo = 0;
        }

        public void SetAngulo(float angulo)
        {
            this.Angulo = angulo;
        }

    }
}
