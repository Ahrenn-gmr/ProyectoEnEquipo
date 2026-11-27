/*
 * Creado por SharpDevelop.
 * Usuario: ahren
 * Fecha: 25/11/2026
 * Hora: 01:47 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Programa_Proyecto
{
	/// <summary>
	/// Description of Form3.
	/// </summary>
	public partial class Form3 : Form
	{
		public Form3()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnVolverClick(object sender, EventArgs e)
		{
			Form1 Menu = new Form1();
			Menu.Show();
			this.Hide();
		}
		
        void BtnCalcularClick(object sender, EventArgs e)
        {
            // 1. Separar el texto por comas y guardar los números en un arreglo
            string[] partes = txtNumeros.Text.Split(',');
            int[] numeros = new int[partes.Length];

            for (int i = 0; i < partes.Length; i++)
            {
                numeros[i] = int.Parse(partes[i].Trim());
            }

            // 2. Preparar variables iniciales
            int mayor = numeros[0];
            int menor = numeros[0];
            int suma = 0;

            // 3. Recorrer el arreglo para encontrar mayor, menor y sumar
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }

                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }

                suma = suma + numeros[i];
            }

            // 4. Calcular el promedio
            double promedio = (double)suma / numeros.Length;

            // 5. Mostrar los resultados en los TextBox
            txtMayor.Text = mayor.ToString();
            txtMenor.Text = menor.ToString();
            txtPromedio.Text = promedio.ToString("0.##");
        }
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtMayor.Text = "";
			txtMenor.Text = "";
			txtPromedio.Text = "";
			txtNumeros.Text = "";
		}
    }
}
