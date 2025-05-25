namespace CarroApp1
{
    internal class Direcao
    {
        private float _angulo;

        public Direcao(float angulo)
        {
            this._angulo = angulo;
            angulo = 0;

        }

        private float getAngulo()
        {
            return _angulo;
        }


        public void IncrementaAngulo()
        {
            if (_angulo > 30)
            {
                _angulo += 5;
            }
        }
          
        

        public void DecrementaAngulo()
        {   if(_angulo < -30)
            _angulo -= 5;
        }


    }
}
