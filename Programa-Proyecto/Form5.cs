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
	/// Description of Form5.
	/// </summary>
	public partial class Form5 : Form
	{
		public Form5()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
		    string palabra = txtPalabra.Text.ToLower();
		
		    int vocales = 0;
		    int consonantes = 0;
		
		    string listaVocales = "aeiouáéíóúü";
		    string listaConsonantes = "bcdfghjklmnñpqrstvwxyz";
		
		    // 2. Recorrer cada letra de la palabra
		    foreach (char letra in palabra)
			{
			    // Verificar si es vocal
			    if (listaVocales.Contains(letra.ToString()))
			    {
			        vocales++;
			    }
			    // Verificar si es consonante 
			    else if (listaConsonantes.Contains(letra.ToString()))
			    {
			        consonantes++;
			    }
			}
					
		    // 3. Mostrar los resultados 
		    txtVocales.Text = vocales.ToString();
		    txtConsonantes.Text = consonantes.ToString();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Form1 m = new Form1();
			m.Show();
			this.Close();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			txtPalabra.Text = "";
			txtVocales.Text = "";
			txtConsonantes.Text = "";
		}
	}
}
