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
            if (MesComboBox.Text == "")
            {
                errorProvider1.SetError(MesComboBox, "Seleccione una opción");
                return;
           }
            decimal capital = Convert.ToDecimal(CapitalTextBox.Text);
            decimal tasa = Convert.ToDecimal(TasaTextBox.Text);


            decimal resultado = Interes(Convert.ToDecimal(CapitalTextBox.Text), Convert.ToDecimal(TasaTextBox.Text));

            
            MesesListBox.Items.Add(MesComboBox.Text);
            InteresesListBox.Items.Add(resultado);
            ResultadoTextBox.Text = Convert.ToString(resultado);
            
            MesComboBox.SelectedIndex= -1;
        }

        private decimal Interes(decimal capital, decimal tasa)
        {
            tasa = tasa / 100;
            string mes = MesComboBox.Text;

            if (mes == "Enero")
            {
                resultado = (capital * tasa) *1;
                
                }else if (mes =="Febrero")
                {
                resultado = (capital * tasa) *2;
            }
            else if (mes == "Marzo")
            {
            resultado = (capital * tasa) *3;
            }
            else if(mes=="Abril")
            {
                resultado=(capital * tasa) *4;

            }
            else if (mes == "Mayo")
            {
                resultado = (capital * tasa) *5;

            }
            else if (mes == "Junio")
            {
                resultado = (capital * tasa) *6;
            }
            else if (mes == "Julio")
            {
                resultado = (capital * tasa) *7;
            }
            else if (mes == "Agosto")
            {
                resultado = (capital * tasa) *8;
            }
            else if (mes == "Septiembre")
            {
                resultado = (capital * tasa) *9;
            }
            else if (mes == "Octubre")
            {
                resultado = (capital * tasa) *10;
            }
            else if (mes == "Noviembre")
            {
                resultado = (capital * tasa) * 11;
            }
            else if (mes == "Diciembre")
            {
                resultado = (capital * tasa)  * 12;

            }

            return resultado;
        }
      
       
    }
}
