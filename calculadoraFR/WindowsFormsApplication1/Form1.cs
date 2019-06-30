using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        //public string primero;
        //public string segundo;
        //public string operacion;
        float resultado = 0;

        public Form1()
        {
            InitializeComponent();
        }
        bool suma,
            resta,
            multiplicacion,
            division;

        bool value = true,
                valida = true,
                coma = true;

        private void btn0_Click(object sender, EventArgs e)
        {
            String aux;
          
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "0";
            }
            else if (txtPantalla.Text != "0")
            {
                aux = txtPantalla.Text + "0";
                txtPantalla.Text = aux;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (valida == false)
            {
                if (value)
                {
                    txtPantalla.Text = "";
                }
                txtPantalla.Text = txtPantalla.Text + "1";
                value = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "1";
            }
           
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (valida == false)
            {
                if (value)
                {
                    txtPantalla.Text = "";
                }
                txtPantalla.Text = txtPantalla.Text + "2";
                value = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (valida == false)
            {
                if (value)
                {
                    txtPantalla.Text = "";
                }
                txtPantalla.Text = txtPantalla.Text + "3";
                value = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (valida == false)
            {
                if (value)
                {
                    txtPantalla.Text = "";
                }
                txtPantalla.Text = txtPantalla.Text + "4";
                value = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (valida == false)
            {
                if (value)
                {
                    txtPantalla.Text = "";
                }
                txtPantalla.Text = txtPantalla.Text + "5";
                value = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (valida == false)
            {
                if (value)
                {
                    txtPantalla.Text = "";
                }
                txtPantalla.Text = txtPantalla.Text + "6";
                value = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (valida == false)
            {
                if (value)
                {
                    txtPantalla.Text = "";
                }
                txtPantalla.Text = txtPantalla.Text + "7";
                value = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (valida == false)
            {
                if (value)
                {
                    txtPantalla.Text = "";
                }
                txtPantalla.Text = txtPantalla.Text + "8";
                value = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (valida == false)
            {
                if (value)
                {
                    txtPantalla.Text = "";
                }
                txtPantalla.Text = txtPantalla.Text + "9";
                value = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "9";
            }
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            if (coma)
            {
                if (valida == false)
                {
                    if (value)
                    {
                        txtPantalla.Text = "";
                    }
                    txtPantalla.Text = txtPantalla.Text + ",";
                    value = false;
                }
                else
                {
                    txtPantalla.Text = txtPantalla.Text + ",";
                }
                coma = false;
            }

            //txtPantalla.Text = txtPantalla.Text + ",";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            try
            {
                txtPantalla.Text = txtPantalla.Text.Substring(0, txtPantalla.Text.Count() - 1);
            }
            catch (Exception)
            {
                MessageBox.Show("Dont value");
               
               
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "0";
            }
            else
            {
                if (suma)
                {
                    resultado += float.Parse(txtPantalla.Text);
                }
                if (resta)
                {
                    resultado -= float.Parse(txtPantalla.Text);
                }
                if (multiplicacion)
                {
                    resultado *= float.Parse(txtPantalla.Text);
                }
                if (division)
                {
                    resultado /= float.Parse(txtPantalla.Text);
                }
                if (resultado == 0 || txtPantalla.Text == "0")
                {
                    value = true;
                }
                txtPantalla.Text = resultado.ToString();
                suma = false;
                resta = false;
                multiplicacion = false;
                division = false;
            }
            coma = true;
        }

        private void txtPantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //txtPantalla.Clear();
            resultado = 0;
            txtPantalla.Text = "";
            valida = true;
            value = true;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            //operacion = "+";
            //primero = txtPantalla.Text;
            //txtPantalla.Clear();
            if (valida)
            {
                float aux= float.Parse(txtPantalla.Text);
                resultado = resultado + aux;
                suma = true;
                txtPantalla.Focus();
                txtPantalla.Text = "";
                valida = false;
            }
            else
            {
                if (suma)
                {
                    try
                    {
                        resultado += float.Parse(txtPantalla.Text);
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("");
                    }

                }
                if (resta)
                {
                    try
                    {
                        resultado -= float.Parse(txtPantalla.Text);
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("");
                    }

                }
                if (multiplicacion)
                {
                    try
                    {
                        resultado *= float.Parse(txtPantalla.Text);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("");
                    }

                }
                if (division)
                {
                    try
                    {
                        resultado /= float.Parse(txtPantalla.Text);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("");
                    }

                }
                txtPantalla.Text = resultado.ToString();
                suma = true;
                resta = false;
                division = false;
                multiplicacion = false;
                value = true;

            }
            coma = true;


        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //operacion = "-";
            //primero = txtPantalla.Text;
            //txtPantalla.Clear();
            if (valida)
            {
                float aux = float.Parse(txtPantalla.Text);
                resultado = resultado + aux;
                resta = true;
                txtPantalla.Focus();
                txtPantalla.Text = "";
                valida = false;
            }
            else
            {
                if (suma)
                {
                    try
                    {
                        resultado += float.Parse(txtPantalla.Text);
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("");
                    }

                }
                if (resta)
                {
                    try
                    {
                        resultado -= float.Parse(txtPantalla.Text);
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("");
                    }

                }
                if (multiplicacion)
                {
                    try
                    {
                        resultado *= float.Parse(txtPantalla.Text);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("");
                    }

                }
                if (division)
                {
                    try
                    {
                        resultado /= float.Parse(txtPantalla.Text);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("");
                    }

                }
                txtPantalla.Text = resultado.ToString();
                resta = true;
                suma = false;
                multiplicacion = false;
                division = false;
                value = true;

            }
            coma = true;
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            //operacion = "*";
            //primero = txtPantalla.Text;
            //txtPantalla.Clear();
            if (valida)
            {
                float aux = float.Parse(txtPantalla.Text);
                resultado = resultado + aux;
                multiplicacion = true;
                txtPantalla.Focus();
                txtPantalla.Text = "";
                valida = false;
            }
            else
            {
                if (suma)
                {
                    try
                    {
                        resultado += float.Parse(txtPantalla.Text);
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("");
                    }

                }
                if (resta)
                {
                    try
                    {
                        resultado -= float.Parse(txtPantalla.Text);
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("");
                    }

                }
                if (multiplicacion)
                {
                    try
                    {
                        resultado *= float.Parse(txtPantalla.Text);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("");
                    }

                }
                if (division)
                {
                    try
                    {
                        resultado /= float.Parse(txtPantalla.Text);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("");
                    }

                }
                txtPantalla.Text = resultado.ToString();
                multiplicacion = true;
                suma = false;
                resta = false;
                division = false;
                value = true;
            }
            coma = true;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            //operacion = "/";
            //primero = txtPantalla.Text;
            //txtPantalla.Clear();
            if (valida)
            {
                float aux = float.Parse(txtPantalla.Text);
                resultado = resultado + aux;
                division = true;
                txtPantalla.Focus();
                txtPantalla.Text = "";
                valida = false;
            }
            else
            {
                if (suma)
                {
                    try
                    {
                        resultado += float.Parse(txtPantalla.Text);
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("");
                    }

                }
                if (resta)
                {
                    try
                    {
                        resultado -= float.Parse(txtPantalla.Text);
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("");
                    }

                }
                if (multiplicacion)
                {
                    try
                    {
                        resultado *= float.Parse(txtPantalla.Text);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("");
                    }

                }
                if (division)
                {
                    try
                    {
                        resultado /= float.Parse(txtPantalla.Text);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("");
                    }

                }
                txtPantalla.Text = resultado.ToString();
                division = true;
                multiplicacion = false;
                suma = false;
                resta = false;
                value = true;

            }
            coma = true;
        }
    }
}


