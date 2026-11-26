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
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnOrdenarClick(object sender, EventArgs e)
		{
            string[] textos = txtNumeros.Text.Split(',');
            int[] numeros = new int[textos.Length];

            for (int i = 0; i < textos.Length; i++)
            {
                numeros[i] = int.Parse(textos[i].Trim());
            }

            Array.Sort(numeros);
            txtAscendente.Text = string.Join(", ", numeros);

            Array.Reverse(numeros);
            txtDescendente.Text = string.Join(", ", numeros);
		}
		
		void BtnVolverClick(object sender, EventArgs e)
		{
			Form1 Menu = new Form1();
			Menu.Show();
			this.Hide();
		}
	}
}
