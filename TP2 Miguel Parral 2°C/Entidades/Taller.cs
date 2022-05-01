using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public class Taller
    {
        private List<Vehiculo> vehiculos;
        private int espacioDisponible;
        public enum ETipo
        {
            Ciclomotor, Sedan, SUV, Todos
        }

        #region "Constructores"
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Taller(int espacioDisponible)
        {
            this.espacioDisponible = espacioDisponible;
            this.vehiculos = new List<Vehiculo>();
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Listar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles\r\n", taller.vehiculos.Count, taller.espacioDisponible);

            switch (tipo)
            {
                case ETipo.Ciclomotor:
                    {
                        filtrarVehiculoPorTamanio(sb, taller.vehiculos, Vehiculo.ETamanio.Chico);
                        break;
                    }

                case ETipo.Sedan:
                    {
                        filtrarVehiculoPorTamanio(sb, taller.vehiculos, Vehiculo.ETamanio.Mediano);
                        break;
                    }

                case ETipo.SUV:
                    {
                        filtrarVehiculoPorTamanio(sb, taller.vehiculos, Vehiculo.ETamanio.Grande);
                        break;
                    }

                default:
                    {
                        foreach (Vehiculo v in taller.vehiculos)
                        { 
                                sb.AppendLine(v.Mostrar());
                        }
                        break;
                    }
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns></returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {

            foreach (Vehiculo v in taller.vehiculos)
            {
                if (v == vehiculo)
                    return taller;
            }
            if (taller.vehiculos.Count < taller.espacioDisponible)
            {
                taller.vehiculos.Add(vehiculo);
            }
            return taller;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns></returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in taller.vehiculos)
            {
                if (v == vehiculo)
                {
                    taller.vehiculos.Remove(vehiculo);
                }
            }
            return taller;
        }


        /// <summary>
        /// Filtra elementos de lista por tamaño y los añade al StringBuilder 
        /// </summary>
        /// <param name="sb">StringBuilder qque se va construyendo</param>
        /// <param name="vehiculos">lista de vehiculos</param>
        /// <param name="tamanio">tamaño del objeto</param>
        /// <returns></returns>
        private static void filtrarVehiculoPorTamanio(StringBuilder sb, List<Vehiculo> vehiculos, Vehiculo.ETamanio tamanio)
        {
            foreach (Vehiculo v in vehiculos)
            {
                if (v.Tamanio == tamanio)
                    sb.AppendLine(v.Mostrar());
            }
        }
        #endregion
    }
}
