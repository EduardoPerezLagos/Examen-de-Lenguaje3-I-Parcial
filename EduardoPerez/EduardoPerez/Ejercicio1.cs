using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduardoPerez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal resultado = 0;

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            decimal capital = Convert.ToDecimal(CapitalTextBox.Text);
            decimal tasa = Convert.ToDecimal(TasaTextBox.Text);


            decimal resultado = Interes1(Convert.ToDecimal(CapitalTextBox.Text), Convert.ToDecimal(TasaTextBox.Text));

            MesesListBox.Items.Add(MesComboBox.Text);
            InteresesListBox.Items.Add(resultado);
            ResultadoTextBox.Text = Convert.ToString(resultado);

            

        }

        private decimal Interes1(decimal capital, decimal tasa)
        {
            tasa = tasa / 100;
            string mes = MesComboBox.Text;

            if (mes == "Enero")
            {
                resultado = (capital * tasa) / 12;
                
                }else if (mes =="Febrero")
                {
                resultado = (capital * tasa) / 12 + resultado;
            }
            else if (mes == "Marzo")
            {
            resultado = (capital * tasa) / 12 +resultado;
            }
            else if(mes=="Abril")
            {
                resultado=(capital * tasa) / 12 + resultado;

            }
            else if (mes == "Mayo")
            {
                resultado = (capital * tasa) / 12 + resultado;

            }
            else if (mes == "Junio")
            {
                resultado = (capital * tasa) / 12 + resultado;
            }
            else if (mes == "Julio")
            {
                resultado = (capital * tasa) / 12 + resultado;
            }
            else if (mes == "Agosto")
            {
                resultado = (capital * tasa) / 12 + resultado;
            }
            else if (mes == "Septiembre")
            {
                resultado = (capital * tasa) / 12 + resultado;
            }
            else if (mes == "Octubre")
            {
                resultado = (capital * tasa) / 12 + resultado;
            }
            else if (mes == "Noviembre")
            {
                resultado = (capital * tasa) / 12 + resultado;
            }
            else if (mes == "Diciembre")
            {
                resultado = (capital * tasa) / 12 + resultado;

            }

            return resultado;
        }
        //private decimal Interes2(decimal capital, decimal tasa) 
       // {
         //   string mes = MesComboBox.Text;
           // if (mes == "Febrero")
           // {
           //     resultado = (capital * tasa) / 12;
           // }
           // return resultado;
       // }
    }
}
