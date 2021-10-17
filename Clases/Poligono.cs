using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap10_And_Cap12.Clases
{
    public class Poligono
    {
        private int Base;
        private int Altura;

        public string Cadena;

        //Constructor
        public Poligono(int _Base, int _Altura)
        {
            Base = _Base;
            Altura = _Base;
        }
        //Sobrecarga del constructor
        public Poligono(int Base_)
        {
            Base = Base_;
            string Cadena = Base.ToString();//Metodo ToString();
        }
        //Crear propiedades para la clase
        public void SetBase(int _Base)
        {
            if (_Base <= 0)
            {
                _Base = 1;
            }
            Base = _Base;
        }

        public void SetAltura(int _Altura)
        {
            if (_Altura <= 0)
            {
                _Altura = 1;
            }
            Altura = _Altura;
        }

        public int GetBase()
        {
            return Base;
        }

        public int GetAltura()
        {
            return Altura;
        }
    }
}
