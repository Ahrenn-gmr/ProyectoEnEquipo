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
	partial class Form3
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.btnVolver = new System.Windows.Forms.Button();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPromedio = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtMenor = new System.Windows.Forms.TextBox();
			this.txtMayor = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNumeros = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
			this.panel1.Controls.Add(this.btnLimpiar);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.btnVolver);
			this.panel1.Controls.Add(this.btnCalcular);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtPromedio);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtMenor);
			this.panel1.Controls.Add(this.txtMayor);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtNumeros);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(342, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(512, 663);
			this.panel1.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
			this.label7.Location = new System.Drawing.Point(22, 30);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(168, 49);
			this.label7.TabIndex = 15;
			this.label7.Text = "5, 2, 19";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnVolver
			// 
			this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.btnVolver.Location = new System.Drawing.Point(63, 587);
			this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(388, 49);
			this.btnVolver.TabIndex = 14;
			this.btnVolver.Text = "Volver al Menú";
			this.btnVolver.UseVisualStyleBackColor = true;
			this.btnVolver.Click += new System.EventHandler(this.BtnVolverClick);
			// 
			// btnCalcular
			// 
			this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.btnCalcular.Location = new System.Drawing.Point(63, 473);
			this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(388, 49);
			this.btnCalcular.TabIndex = 12;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
			this.label6.Location = new System.Drawing.Point(378, 379);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(135, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Promedio";
			// 
			// txtPromedio
			// 
			this.txtPromedio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.txtPromedio.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPromedio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPromedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
			this.txtPromedio.Location = new System.Drawing.Point(378, 406);
			this.txtPromedio.Margin = new System.Windows.Forms.Padding(4);
			this.txtPromedio.Name = "txtPromedio";
			this.txtPromedio.Size = new System.Drawing.Size(114, 40);
			this.txtPromedio.TabIndex = 10;
			this.txtPromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
			this.label5.Location = new System.Drawing.Point(216, 379);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(135, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Menor";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
			this.label4.Location = new System.Drawing.Point(43, 379);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(135, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Mayor";
			// 
			// txtMenor
			// 
			this.txtMenor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.txtMenor.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtMenor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMenor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
			this.txtMenor.Location = new System.Drawing.Point(216, 406);
			this.txtMenor.Margin = new System.Windows.Forms.Padding(4);
			this.txtMenor.Name = "txtMenor";
			this.txtMenor.Size = new System.Drawing.Size(106, 40);
			this.txtMenor.TabIndex = 7;
			this.txtMenor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtMayor
			// 
			this.txtMayor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.txtMayor.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtMayor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMayor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
			this.txtMayor.Location = new System.Drawing.Point(43, 406);
			this.txtMayor.Margin = new System.Windows.Forms.Padding(4);
			this.txtMayor.Name = "txtMayor";
			this.txtMayor.Size = new System.Drawing.Size(106, 40);
			this.txtMayor.TabIndex = 6;
			this.txtMayor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
			this.label3.Location = new System.Drawing.Point(63, 272);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(259, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Ingresa tu arreglo de numeros";
			// 
			// txtNumeros
			// 
			this.txtNumeros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.txtNumeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNumeros.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumeros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
			this.txtNumeros.Location = new System.Drawing.Point(63, 299);
			this.txtNumeros.Margin = new System.Windows.Forms.Padding(4);
			this.txtNumeros.Name = "txtNumeros";
			this.txtNumeros.Size = new System.Drawing.Size(388, 40);
			this.txtNumeros.TabIndex = 4;
			this.txtNumeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
			this.label2.Location = new System.Drawing.Point(33, 189);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(434, 62);
			this.label2.TabIndex = 3;
			this.label2.Text = "Ingresa un arreglo de numeros y te mostrará el mayor, el menor y promedio de los " +
			"numeros que hayas ingresado";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
			this.label1.Location = new System.Drawing.Point(22, 79);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(470, 110);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mayor, menor y promedio de Numeros";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.btnLimpiar.Location = new System.Drawing.Point(63, 530);
			this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(388, 49);
			this.btnLimpiar.TabIndex = 16;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.ClientSize = new System.Drawing.Size(1185, 687);
			this.Controls.Add(this.panel1);
			this.Name = "Form3";
			this.Text = "Mayor, menor y promedio";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnVolver;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMayor;
		private System.Windows.Forms.TextBox txtMenor;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtPromedio;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtNumeros;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
	}
}
