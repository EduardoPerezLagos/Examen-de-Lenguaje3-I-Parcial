using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduardoPerez
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private async void CalcularButton_Click(object sender, EventArgs e)
        {
            if (NombreTextBox.Text == "")
            {
                errorProvider1.SetError(NombreTextBox, "Ingrese su nombre");
                return;
            }
            if (Producto1TextBox.Text == "")
            {
                errorProvider1.SetError(Producto1TextBox, "Nombre del producto 1");
                return;
            }
            if (Precio1TextBox.Text == "")
            {
                errorProvider1.SetError(Precio1TextBox, "Ingrese el Precio");
                return;
            }
            if (Cantidad1TextBox.Text == "")
            {
                errorProvider1.SetError(Cantidad1TextBox, "Ingrese la cantidad");
                return;
            }
            if (Producto2TextBox.Text == "")
            {
                errorProvider1.SetError(Producto2TextBox, "Nombre del Producto 2");
                return;
            }
            if (Precio2TextBox.Text == "")
            {
                errorProvider1.SetError(Precio2TextBox, "Ingrese el precio");
                return;
            }
            if (Cantidad2TextBox.Text == "")
            {
                errorProvider1.SetError(Cantidad2TextBox, "Ingrese la cantidad");
                return;
            }
            errorProvider1.Clear();
            string nombre = NombreTextBox.Text;
            string producto1 = Producto1TextBox.Text;
            string producto2 = Producto2TextBox.Text;
            decimal cantidad1 = Convert.ToDecimal(Cantidad1TextBox.Text);
            decimal cantidad2 = Convert.ToDecimal(Cantidad2TextBox.Text);
            decimal precio1 = Convert.ToDecimal(Precio1TextBox.Text);
            decimal precio2 = Convert.ToDecimal(Precio2TextBox.Text);

            decimal total = await TotalNetoAsync(precio1, cantidad1, precio2, cantidad2);

            decimal descuento = (precio1 * cantidad1 * 15 / 100) + (precio2 * cantidad2 * 15 / 100);

            MessageBox.Show($" {nombre}, EL descuento de su compra es de L. {descuento} y el total a pagar son L. {total}");

            LimpiarControles();
            NombreTextBox.Focus();
        }
        private async Task<decimal> TotalNetoAsync(decimal prec1, decimal cant1, decimal prec2, decimal cant2)
        
        {
            
            decimal totalneto = await Task.Run(() =>
            {
                return (prec1 * cant1) + (prec2 * cant2) - (prec1 * cant1 * 15 / 100) - (prec2 * cant2 * 15 / 100);
            });
            return totalneto;
        }

        private void LimpiarControles()
        {
            NombreTextBox.Clear();
            Producto1TextBox.Clear();
            Producto2TextBox.Clear();
            Precio1TextBox.Clear();
            Precio2TextBox.Clear();
            Cantidad1TextBox.Clear();
            Cantidad2TextBox.Clear();
        }
    }
}
