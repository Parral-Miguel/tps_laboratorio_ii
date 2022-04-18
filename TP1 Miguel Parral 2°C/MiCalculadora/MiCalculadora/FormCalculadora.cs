using System;
using System.Windows.Forms;
using Calculador;
using Operandos;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {

        string strN1;
        string strN2;
        double resultado;      
        string operador = "";
        string strResultado;

        public FormCalculadora()
        {
            InitializeComponent();
        }

        // Metodo btnOperar_Click llama al método Operar(), convierte el resultado de double a string,
        // carga el string resultado en el label de resultado y deja registro
        // de la operación en el listbox. 

        private void btnOperar_Click(object sender, EventArgs e)
        {
            resultado = Operar(strN1, strN2, operador);
            strResultado = resultado.ToString();
            lblResultado.Text = strResultado;
            lstOperaciones.Items.Add(strN1 + " " + operador + " " + strN2 + " " + "= " + strResultado);

        }

        // Método btnLimpiar_Click llama al método Limpiar() 
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        // Método cmbOperador_SelectedIndexChanged registra en operador el operador actual seleccionado
        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {
            operador = cmbOperador.Text;
        }

        // Método txtNumero1_TextChanged registra el valor actual del txtNumero1 en strN1
        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            strN1 = txtNumero1.Text;
        }

        // Método txtNumero2_TextChanged registra el valor actual del txtNumero2 en strN2
        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {
            strN2 = txtNumero2.Text;
        }

        // Método btnCerrar_Click llama al método Close(). 
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Método btnConvertirADecimal_Click llama a Operar() y realiza la conversión del resltado llamando al
        // método BinarioDecimal(). Luego carga los resultados en lblResultado y lstOperaciones.
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            resultado = Operar(strN1, strN2, operador);
            strResultado = Operando.BinarioDecimal(resultado.ToString());
            lblResultado.Text = strResultado;
            lstOperaciones.Items.Add(strN1 + " " + operador + " " + strN2 + " " + "= " + strResultado + " Decimal");
        }

        // Método btnConvertirABinario_Click llama a Operar() y realiza la conversión del resltado llamando al
        // método DecimalBinario(). Luego carga los resultados en lblResultado y lstOperaciones.
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            resultado = Operar(strN1, strN2, operador);
            strResultado = Operando.DecimalBinario(resultado);
            lblResultado.Text = strResultado;
            lstOperaciones.Items.Add(strN1 + " " + operador + " " + strN2 + " " + "= " + strResultado + " Binario");
        }

        // Llama a Limpiar() cada vez que se inicia el form
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        // Método Limpiar() llama a método Clear() en el lstOperaciones y pone el string "" en lblResultado y txtNumero1 y 2
        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "";
            lstOperaciones.Items.Clear();
        }

        // Método Operar() recibe por parámetro tres strings: dos operandos y el operador. Convierte el
        // operador a char y llama al método Calculadora.Operar() pasando por parámetros Operandos con  
        // los strings recibidos y el char de operación.
        // Retorna double resultado de Calculadora.Operar
        static private double Operar(string numero1, string numero2, string operador)
        {

            if (operador == "")
            {
                operador = "+";
            }
            char operacion = char.Parse(operador);

            return Calculadora.Operar(new Operando(numero1), new Operando(numero2), operacion);

        }

        // En FormClosing Confirmo el cierre con un MessageBox, si se elige "No", se cancela el evento.
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Salir = MessageBox.Show("¿Desea cerrar la calculadora?", "Salir", MessageBoxButtons.YesNo);
            if (Salir == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    } 
}
