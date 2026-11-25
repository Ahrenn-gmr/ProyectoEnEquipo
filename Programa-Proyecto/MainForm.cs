/*
 * Creado por SharpDevelop.
 * Usuario: ahren
 * Fecha: 25/11/2026
 * Hora: 01:46 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Programa_Proyecto
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		// El Mantener Sesion Iniciada no funciona jejejejeje, es de decoracion minimalista.
		void BtnIniciarSesionClick(object sender, EventArgs e)
		{
			string usuario = "cbtis";
			string contrasena = "2026";
			Convert.ToString(txtContrasena.Text);
			if(txtUsuario.Text == usuario && txtContrasena.Text == contrasena)
			{
				Form1 pantallauno = new Form1();
				pantallauno.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Usuario o contraseña incorrectos", "Error de validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
