using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        //Aquí se declara las variables de instancia.

        double operando1 = 0;

        String operacion = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (label1.Text == "0")
            {
                label1.Text = boton.Text;
            }
            else 
            {
                label1.Text = label1.Text + boton.Text;
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;
            operando1 = Convert.ToDouble(label1.Text);
            label1.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double operando2 = Convert.ToDouble(label1.Text);
            double resultado = 0;
            if (operacion == "+")
            {
                resultado = operando1 + operando2;
            }
            else if (operacion == "-")
            {
                resultado = operando1 - operando2;
            }

            if (operacion == "/")
            {
                resultado = operando1 / operando2;
            }
            else if (operacion == "*")
            {
                resultado = operando1 * operando2;
            }
            

            if (operacion == "º")
            {
                resultado = Math.Pow(operando1, operando2);
            }
            else if (operacion == "¬")
            {
                resultado = Math.Sqrt(operando1);
            }

            if (operacion == "sen(x)")
            {
                resultado = Math.Sin(operando1);
            }
            else if (operacion == "cos(x)")
            {
                resultado = Math.Cos(operando1);
            }

            label1.Text = Convert.ToString(resultado);
        }

        

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                this.BackColor = Color.FromArgb(34, 36, 49);

                button1.BackColor = Color.Black;
                button1.ForeColor = Color.White;

                button2.BackColor = Color.Black;
                button2.ForeColor = Color.White;

                button3.BackColor = Color.Black;
                button3.ForeColor = Color.White;

                button4.BackColor = Color.Black;
                button4.ForeColor = Color.White;

                button5.BackColor = Color.Black;
                button5.ForeColor = Color.White;

                button6.BackColor = Color.Black;
                button6.ForeColor = Color.White;

                button7.BackColor = Color.Black;
                button7.ForeColor = Color.White;

                button8.BackColor = Color.Black;
                button8.ForeColor = Color.White;

                button9.BackColor = Color.Black;
                button9.ForeColor = Color.White;

                button10.BackColor = Color.Black;
                button10.ForeColor = Color.White;

                button11.BackColor = Color.Black;
                button11.ForeColor = Color.White;

                button12.BackColor = Color.Black;
                button12.ForeColor = Color.White;

                button13.BackColor = Color.Black;
                button13.ForeColor = Color.White;

                button14.BackColor = Color.Black;
                button14.ForeColor = Color.White;

                button15.BackColor = Color.Black;
                button15.ForeColor = Color.White;

                button16.BackColor = Color.Black;
                button16.ForeColor = Color.White;

                button17.BackColor = Color.Black;
                button17.ForeColor = Color.White;

                button18.BackColor = Color.Black;
                button18.ForeColor = Color.White;

                button19.BackColor = Color.Black;
                button19.ForeColor = Color.White;

                button20.BackColor = Color.Black;
                button20.ForeColor = Color.White;

                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;

                button1.BackColor = Color.White;
                button1.ForeColor = Color.Black;

                button2.BackColor = Color.White;
                button2.ForeColor = Color.Black;

                button3.BackColor = Color.White;
                button3.ForeColor = Color.Black;

                button4.BackColor = Color.White;
                button4.ForeColor = Color.Black;

                button5.BackColor = Color.White;
                button5.ForeColor = Color.Black;

                button6.BackColor = Color.White;
                button6.ForeColor = Color.Black;

                button7.BackColor = Color.White;
                button7.ForeColor = Color.Black;

                button8.BackColor = Color.White;
                button8.ForeColor = Color.Black;

                button9.BackColor = Color.White;
                button9.ForeColor = Color.Black;

                button10.BackColor = Color.White;
                button10.ForeColor = Color.Black;

                button11.BackColor = Color.White;
                button11.ForeColor = Color.Black;

                button12.BackColor = Color.White;
                button12.ForeColor = Color.Black;

                button13.BackColor = Color.White;
                button13.ForeColor = Color.Black;

                button14.BackColor = Color.White;
                button14.ForeColor = Color.Black;

                button15.BackColor = Color.White;
                button15.ForeColor = Color.Black;

                button16.BackColor = Color.White;
                button16.ForeColor = Color.Black;

                button17.BackColor = Color.White;
                button17.ForeColor = Color.Black;

                button18.BackColor = Color.White;
                button18.ForeColor = Color.Black;

                button19.BackColor = Color.White;
                button19.ForeColor = Color.Black;

                button20.BackColor = Color.White;
                button20.ForeColor = Color.Black;

                radioButton1.ForeColor = Color.Black;
                radioButton2.ForeColor = Color.Black;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        { 
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }
    }
}
