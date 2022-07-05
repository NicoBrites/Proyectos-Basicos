using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraGitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void boton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }
        private void boton2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }
        private void boton3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }
        private void boton4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }
        private void boton5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }
        private void boton6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }
        private void boton7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }
        private void boton8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }
        private void boton9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }
        private void boton0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }
        private void botonPunto_Click(object sender, EventArgs e)
        {
            bool tienePunto;
            if (textBox1.Text.Contains(","))
            {
                tienePunto = true;
            }
            else
            {
                tienePunto = false;
            }
            if (tienePunto == false)
            {
                textBox1.Text = textBox1.Text + ",";
            }
            else
            {
                MessageBox.Show("No puede ingresar 2 comas en un mismo numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void botonCE_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        private void botonBorrarCaracter_Click(object sender, EventArgs e)
        {
            string numero = textBox1.Text;
            if (numero.Length > 0)
            {
                textBox1.Text = numero.Substring(0, numero.Length - 1);
            }
        }
        string operacion;
        double primerNum;
        double calculo;
        double segundoNum;
        private void botonSuma_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox1.Text == "-" || textBox1.Text == "," || textBox1.Text == "-," || textBox1.Text == ",-")
            {
               
            }
            else
            {
                primerNum = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                operacion = "Suma";
            }
        }
        private void botonResta_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "-";
            }
            else if (textBox1.Text == "-" || textBox1.Text == "," || textBox1.Text == "-," || textBox1.Text == ",-")
            {

            }
            else
            {
                primerNum = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                operacion = "Resta";
            }
            
        }
        private void botonMulti_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox1.Text == "-" || textBox1.Text == "," || textBox1.Text == "-," || textBox1.Text == ",-")
            {

            }
            else
            {
                primerNum = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                operacion = "Multiplicacion";
            }
        }
        private void botonDivi_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox1.Text == "-" || textBox1.Text == "," || textBox1.Text == "-," || textBox1.Text == ",-")
            {

            }
            else
            {
                primerNum = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                operacion = "Division";
            }
        }
        private void botonIgual_Click(object sender, EventArgs e)
        {
            switch (operacion)
            {
                case "Suma":
                    if (textBox1.Text.Length == 0 || textBox1.Text == "-" || textBox1.Text == "," || textBox1.Text == "-," || textBox1.Text == ",-")
                    {

                    }
                    else
                    {
                        segundoNum = Convert.ToDouble(textBox1.Text);
                        calculo = primerNum + segundoNum;
                        textBox1.Text = calculo.ToString();
                        operacion = "";
                    }
                    break;
                case "Resta":
                    if (textBox1.Text.Length == 0 || textBox1.Text == "-" || textBox1.Text == "," || textBox1.Text == "-," || textBox1.Text == ",-")
                    {

                    }
                    else
                    {
                        segundoNum = Convert.ToDouble(textBox1.Text);
                        calculo = primerNum - segundoNum;
                        textBox1.Text = calculo.ToString();
                        operacion = "";
                    }
                    break;
                case "Division":
                    if (textBox1.Text.Length == 0 || textBox1.Text == "-" || textBox1.Text == "," || textBox1.Text == "-," || textBox1.Text == ",-")
                    {

                    }
                    else if (textBox1.Text == "0")
                    {
                        MessageBox.Show("No puede dividir por cero!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        segundoNum = Convert.ToDouble(textBox1.Text);
                        calculo = primerNum / segundoNum;
                        textBox1.Text = calculo.ToString();
                        operacion = "";
                    }
                    break;
                case "Multiplicacion":
                    if (textBox1.Text.Length == 0 || textBox1.Text == "-" || textBox1.Text == "," || textBox1.Text == "-," || textBox1.Text == ",-")
                    {

                    }
                    else
                    {
                        segundoNum = Convert.ToDouble(textBox1.Text);
                        calculo = primerNum * segundoNum;
                        textBox1.Text = calculo.ToString();
                        operacion = "";
                    }
                    break;
            }
        }      
    }
}
