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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void CalculaButton_Click(object sender, EventArgs e)
        {
            int[] numeros = new int[100];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = i + 1;
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 3 == 0 && numeros[i] % 5 == 0)
                {
                    DatosListBox.Items.Add(numeros[i] + " Eduardo Pérez");

                }
                else
                {
                    if (numeros[i] % 3 == 0)
                    {
                        DatosListBox.Items.Add(numeros[i] + " Eduardo");
                    }
                    else
                    {
                        if (numeros[i] % 5 == 0)
                        {
                            DatosListBox.Items.Add(numeros[i] + " Pérez");
                        }
                        else
                        {
                            DatosListBox.Items.Add(numeros[i]);
                          
                        }
                    }
                }
                    
                    }
                }

            }
        }
    

