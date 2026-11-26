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
	partial class Form4
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
			this.txtPalabra = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnInversa = new System.Windows.Forms.Button();
			this.txtResultado = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(3, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(561, 52);
			this.label1.TabIndex = 0;
			this.label1.Text = "  Reversedor de palabras";
			// 
			// txtPalabra
			// 
			this.txtPalabra.Location = new System.Drawing.Point(72, 166);
			this.txtPalabra.Multiline = true;
			this.txtPalabra.Name = "txtPalabra";
			this.txtPalabra.Size = new System.Drawing.Size(530, 36);
			this.txtPalabra.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(27, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(352, 43);
			this.label2.TabIndex = 2;
			this.label2.Text = "  Ingresa tu palabra:";
			// 
			// btnInversa
			// 
			this.btnInversa.BackColor = System.Drawing.Color.Green;
			this.btnInversa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInversa.Location = new System.Drawing.Point(72, 231);
			this.btnInversa.Name = "btnInversa";
			this.btnInversa.Size = new System.Drawing.Size(530, 44);
			this.btnInversa.TabIndex = 3;
			this.btnInversa.Text = "Inversa";
			this.btnInversa.UseVisualStyleBackColor = false;
			this.btnInversa.Click += new System.EventHandler(this.BtnInversaClick);
			// 
			// txtResultado
			// 
			this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtResultado.Location = new System.Drawing.Point(72, 349);
			this.txtResultado.Multiline = true;
			this.txtResultado.Name = "txtResultado";
			this.txtResultado.Size = new System.Drawing.Size(530, 59);
			this.txtResultado.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(27, 303);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(259, 43);
			this.label3.TabIndex = 5;
			this.label3.Text = "  Resultado:";
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.Location = new System.Drawing.Point(473, 303);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(129, 31);
			this.btnLimpiar.TabIndex = 6;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// btnRegresar
			// 
			this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegresar.Location = new System.Drawing.Point(473, 425);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(129, 31);
			this.btnRegresar.TabIndex = 7;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnRegresar);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.btnLimpiar);
			this.panel1.Controls.Add(this.txtPalabra);
			this.panel1.Controls.Add(this.txtResultado);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.btnInversa);
			this.panel1.Location = new System.Drawing.Point(218, 49);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(689, 565);
			this.panel1.TabIndex = 8;
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.ClientSize = new System.Drawing.Size(1110, 686);
			this.Controls.Add(this.panel1);
			this.Name = "Form4";
			this.Text = "Palabra al reves";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtResultado;
		private System.Windows.Forms.Button btnInversa;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPalabra;
		private System.Windows.Forms.Label label1;
	}
}
