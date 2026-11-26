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
	partial class Form2
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
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.txtAscendente = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDescendente = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnOrdenar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNumeros = new System.Windows.Forms.TextBox();
			this.btnVolver = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
			this.label1.Location = new System.Drawing.Point(27, 68);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(426, 49);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ordenador de Números";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
			this.label2.Location = new System.Drawing.Point(27, 117);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(434, 62);
			this.label2.TabIndex = 2;
			this.label2.Text = "Ingresa tus números en el recuadro y serán ordenados de manera Menor a Mayor y Vi" +
			"ceversa.";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnVolver);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtAscendente);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtDescendente);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.btnOrdenar);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtNumeros);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(304, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(516, 649);
			this.panel1.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
			this.label6.Location = new System.Drawing.Point(65, 555);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(373, 23);
			this.label6.TabIndex = 12;
			this.label6.Text = "Tus Numeros organizados de Menor a Mayor";
			// 
			// txtAscendente
			// 
			this.txtAscendente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.txtAscendente.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtAscendente.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAscendente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
			this.txtAscendente.Location = new System.Drawing.Point(65, 582);
			this.txtAscendente.Margin = new System.Windows.Forms.Padding(4);
			this.txtAscendente.Name = "txtAscendente";
			this.txtAscendente.Size = new System.Drawing.Size(388, 40);
			this.txtAscendente.TabIndex = 11;
			this.txtAscendente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
			this.label5.Location = new System.Drawing.Point(65, 455);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(373, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Tus Numeros organizado de Mayor a Menor";
			// 
			// txtDescendente
			// 
			this.txtDescendente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.txtDescendente.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtDescendente.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescendente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
			this.txtDescendente.Location = new System.Drawing.Point(65, 482);
			this.txtDescendente.Margin = new System.Windows.Forms.Padding(4);
			this.txtDescendente.Name = "txtDescendente";
			this.txtDescendente.Size = new System.Drawing.Size(388, 40);
			this.txtDescendente.TabIndex = 9;
			this.txtDescendente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
			this.label4.Location = new System.Drawing.Point(27, 19);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(140, 49);
			this.label4.TabIndex = 8;
			this.label4.Text = "1 2 3";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnOrdenar
			// 
			this.btnOrdenar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOrdenar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.btnOrdenar.Location = new System.Drawing.Point(65, 326);
			this.btnOrdenar.Margin = new System.Windows.Forms.Padding(4);
			this.btnOrdenar.Name = "btnOrdenar";
			this.btnOrdenar.Size = new System.Drawing.Size(388, 49);
			this.btnOrdenar.TabIndex = 7;
			this.btnOrdenar.Text = "Ordenar";
			this.btnOrdenar.UseVisualStyleBackColor = true;
			this.btnOrdenar.Click += new System.EventHandler(this.BtnOrdenarClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
			this.label3.Location = new System.Drawing.Point(65, 227);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(272, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Ingresa tu arreglo de numeros aqui";
			// 
			// txtNumeros
			// 
			this.txtNumeros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.txtNumeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNumeros.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumeros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
			this.txtNumeros.Location = new System.Drawing.Point(65, 254);
			this.txtNumeros.Margin = new System.Windows.Forms.Padding(4);
			this.txtNumeros.Name = "txtNumeros";
			this.txtNumeros.Size = new System.Drawing.Size(388, 40);
			this.txtNumeros.TabIndex = 4;
			this.txtNumeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnVolver
			// 
			this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.btnVolver.Location = new System.Drawing.Point(65, 383);
			this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(388, 49);
			this.btnVolver.TabIndex = 13;
			this.btnVolver.Text = "Volver al Menú";
			this.btnVolver.UseVisualStyleBackColor = true;
			this.btnVolver.Click += new System.EventHandler(this.BtnVolverClick);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.ClientSize = new System.Drawing.Size(1110, 686);
			this.Controls.Add(this.panel1);
			this.Name = "Form2";
			this.Text = "Form2";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnVolver;
		private System.Windows.Forms.Button btnOrdenar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDescendente;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtAscendente;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNumeros;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
