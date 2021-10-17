using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap10_And_Cap12.Clases
{
    //Cracion de el diseñode una clase para hacer un inventario
    public class Inventario
    {
        private string NombreArticulo;
        private string DescripcionArticulo;
        private int CodigoArticulo;
        private double PrecioArticulo;
        private double CantidadArticuloComprado;
        private double CantidadArticuloVendido;
        private double CantidadArticuloTotal;
        
        //Contructor
        public Inventario(string _NombreArticulo, string _DescripcionArticulo, int _CodigoArticulo,double _PrecioArticulo, 
            double _CantidadArticuloComprado, double _CantidadArticuloVendido,double _CantidadArticuloTotal){
            NombreArticulo = _NombreArticulo;
            DescripcionArticulo = _DescripcionArticulo;
            CodigoArticulo = _CodigoArticulo;
            PrecioArticulo = _PrecioArticulo;
            CantidadArticuloComprado = _CantidadArticuloComprado;
            CantidadArticuloVendido = _CantidadArticuloVendido;
            CantidadArticuloTotal = _CantidadArticuloTotal;
        }

        //Setters
        public void SetNombreArticulo(string NombreArticulo)
        {
            this.NombreArticulo = NombreArticulo;
        }

        public void SetDescripcionArticulo(string DescripcionArticulo)
        {
            this.DescripcionArticulo = DescripcionArticulo;
        }

        public void SetCodigoArticulo(int CodigoArticulo)
        {
            this.CodigoArticulo = CodigoArticulo;
        }

        public void SetPrecioArticulo(double PrecioArticulo)
        {
            this.PrecioArticulo = PrecioArticulo;
        }

        public void SetCantidadArticuloComprado(double CantidadArticuloComprado)
        {
            this.CantidadArticuloComprado = CantidadArticuloComprado;
        }

        public void SetCantidadArticuloVendido(double CantidadArticuloVendido)
        {
            this.CantidadArticuloVendido = CantidadArticuloVendido;
        }

        public void SetCantidadArticuloTotal(double CantidadArticuloTotal)
        {
            this.CantidadArticuloTotal = CantidadArticuloTotal;
        }

        //Getters
        public string GetNombreArticulo()
        {
            return NombreArticulo;
        }

        public string GetDescripcionArticulo()
        {
            return DescripcionArticulo;
        }

        public double GetCodigoArticulo()
        {
            return CodigoArticulo;
        }

        public double GetPrecioArticulo()
        {
            return PrecioArticulo;
        }

        public double GetCantidadArticuloComprado()
        {
            return CantidadArticuloComprado;
        }

        public double GetCantidadArticuloVendido()
        {
            return CantidadArticuloVendido;
        }

        public double GetCantidadArticuloTotal()
        {
            return CantidadArticuloTotal;
        }

        //Metodos
        public void _Inventario()
        {
            CantidadArticuloTotal = CantidadArticuloComprado - CantidadArticuloVendido;
        }

        public void Ganancias()
        {
            CantidadArticuloTotal = CantidadArticuloTotal * PrecioArticulo;
        }

        















        /*
        public Class1()
        {

        }

        public void SetTotalArticulo(double _CantidadArticuloComprado, double _CantidadArticuloVendido, double _CantidadArticuloTotal)
        {
            CantidadArticuloComprado = _CantidadArticuloComprado;
            CantidadArticuloVendido = _CantidadArticuloVendido;
            CantidadArticuloTotal = _CantidadArticuloTotal;
        }
        
        public double GetTotalesArticulos()
        {
            return CantidadArticuloTotal = CantidadArticuloComprado - CantidadArticuloVendido;
        }
        */
    }
}
