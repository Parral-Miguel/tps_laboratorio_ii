using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace Biblioteca
{
    public class Gomeria : Negocio <Operacion>
    {


        //Constructores de la operacion
        public List<Operacion> gomeria;


        public Gomeria()
        {
            gomeria = new List<Operacion>();
            
        }

        // agregar

        public bool Agregar(Operacion op)
        {
            return gomeria + op;
         
        }

        public bool Quitar(Operacion op)
        {
            return gomeria - op;
        }

        public static string ObtenerInforme(Gomeria gomeria)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (Operacion op in gomeria.gomeria)
            {
                stringBuilder.AppendLine(JsonSerializer.Serialize(op));
            }
           

            return stringBuilder.ToString();
        }

    }
}
