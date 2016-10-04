using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucionModeloParcial
{
    public class Conclave
    {
        private int _cantMaxCardenales;
        private List<Cardenal> _cardenales;
        private bool _habemusPapa;
        private string _lugarEleccion;
        private Cardenal _papa;
        public static int cantidadVotaciones;
        public static DateTime fechaVotacion;
        public static Random random;

        #region Constructores

        static Conclave()
        {
            cantidadVotaciones = 0;
            fechaVotacion = DateTime.Today;
            random = new Random();
        }

        public Conclave()
        {
            this._cardenales = new List<Cardenal>();
            this._cantMaxCardenales = 1;
            this._lugarEleccion = "Capilla sixtina";
        }

        private Conclave(int cantidadCardenales) : this()
        {
            this._cantMaxCardenales = cantidadCardenales;
        }

        public Conclave(int cantidadCardenales, string lugarEleccion) : this()
        {
            this._cantMaxCardenales = cantidadCardenales;
        }

        #endregion

        #region Metodos

        private bool HayLugar()
        {
            if (this._cardenales.Count < this._cantMaxCardenales)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string MostrarCardenales()
        {
            StringBuilder sbCardenales;
            sbCardenales = new StringBuilder();

            sbCardenales.AppendLine("---INFORMACION DE LOS CARDENALES---");

            foreach (Cardenal item in this._cardenales)
            {
                sbCardenales.AppendLine(Cardenal.Mostrar(item));
            }

            return sbCardenales.ToString();
        }

        public string Mostrar()
        {
            StringBuilder sbPapa;
            sbPapa = new StringBuilder();

            sbPapa.AppendLine("---INFORMACION DEL CONCLAVE---");
            sbPapa.AppendLine("Lugar de votacion: " + this._lugarEleccion);
            sbPapa.AppendLine("Cantidad de votos: " + cantidadVotaciones);
            sbPapa.AppendLine("Fecha de la votacion: " + fechaVotacion);

            if (this._habemusPapa == true)
            {
                sbPapa.AppendLine("HABEMUS PAPA");
                sbPapa.AppendLine(this._papa.ObtenerNombreYNombrePapal());
            }
            else
            {
                sbPapa.AppendLine("NO HABEMUS PAPA");
                sbPapa.AppendLine(this.MostrarCardenales());
            }

            return sbPapa.ToString();
        }

        private static void ContarVotos(Conclave unConclave)
        {
            for (int i = 0; i < unConclave._cardenales.Count; i++)
            {
                if (i == 0)
                {
                    unConclave._papa = unConclave._cardenales[i];
                    unConclave._habemusPapa = true;
                }

                if (unConclave._papa.getCantidadVotosRecibidos() < unConclave._cardenales[i].getCantidadVotosRecibidos())
                {
                    unConclave._papa = unConclave._cardenales[i];
                    unConclave._habemusPapa = true;
                }
                else
                {
                    unConclave._habemusPapa = false;
                }
            }
        }

        public static void VotarPapa(Conclave unConclave)
        {
            int indicePapal;

            for (int i = 0; i < unConclave._cardenales.Count; i++)
            {       
                indicePapal = random.Next(0, unConclave._cardenales.Count);
                unConclave._cardenales[indicePapal]++;                
            }   
            
            Conclave.ContarVotos(unConclave);         
        }

        #endregion

        #region Sobrecargas

        public static implicit operator Conclave(int cantidadCardenales)
        {
            return new Conclave(cantidadCardenales);
        }

        public static explicit operator bool(Conclave unConclave)
        {
            if (unConclave._habemusPapa == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Conclave unConclave, Cardenal unCardenal)
        {
            foreach (Cardenal item in unConclave._cardenales)
            {
                if (item == unCardenal)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Conclave unConclave, Cardenal unCardenal)
        {
            foreach (Cardenal item in unConclave._cardenales)
            {
                if (item != unCardenal)
                {
                    return true;
                }
            }

            return false;
        }


        public static Conclave operator +(Conclave unConclave, Cardenal unCardenal)
        {
            if (unConclave.HayLugar() == true)
            {
                if (unConclave == unCardenal)
                {
                    Console.WriteLine("El cardenal ya existe");
                }
                else
                {
                    unConclave._cardenales.Add(unCardenal);
                    Console.WriteLine("Cardenal correctamente ingresado");
                }
            }
            else
            {
                Console.WriteLine("No hay mas lugar en el conclave");
            }

            return unConclave;
        }

        #endregion
    }
}
