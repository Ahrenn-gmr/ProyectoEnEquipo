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
	/// Description of Form4.
	/// </summary>
	public partial class Form4 : Form
	{
		public Form4()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			Form1 r = new Form1();
			r.Show();
			this.Close();
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtPalabra.Text = " ";
			txtResultado.Text = " ";
		}
		
		void BtnInversaClick(object sender, EventArgs e)
		{
			string textoOriginal = txtPalabra.Text;
			
			// Verifica que no este vacio
			if (string.IsNullOrEmpty(textoOriginal)){
				MessageBox.Show("Por favor, ingresa una palabra.", "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			
			char[] caracteres = textoOriginal.ToCharArray(); // Convierte la cadena de texto en lista individual
			Array.Reverse(caracteres); // Cambia el orden
			string textoInvertido = new string(caracteres); // Vuelve a unir los caracteres
			
			// Mostrar resultado
			txtResultado.Text = textoInvertido;
		}
	}
}
