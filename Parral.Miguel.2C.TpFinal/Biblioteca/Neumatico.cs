using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Neumatico
    {
        public enum Tamanio
        {
            Camion,
            Sedan,
            Ciclomotor            
        }

        Tamanio tam;
        int precio;
        int cantidad;
        Modelos modelo;

        public Tamanio Tam
        {
            get
            {
                return this.tam;
            }
            set
            {

            }
        }
        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {

            }
        }
        public Modelos Modelo
        {
            get
            {
                return this.modelo;
            }
            set
            {

            }
        }
        public int Precio
        {
            get
            {

                switch (this.modelo)
                {
                    case Modelos.Michelin:

                        precio = 1500;
                        break;

                    case Modelos.Goodyear:

                        precio = 1200;
                        break;

                    case Modelos.Fate:

                        precio = 750;
                        break;

                    case Modelos.Pirelli:

                        precio = 2000;
                        break;

                    default:
                        Exception ex = new Exception();
                        throw ex;
                }

                return precio;
            }

            set 
            { 
            
            }

        }

        public Neumatico(Tamanio tamanio,  Modelos modelo, int cantidad)
        {
            this.modelo = modelo;
            this.tam = tamanio;
            this.cantidad = cantidad;
            this.precio = Precio;
        }

        public string ObtenerInformacion()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Modelo: {modelo}");
            stringBuilder.AppendLine($"Vehiculo: {tam}");
            stringBuilder.AppendLine($"{cantidad} unidades");

            return stringBuilder.ToString();
        }
    }
}
