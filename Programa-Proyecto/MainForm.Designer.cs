/*
 * Creado por SharpDevelop.
 * Usuario: ahren
 * Fecha: 25/11/2026
 * Hora: 01:46 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Programa_Proyecto
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtContrasena = new System.Windows.Forms.TextBox();
			this.btnIniciarSesion = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
			this.label1.Location = new System.Drawing.Point(17, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(184, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bienvenido";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.btnIniciarSesion);
			this.panel1.Controls.Add(this.txtContrasena);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtUsuario);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(262, 31);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(355, 465);
			this.panel1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
			this.label2.Location = new System.Drawing.Point(17, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(295, 35);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ingresa tu información de Inicio de Sesión para continuar.";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
			this.label3.Location = new System.Drawing.Point(30, 184);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "Usuario";
			// 
			// txtUsuario
			// 
			this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
			this.txtUsuario.Location = new System.Drawing.Point(30, 206);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(291, 32);
			this.txtUsuario.TabIndex = 3;
			this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
			this.label4.Location = new System.Drawing.Point(30, 253);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 19);
			this.label4.TabIndex = 4;
			this.label4.Text = "Contraseña";
			// 
			// txtContrasena
			// 
			this.txtContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtContrasena.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
			this.txtContrasena.Location = new System.Drawing.Point(30, 275);
			this.txtContrasena.Name = "txtContrasena";
			this.txtContrasena.Size = new System.Drawing.Size(291, 32);
			this.txtContrasena.TabIndex = 5;
			this.txtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnIniciarSesion
			// 
			this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIniciarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.btnIniciarSesion.Location = new System.Drawing.Point(30, 361);
			this.btnIniciarSesion.Name = "btnIniciarSesion";
			this.btnIniciarSesion.Size = new System.Drawing.Size(291, 40);
			this.btnIniciarSesion.TabIndex = 6;
			this.btnIniciarSesion.Text = "Iniciar Sesión";
			this.btnIniciarSesion.UseVisualStyleBackColor = true;
			this.btnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesionClick);
			// 
			// checkBox1
			// 
			this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
			this.checkBox1.Location = new System.Drawing.Point(30, 322);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(173, 24);
			this.checkBox1.TabIndex = 7;
			this.checkBox1.Text = "Mantener sesión iniciada";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(91, 85);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
			this.label5.Location = new System.Drawing.Point(30, 417);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(295, 35);
			this.label5.TabIndex = 8;
			this.label5.Text = "Tip: El usuario y contraseña NO SON: cbtis, 2026";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.ClientSize = new System.Drawing.Size(876, 543);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pantalla de Inicio de Sesion";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtContrasena;
		private System.Windows.Forms.Button btnIniciarSesion;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
	}
}
