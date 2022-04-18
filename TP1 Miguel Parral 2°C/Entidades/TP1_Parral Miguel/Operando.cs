using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Operandos
{
    public class Operando
    {
        private double numero;

        // Constructor de Operando. Es 0 si pasa sin parámetros
        public Operando()
        {
            this.numero = 0;
        }

        // Constructor de Operando con parametros de entrada string
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        // Constructor de Operando con parametros de entrada double
        public Operando(double numero)
        {
            this.numero = numero;
        }

        // Metodo ValidarOperando recibe string y valida que sea un numero.
        // Retorna un double si es un numero o 0 si no lo es
        static public double ValidarOperando(string strNumero)
        {
            if (strNumero == null)
            {
                return 0;
            }
            
            if (Regex.IsMatch(strNumero, "^[+-]?([0-9]+,?[0-9]*|,[0-9]+)$"))
            {
                return double.Parse(strNumero);
            }
                return 0;
        }

        // Propiedad Numero setea el numero validado en numero
        public string Numero
        {
            set
            {
                this.numero = Operando.ValidarOperando(value);
            }
        }

        // Metodo Esbinario retorna true si el string que recibe es 0 o 1.
        // Retorna bool
        static bool EsBinario(string binario)
        {
            return (Regex.IsMatch(binario, "^[01]+$"));

        }


        // Metodo BinarioDecimal realiza la conversion de binario a decimal de un string.
        // Si EsBinario es true. Si es false, retorna mensaje de error.
        // Retorna string
        static public string BinarioDecimal(string binario)
        {
            if (EsBinario(binario))
            {
                return Convert.ToString(Convert.ToInt32(binario, 2));   
            }

                return "Valor invalido";
        }

        // Metodo DecimalBinario realiza la conversion de decimal a binario de un string.
        // Si EsBinario es true. Si es false, retorna mensaje de error.
        // Retorna string
        static public string DecimalBinario(string numero)
        {
            bool conversion = Int32.TryParse(numero, out int parseado);

            if (conversion)
            {
                return DecimalBinario((double)parseado);
            }
                return "Valor invalido";
        }

        // Metodo BinarioDecimal realiza la conversion de binario a decimal de un double.
        // Retorna string
        static public string DecimalBinario(double numero)
        {
            return Convert.ToString((int)numero, 2);
        }

        // Sobrecarga del operador "+" para realizar la operación entre dos Operandos
        //Retorna double
        static public double operator +(Operando n1, Operando n2)
         {
            return (n1.numero + n2.numero);
        }

        // Sobrecarga del operador "-" para realizar la operación entre dos Operandos
        //Retorna double
        static public double operator -(Operando n1, Operando n2)
        {
            return (n1.numero - n2.numero);
        }


        // Sobrecarga del operador "*" para realizar la operación entre dos Operandos
        //Retorna double
        static public double operator *(Operando n1, Operando n2)
        {
            return (n1.numero * n2.numero);
        }

        // Sobrecarga del operador "/" para realizar la operación entre dos Operandos.
        // Evita error en división por 0.
        //Retorna double
        static public double operator /(Operando n1, Operando n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
                return (n1.numero / n2.numero);
        }
    }

}
