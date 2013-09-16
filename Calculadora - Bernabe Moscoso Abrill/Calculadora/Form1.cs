using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        string operador="+";
        int cont=1,  maximo=7;
        int largo;
        
        string cifra1, cifra2;
        double result = 0;
        bool inicio = true;
        bool estado = false;
        
        private void button10_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
                estado = false;
                
            }
            else
            if (estado == false)
            {
                textBox1.Text = "0";
                estado = true;
                cont = 1;
                if (inicio==true)
                {
                    result = 0;
                }
            }
            else
                if (cont <= maximo)
                {
                    textBox1.Text = textBox1.Text + "0";
                    cont = cont + 1;
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (estado == false)
            {
                textBox1.Text = "1";
                cont = 1;
                estado = true;
                if (inicio == true)
                {
                    result = 0;
                }
            }
            else
            if (cont <= maximo)
            {
                textBox1.Text = textBox1.Text + "1";
                cont = cont + 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (estado == false)
            {
                textBox1.Text = "2";
                cont = 1;
                estado = true;
                if (inicio == true)
                {
                    result = 0;
                }
            }
            else
                if (cont <= maximo)
                {
                    textBox1.Text = textBox1.Text + "2";
                    cont = cont + 1;
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (estado == false)
            {                
                textBox1.Text = "3";
                cont = 1;
                estado = true;
                if (inicio == true)
                {
                    result = 0;
                }
            }
            else
                if (cont <= maximo)
                {
                    textBox1.Text = textBox1.Text + "3";
                    cont = cont + 1;
                }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            if (estado == false)
            {
                textBox1.Text = "4";
                cont = 1;
                estado = true;
                if (inicio == true)
                {
                    result = 0;
                }
            }
            else
                if (cont <= maximo)
                {
                    textBox1.Text = textBox1.Text + "4";
                    cont = cont + 1;
                }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (estado == false)
            {
                textBox1.Text = "5";
                cont = 1;
                estado = true;
                if (inicio == true)
                {
                    result = 0;
                }
            }
            else
                if (cont <= maximo)
                {
                    textBox1.Text = textBox1.Text + "5";
                    cont = cont + 1;
                }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            if (estado == false)
            {
                textBox1.Text = "6";
                cont = 1;
                estado = true;
                if (inicio == true)
                {
                    result = 0;
                }
            }
            else
                if (cont <= maximo)
                {
                    textBox1.Text = textBox1.Text + "6";
                    cont = cont + 1;
                }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            if (estado == false)
            {
                textBox1.Text = "7";
                cont = 1;
                estado = true;
                if (inicio == true)
                {
                    result = 0;
                }
            }
            else
                if (cont <= maximo)
                {
                    textBox1.Text = textBox1.Text + "7";
                    cont = cont + 1;
                }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            if (estado == false)
            {
                textBox1.Text = "8";
                cont = 1;
                estado = true;
                if (inicio == true)
                {
                    result = 0;
                }
            }
            else
                if (cont <= maximo)
                {
                    textBox1.Text = textBox1.Text + "8";
                    cont = cont + 1;
                }
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            if (estado == false)
            {
                textBox1.Text = "9";
                cont = 1;
                estado = true;
                if (inicio == true)
                {
                    result = 0;
                }
            }
            else
                if (cont <= maximo)
                {
                    textBox1.Text = textBox1.Text + "9";
                    cont = cont + 1;
                }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //borrar todo
            result = 0;
            estado = false;
            inicio = true;
            cont = 1;
            operador = "+";
            textBox1.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = maximo;
            textBox1.DeselectAll();           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //suma
            
            cifra1 = textBox1.Text;
            textBox1.Text = "";
            operador = "+";
            inicio= false;
            estado = false;
        }
       
        private void button12_Click(object sender, EventArgs e)
        {
            //igual
            
            cifra2 = textBox1.Text;

            if (operador == "+")
                result = Int32.Parse(cifra1) + Int32.Parse(cifra2);
            else
            {
                if (operador == "-")
                    result = Int32.Parse(cifra1) - Int32.Parse(cifra2);
                else
                {
                    if (operador == "*")
                        result = Int32.Parse(cifra1) * Int32.Parse(cifra2);
                    else
                    {
                        if (Int32.Parse(cifra2) == 0)
                            MessageBox.Show("no existe division entre 0");
                        else result = Int32.Parse(cifra1) / Int32.Parse(cifra2);
                    }
                }
            }
            textBox1.Text = result.ToString();
            operador = "+";
            inicio =true;        
            estado =false; 
        }
        
        private void button14_Click(object sender, EventArgs e)
        {
            //resta
            
            cifra1 = textBox1.Text;
            textBox1.Text = "";
            operador = "-";
            inicio = false;
            estado = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //multiplicacion
            cifra1 = textBox1.Text;
            textBox1.Text = "";
            operador = "*";
            inicio = false;
            estado = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //division
            cifra1 = textBox1.Text;
            textBox1.Text = "";
            operador = "/";
            inicio = false;
            estado = false;
        }
    }
}
