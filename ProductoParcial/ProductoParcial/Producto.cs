using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoParcial
{
    public class Producto
    {
        protected int _codigoBarra;
        protected EMarcaProducto _marca;
        public EMarcaProducto Marca { get { return this._marca; } }
        protected float _precio;
        public float Precio { get { return this._precio; } }

        public Producto(int codigo, EMarcaProducto marca, float precio)
        {
            this._codigoBarra = codigo;
            this._marca = marca;
            this._precio = precio;
        }

        protected static string MostrarProducto(Producto prod)
        {
            StringBuilder sb=new StringBuilder();

            sb.AppendLine("Marca: "+prod.Marca);
            sb.AppendLine("Codigo: "+prod._codigoBarra);
            sb.AppendLine("Precio: "+prod.Precio);

            return sb.ToString();
        }

        public static explicit operator int(Producto prod)
        {
            return prod._codigoBarra;
        }

        public static bool operator ==(Producto prod, EMarcaProducto marca)
        {
            if (prod._marca == marca)
                return true;
            return false;
        }

        public static bool operator !=(Producto prod, EMarcaProducto marca)
        {
            return !(prod==marca);
        }

        public static bool operator ==(Producto prod1, Producto prod2)
        {
            if (prod1._marca == prod2._marca && prod1._codigoBarra == prod2._codigoBarra)
                return true;
            return false;
        }

        public static bool operator !=(Producto prod1, Producto prod2)
        {
            return !(prod1==prod2);
        }






    }
}
