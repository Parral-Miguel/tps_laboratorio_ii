using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operandos;

namespace Calculador
{
    public static class Calculadora
    {
        // Metodo ValidarOperador valida que el parámetro char de entrada
        // sea solamente alguno de los designados en el tp. Convierte el char '' en '+'.
        // Retorna char
        static private char ValidarOperador(char charOperador)
        {
            if (charOperador == '+' || charOperador == '/' || charOperador == '*' || charOperador == '-')

            {
                return charOperador;
            }

                return '+';      
        }

        // Metodo Operar realiza la operaciones de calculadora.
        // Recibe como parametros de entrada dos Operandos y el char de operación seleccionada.
        // Retorna double resultado.
        static public double Operar(Operando n1, Operando n2, char charOperador)
        {
            charOperador = ValidarOperador(charOperador);
            double resultado = 0;

            switch (charOperador)
            {
                case '+':
                    {
                        resultado = n1 + n2;
                        break;
                    }

                case '-':
                    {
                        resultado = n1 - n2;
                        break;
                    }
                case '*':
                    {
                        resultado = n1 * n2;
                        break;
                    }
                case '/':
                    {
                        resultado = n1 / n2;
                        break;
                    }

            }

            return resultado; 
        }

    }
}
