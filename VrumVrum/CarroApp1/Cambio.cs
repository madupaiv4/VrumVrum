using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarroApp1
{
    internal class Cambio
    {
        private int _marcha;
      
        public Cambio(int marcha)
        {
            _marcha = marcha;
        }

       public int AlterarMarcha( float Velocidade)
        {

            switch (Velocidade)
            {
                case Velocidade == 0:
                    _marcha = 0
                    return _marcha;
                    break;

                case Velocidade < 20 && Velocidade > 0:
                    _marcha = 1
                    return _marcha;
                    break;

                case Velocidade < 40 && Velocidade > 20:
                    _marcha = 2
                    return _marcha;
                    break;

                case Velocidade < 50 && Velocidade > 40:
                    _marcha = 3
                    return _marcha;
                    break;

                case Velocidade < 60 && Velocidade > 50:
                    _marcha = 4
                    return _marcha;
                    break;

                default:
                    return _marcha = 5;
                    break;

            }
          


        }
        }
    }
}
