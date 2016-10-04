using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucionModeloParcial
{
    public class Cardenal
    {
        private int _cantVotosRecibidos;
        private ENacionalidades _nacionalidad;
        private string _nombre;
        private string _nombrePapal;

        #region Constructores

        private Cardenal()
        {
            this._cantVotosRecibidos = 0;
        }

        public Cardenal(string nombre, string nombrePapal) : this()
        {
            this._nombre = nombre;
            this._nombrePapal = nombrePapal;
        }

        public Cardenal(string nombre, string nombrePapal, ENacionalidades nacionalidad) : this(nombre, nombrePapal)
        {
            this._nacionalidad = nacionalidad;
        }
            


        #endregion

        #region Metodos

        public int getCantidadVotosRecibidos()
        {
            return this._cantVotosRecibidos;
        }

        private string Mostrar()
        {
            StringBuilder sbCardenal;
            sbCardenal = new StringBuilder();

            sbCardenal.AppendLine("---INFORMACION DEL CARDENAL---");
            sbCardenal.AppendLine("Cantidad de votos: " + this._cantVotosRecibidos);
            sbCardenal.AppendLine("Nacionalidad: " + this._nacionalidad);
            sbCardenal.AppendLine(this.ObtenerNombreYNombrePapal());

            return sbCardenal.ToString();
        }

        public static string Mostrar(Cardenal cardenal)
        {
            StringBuilder sbCardenal;
            sbCardenal = new StringBuilder();

            sbCardenal.AppendLine(cardenal.Mostrar());

            return sbCardenal.ToString();
        }

        public string ObtenerNombreYNombrePapal()
        {
            StringBuilder sbCardenal;
            sbCardenal = new StringBuilder();

            sbCardenal.AppendLine("El cardenal '"+this._nombre+"' se llamara '"+this._nombrePapal+"'");

            return sbCardenal.ToString();
        }

        #endregion

        #region Sobrecargas

        public static bool operator ==(Cardenal cardenalUno, Cardenal cardenalDos)
        {
            if (cardenalUno._nombre == cardenalDos._nombre && cardenalUno._nacionalidad == cardenalDos._nacionalidad && cardenalUno._nombrePapal == cardenalDos._nombrePapal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Cardenal cardenalUno, Cardenal cardenalDos)
        {
            if (cardenalUno._nombre != cardenalDos._nombre && cardenalUno._nacionalidad != cardenalDos._nacionalidad && cardenalUno._nombrePapal != cardenalDos._nombrePapal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Cardenal operator ++(Cardenal unCardenal)
        {
            unCardenal._cantVotosRecibidos = unCardenal._cantVotosRecibidos + 1;

            return unCardenal;
        }

        #endregion
    }
}
