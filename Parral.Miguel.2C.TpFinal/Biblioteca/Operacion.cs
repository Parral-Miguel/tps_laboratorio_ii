using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Operacion 
    {
        public enum Tipo
        {
            Chequeo,
            Cambio,
            Mantenimiento,
            Compra
        }

        string cliente;
        Tipo trabajo;
        int total;
        DateTime fecha;
        Neumatico neumatico;

        public Tipo Trabajo 
        { 
            get 
            { 
                return this.trabajo; 
            } 
            set 
            {
                
            } 
        }

        
        public string Cliente 
        { 
            get 
            { 
                return this.cliente; 
            } 
            set 
            {
                
            } 
        }
        
        
        public DateTime Fecha 
        { 
            get 
            { 
                return this.fecha; 
            } 
            set 
            {

            } 
        } 
        

        public int Total
        {
            get
            {

                switch (this.trabajo)
                {
                    case Tipo.Chequeo:

                        total = 1500;
                        break;

                    case Tipo.Cambio:

                        total = (this.neumatico.Cantidad * this.neumatico.Precio) + 1000;
                        break;

                    case Tipo.Compra:

                        total = this.neumatico.Cantidad * this.neumatico.Precio;
                        break;

                    case Tipo.Mantenimiento:

                        total = 3000;
                        break;
                    
                    default:
                        Exception ex = new Exception();
                        throw ex;

                }

                return total;
            }

            set
            { 
            
            }

        }

        public Operacion(string cliente, Tipo tipo)
        {
            this.cliente = cliente;
            this.trabajo = tipo;
            this.fecha = DateTime.Now;
        }

        public Operacion(string cliente, Tipo tipo, Neumatico neumatico)
            :this (cliente, tipo)
        {
            this.neumatico = neumatico;
                        this.total = Total;

        }

        public virtual string ObtenerInformacion()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Cliente: {cliente}");
            stringBuilder.AppendLine($"{trabajo}");
            stringBuilder.AppendLine(neumatico.ObtenerInformacion());
            stringBuilder.AppendLine($"$ {total}");
            stringBuilder.AppendLine($"{fecha}");

            return stringBuilder.ToString();
        }


        public static bool operator ==(List<Operacion> listaOp, Operacion op)
        {
            if (op is null || listaOp is null)
            {
                return false;
            }

            foreach (Operacion opAux in listaOp)
            {
                if (opAux.cliente == op.cliente && opAux.trabajo == op.trabajo)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(List<Operacion> listaOp, Operacion op)
        {
            return !(listaOp == op);
        }


        public static bool operator +(List<Operacion> listaGomeria, Operacion op)
        {

            listaGomeria.Add(op);
            return true;
        }

        public static bool operator -(List<Operacion> listaGomeria, Operacion op)
        {
            foreach (Operacion opAux in listaGomeria)
            {
                if (opAux == op)
                {
                    listaGomeria.Remove(op);
                    return true;
                }
            }

            return false;
        }

    }
}
