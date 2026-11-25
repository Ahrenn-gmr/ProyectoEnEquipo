/*
 * Creado por SharpDevelop.
 * Usuario: ahren
 * Fecha: 25/11/2026
 * Hora: 01:47 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Programa_Proyecto
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label2 = new System.Windows.Forms.Label();
			this.btnPrograma1 = new System.Windows.Forms.Button();
			this.btnPrograma4 = new System.Windows.Forms.Button();
			this.btnPrograma2 = new System.Windows.Forms.Button();
			this.btnPrograma3 = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(40, 155);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(742, 51);
			this.label1.TabIndex = 0;
			this.label1.Text = "LO QUE PUEDES ENCONTRAR AQUI:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.regresarToolStripMenuItem,
									this.salirToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(935, 28);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// regresarToolStripMenuItem
			// 
			this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
			this.regresarToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
			this.regresarToolStripMenuItem.Text = "Regresar";
			this.regresarToolStripMenuItem.Click += new System.EventHandler(this.RegresarToolStripMenuItemClick);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
			this.salirToolStripMenuItem.Text = "&Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(277, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(390, 61);
			this.label2.TabIndex = 2;
			this.label2.Text = "BIENVENIDOS";
			// 
			// btnPrograma1
			// 
			this.btnPrograma1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrograma1.Location = new System.Drawing.Point(193, 244);
			this.btnPrograma1.Name = "btnPrograma1";
			this.btnPrograma1.Size = new System.Drawing.Size(170, 107);
			this.btnPrograma1.TabIndex = 3;
			this.btnPrograma1.Text = "Ordena de mayor a menor y de menor a mayor";
			this.btnPrograma1.UseVisualStyleBackColor = true;
			this.btnPrograma1.Click += new System.EventHandler(this.BtnPrograma1Click);
			// 
			// btnPrograma4
			// 
			this.btnPrograma4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrograma4.Location = new System.Drawing.Point(564, 402);
			this.btnPrograma4.Name = "btnPrograma4";
			this.btnPrograma4.Size = new System.Drawing.Size(170, 116);
			this.btnPrograma4.TabIndex = 4;
			this.btnPrograma4.Text = "Indica cuantas vocales y consonantes tiene su palabra";
			this.btnPrograma4.UseVisualStyleBackColor = true;
			this.btnPrograma4.Click += new System.EventHandler(this.BtnPrograma4Click);
			// 
			// btnPrograma2
			// 
			this.btnPrograma2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrograma2.Location = new System.Drawing.Point(564, 244);
			this.btnPrograma2.Name = "btnPrograma2";
			this.btnPrograma2.Size = new System.Drawing.Size(170, 107);
			this.btnPrograma2.TabIndex = 5;
			this.btnPrograma2.Text = "Encuentre el mayor, el menor y el promedio";
			this.btnPrograma2.UseVisualStyleBackColor = true;
			this.btnPrograma2.Click += new System.EventHandler(this.BtnPrograma2Click);
			// 
			// btnPrograma3
			// 
			this.btnPrograma3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrograma3.Location = new System.Drawing.Point(193, 411);
			this.btnPrograma3.Name = "btnPrograma3";
			this.btnPrograma3.Size = new System.Drawing.Size(170, 107);
			this.btnPrograma3.TabIndex = 6;
			this.btnPrograma3.Text = "Escribe una palabra y la imprima al reves";
			this.btnPrograma3.UseVisualStyleBackColor = true;
			this.btnPrograma3.Click += new System.EventHandler(this.BtnPrograma3Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.ClientSize = new System.Drawing.Size(935, 588);
			this.Controls.Add(this.btnPrograma3);
			this.Controls.Add(this.btnPrograma2);
			this.Controls.Add(this.btnPrograma4);
			this.Controls.Add(this.btnPrograma1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "MENU PRINCIPAL";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnPrograma3;
		private System.Windows.Forms.Button btnPrograma2;
		private System.Windows.Forms.Button btnPrograma4;
		private System.Windows.Forms.Button btnPrograma1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label label1;
	}
}
