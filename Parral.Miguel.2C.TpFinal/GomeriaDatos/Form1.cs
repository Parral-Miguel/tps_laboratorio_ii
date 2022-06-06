using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Biblioteca;

namespace GomeriaDatos
{
    public partial class FormGomeria : Form
    {
        private Gomeria gomeria;
        public FormGomeria()
        {
            InitializeComponent();

            gomeria = new Gomeria();

        }

        private void FormGomeria_Load(object sender, EventArgs e)
        {
            Neumatico n1 = new Neumatico(Neumatico.Tamanio.Camion, Modelos.Pirelli, 3);
            Neumatico n2 = new Neumatico(Neumatico.Tamanio.Ciclomotor, Modelos.Fate, 1);
            Neumatico n3 = new Neumatico(Neumatico.Tamanio.Sedan, Modelos.Goodyear, 4);
            Neumatico n4 = new Neumatico(Neumatico.Tamanio.Sedan, Modelos.Michelin, 2);
            Operacion o1 = new Operacion("Carlos Rodriguez",Operacion.Tipo.Chequeo);
            Operacion o2 = new Operacion("Ford", Operacion.Tipo.Mantenimiento);
            Operacion o3 = new Operacion("Peugeot", Operacion.Tipo.Compra, n1);
            Operacion o4 = new Operacion("Jose Perez", Operacion.Tipo.Compra, n4);
            Operacion o5 = new Operacion("Carlos Tevez", Operacion.Tipo.Cambio, n3);

            gomeria.Agregar(o1);
            gomeria.Agregar(o2);
            gomeria.Agregar(o3);
            gomeria.Agregar(o4);
            gomeria.Agregar(o5);

            rtbDatos.Text = Gomeria.ObtenerInforme(gomeria);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (gomeria.Agregar(NuevaOperacion(txtCliente.Text, cmbTrabajo.Text)))
            {
                MessageBox.Show("Operacion exitosa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (gomeria.Quitar(NuevaOperacion(txtCliente.Text, cmbTrabajo.Text)))
            {
                MessageBox.Show("Operacion exitosa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else
            {
                MessageBox.Show("Error: No se encontro en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
        private Operacion NuevaOperacion(string cliente, string trabajo)
        {

            Operacion.Tipo tipo;
            switch (trabajo)
            {
                case "Chequeo":

                    tipo = Operacion.Tipo.Chequeo;
                    break;

                case "Mantenimiento":

                    tipo = Operacion.Tipo.Mantenimiento;
                    break;

                case "Compra":

                    tipo = Operacion.Tipo.Compra;
                    break;

                case "Cambio":

                    tipo = Operacion.Tipo.Cambio;
                    break;

                default:
                    Exception ex = new Exception();
                    throw ex;

            }

            if (tipo == Operacion.Tipo.Chequeo || tipo == Operacion.Tipo.Mantenimiento)
            {
                Operacion operacion = new Operacion(cliente, tipo);
                return operacion;
            }

            else
            {
                Operacion operacion = new Operacion(cliente, tipo, NuevoTrabajoNeumatico(cmbMarca.Text, cmbTamanio.Text, txtCantidad.Text));
                return operacion;
            }
        }
        
        private Neumatico NuevoTrabajoNeumatico(string marca, string tamanio, string cantidad)
        {
            Modelos modelo;
            Neumatico.Tamanio tam;

            switch (marca)
            {
                case "Pirelli":
                    
                    modelo = Modelos.Pirelli;
                    break;

                case "Fate":

                    modelo = Modelos.Fate;
                    break;

                case "Goodyear":

                    modelo = Modelos.Goodyear;
                    break;

                case "Michelin":

                    modelo = Modelos.Michelin;
                    break;

                default:
                    Exception ex = new Exception();
                    throw ex;

            }

            switch (tamanio)
            {
                case "Camion":

                    tam = Neumatico.Tamanio.Camion;
                    break;

                case "Ciclomotor":

                    tam = Neumatico.Tamanio.Ciclomotor;
                    break;

                case "Sedan":

                    tam = Neumatico.Tamanio.Sedan;
                    break;

                default:
                    Exception ex = new Exception();
                    throw ex;
            }

            Neumatico neumatico = new Neumatico(tam, modelo, int.Parse(txtCantidad.Text));
           
            
            return neumatico;
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            rtbDatos.Text = Gomeria.ObtenerInforme(gomeria);
        }
    }
}
