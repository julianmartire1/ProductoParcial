using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoParcial
{
    public class Galletita : Producto
    {
        protected float _peso;

        public Galletita(int codigo, float precio, EMarcaProducto marca, float peso):base(codigo,marca,precio)
        {
            this._peso = peso;
        }

        public static string MostrarGalletita(Galletita gaieta)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Producto.MostrarProducto(gaieta));
            sb.AppendLine("Sabor: " + gaieta._peso);
            return sb.ToString();
        }
    }
}
