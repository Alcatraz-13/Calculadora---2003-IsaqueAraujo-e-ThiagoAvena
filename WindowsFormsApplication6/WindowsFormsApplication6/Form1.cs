using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        double x, y, result, variavel, variavel2;
        int op;
        bool res = false;
        public Form1()
        {

            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (res)
                Visor.Text = "";
            res = false;
            if (res == false)
            {
                Visor.Text += Convert.ToString(3);
                if (x != 0)
                    y = 3;
                else
                    x = 3;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (res)
                Visor.Text = "";
            res = false;
            if (res == false)
            {
                Visor.Text += Convert.ToString(1);
                if (x != 0)
                    y = 1;
                else
                    x = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (res)
                Visor.Text = "";
            res = false;
            if (res == false)
            {
                Visor.Text += Convert.ToString(2);
                if (x != 0)
                    y = 2;
                else
                    x = 2;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (res)
                Visor.Text = "";
            res = false;
            if (res == false)
            {
                Visor.Text += Convert.ToString(4);
                if (x != 0)
                    y = 4;
                else
                    x = 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (res)
                Visor.Text = "";
            res = false;
            if (res == false)
            {
                Visor.Text += Convert.ToString(5);
                if (x != 0)
                    y = 5;
                else
                    x = 5;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (res)
                Visor.Text = "";
            res = false;
            if (res == false)
            {
                Visor.Text += Convert.ToString(6);
                if (x != 0)
                    y = 6;
                else
                    x = 6;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (res)
                Visor.Text = "";
            res = false;
            if (res == false)
            {
                Visor.Text += Convert.ToString(7);
                if (x != 0)
                    y = 7;
                else
                    x = 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (res)
                Visor.Text = "";
            res = false;
            if (res == false)
            {
                Visor.Text += Convert.ToString(8);
                if (x != 0)
                    y = 8;
                else
                    x = 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (res)
                Visor.Text = "";
            res = false;
            if (res == false)
            {
                Visor.Text += Convert.ToString(9);
                if (x != 0)
                    y = 9;
                else
                    x = 9;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (res)
                Visor.Text = "";
            res = false;
            if (res == false)
            {
                Visor.Text += Convert.ToString(0);
                if (x != 0)
                    y = 0;
                else
                    x = 0;
            }
        }

        private void btmais_Click(object sender, EventArgs e)
        {
            op = 1;                           // operação recebe a função '+', que tem código 1
            variavel = Convert.ToDouble(Visor.Text);  // variável1 armazena o que está na tela
            // que é o 1º numero (x) e a operação
            Visor.Text = "";                    // depois o visor é zerado, para receber o 2º número
        }

        private void btmenos_Click(object sender, EventArgs e)
        {
            op = 2;                               // operação recebe a função '-', que tem código 2
            variavel = Convert.ToDouble(Visor.Text); // variável1 armazena o que está na tela
            // que é o 1º numero (x) e a operação
            Visor.Text = "";                    // depois o visor é zerado, para receber o 2º número
        }

        private void btdividido_Click(object sender, EventArgs e)
        {
            op = 4;                              // operação recebe a função '/', que tem código 4
            variavel = Convert.ToDouble(Visor.Text);    // variável1 armazena o que está na tela
            // que é o 1º numero (x) e a operação
            Visor.Text = "";                    // depois o visor é zerado, para receber o 2º número
        }

        private void btvezes_Click(object sender, EventArgs e)
        {
            op = 3;                               // operação recebe a função '*', que tem código 3
            variavel = Convert.ToDouble(Visor.Text); // variável1 armazena o que está na tela
            // que é o 1º numero (x) e a operação
            Visor.Text = "";                    // depois o visor é zerado, para receber o 2º número          
        }

        private void bigual_Click(object sender, EventArgs e)
        {
            try
            {
                y = Convert.ToDouble(Visor.Text);
                if (op == 1)                                //se a operação estiver armazenado a função mais
                    result = variavel + y;            // o resultado será a soma das variáveis
                if (op == 2)                             //se a operação estiver armazenado a função menos
                    result = variavel - y;          // o resultado será a subtração das variáveis
                if (op == 3)                            //se a operação estiver armazenado a função vezes
                    result = variavel * y;         // o resultado será a multiplicação das variáveis
                if (op == 4)                               //se a operação estiver armazenado a função dividido
                    result = variavel / y;              // o resultado será a divisão das variáveis

                Visor.Text = Convert.ToString(result);  //mostra no visor o valor de result
                variavel = Convert.ToDouble(Visor.Text);
                res = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bzerar_Click(object sender, EventArgs e)
        {
            Visor.Text = "";
            x = 0;
            variavel = 0;
            y = 0;
        }

        private void bvirgula_Click(object sender, EventArgs e)
        {
            int virg;
            virg = Visor.Text.IndexOf(",");   //Procura por todo visor o caracter "," e se achar
            if (virg >= 0)                    //retorna a void, ou seja, faz nada
                return;
            else                           //se não achar, a vírgula é inserida
                Visor.Text += ",";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            op = int.Parse(Visor.Text);                               // operação recebe a função '*', que tem código 3
            variavel = Convert.ToDouble(Visor.Text); // variável1 armazena o que está na tela
            // que é o 1º numero (x) e a operação
            Visor.Text = Math.Cos(op).ToString(); 
        }

        private void button11_Click(object sender, EventArgs e)
        {
            op = int.Parse(Visor.Text);                               // operação recebe a função '*', que tem código 3
            variavel = Convert.ToDouble(Visor.Text); // variável1 armazena o que está na tela
            // que é o 1º numero (x) e a operação
            Visor.Text = Math.Tan(op).ToString(); 
        }

        private void raiz_Click(object sender, EventArgs e)
        {
            op = int.Parse(Visor.Text);                               // operação recebe a função '*', que tem código 3
            x = Convert.ToDouble(Visor.Text); // variável1 armazena o que está na tela
            // que é o 1º numero (x) e a operação
            Visor.Text = Math.Sqrt(op).ToString(); 
        }

        private void sen_Click(object sender, EventArgs e)
        {
            op = int.Parse(Visor.Text);                               // operação recebe a função '*', que tem código 3
            variavel = Convert.ToDouble(Visor.Text); // variável1 armazena o que está na tela
            // que é o 1º numero (x) e a operação
            Visor.Text = Math.Sin(op).ToString(); 

        }

        private void porcentagem_Click(object sender, EventArgs e)
        {
            op = int.Parse(Visor.Text);  
            x = double.Parse(Visor.Text);
            result = x + y;// operação recebe a função '*', que tem código 3
             // variável1 armazena o que está na tela
            // que é o 1º numero (x) e a operação
            Visor.Text = Convert.ToString((x * y)/100);
            Visor.Clear();


        }

        private void resto_Click(object sender, EventArgs e)
        {
            

        }
    }
}

