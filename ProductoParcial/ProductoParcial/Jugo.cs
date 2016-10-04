using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoParcial
{
    public class Jugo : Producto
    {
        protected ESaborJugo _sabor;

        public Jugo(int codigo, float precio, EMarcaProducto marca, ESaborJugo sabor):base(codigo,marca,precio)
        {
            this._sabor = sabor;
        }

        public string MostrarJugo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Producto.MostrarProducto(this));
            sb.AppendLine("Sabor: "+this._sabor);
            return sb.ToString();
        }

    }
}
