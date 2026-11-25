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
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void RegresarToolStripMenuItemClick(object sender, EventArgs e)
		{
			MainForm regresar = new MainForm();
			regresar.Show();
			this.Close();
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void BtnPrograma1Click(object sender, EventArgs e)
		{
			Form2 f = new Form2();
			f.Show();
			this.Hide();
		}
		
		void BtnPrograma2Click(object sender, EventArgs e)
		{
			Form3 g = new Form3();
			g.Show();
			this.Hide();
		}
		
		void BtnPrograma3Click(object sender, EventArgs e)
		{
			Form4 h = new Form4();
			h.Show();
			this.Hide();
		}
		
		void BtnPrograma4Click(object sender, EventArgs e)
		{
			Form5 i = new Form5();
			i.Show();
			this.Hide();
		}
	}
}
